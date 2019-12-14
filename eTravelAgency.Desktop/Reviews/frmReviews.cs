using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Reviews
{
    public partial class frmReviews : Form
    {
        private readonly APIService _service = new APIService("rating");
        public frmReviews()
        {
            InitializeComponent();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            HotelDTO hotel = null;
            TransportCompanyDTO tCompany = null;
            if (!string.IsNullOrEmpty(txtBox_Hotel.Text))
            {
                 hotel = (await new APIService("hotel").Get<List<HotelDTO>>(new HotelSearchRequest {
                    HotelName = txtBox_Hotel.Text
                })).FirstOrDefault();
            }
            if (!string.IsNullOrEmpty(txtBox_tCompany.Text))
            {
                tCompany = (await new APIService("transportcompany").Get<List<TransportCompanyDTO>>(new TransportCompanySearchRequest
                {
                    TransportCompanyName =txtBox_tCompany.Text
                })).FirstOrDefault();

            }
            if (hotel == null && tCompany == null) { 
                MessageBox.Show("No result", "OK");
                return;
            }
            var req = new RatingSearchRequest
            {
                HotelId = hotel!=null?hotel.Id:0,
                TransportCompanyId =tCompany!=null?tCompany.Id:0,
                Rating = !(string.IsNullOrEmpty(txtBox_Rating.Text))?int.Parse(txtBox_Rating.Text):0
            };

            var res = await _service.Get<List<RatingDTO>>(req);
            var source = new BindingSource(res, null);
            reviewsGrid.DataSource = source;
            reviewsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            reviewsGrid.Columns[0].Visible = false;
            reviewsGrid.Columns[1].Visible = false;
            reviewsGrid.Columns[2].Visible = false;
            reviewsGrid.Columns[3].Visible = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reviewsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = reviewsGrid.SelectedRows[0].Cells[0].Value;
            frmReviewDetails frm = new frmReviewDetails(int.Parse(id.ToString()))
            {
                TopLevel = false,
                AutoScroll = false,
                WindowState = FormWindowState.Maximized
            };
            this.Parent.Controls.Add(frm);
            frm.Show();
        }
    }
}
