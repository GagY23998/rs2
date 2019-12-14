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

namespace eTravelAgency.Desktop.Hotels.Offer
{
    public partial class frmHotelOffer : Form
    {
        private readonly APIService _service = new APIService("hoteloffer");
        public frmHotelOffer()
        {
            InitializeComponent();
        }

        private void BtnNewHotel_Click(object sender, EventArgs e)
        {
            frmHotelOfferDetails details = new frmHotelOfferDetails();
            details.AutoScroll = false;
            details.WindowState = FormWindowState.Maximized;
            details.TopLevel = false;
            this.Parent.Controls.Add(details);
            details.Show();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbBox_HotelNames.SelectedValue.ToString()))
            {
                var result = await _service.Get<List<HotelOfferDTO>>(new HotelOfferSearchRequest { HotelId=int.Parse(cmbBox_HotelNames.SelectedValue.ToString())});
                BindingSource source = new BindingSource(result, null);
                offerGrid.DataSource = source;
                offerGrid.Columns[0].Visible = false;
                offerGrid.Columns[1].Visible = false;
                offerGrid.Columns[2].Visible = false;
                offerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Field can't be empty");
            }
        }

        private void OfferGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = offerGrid.SelectedRows[0].Cells[0].Value;

            frmHotelOfferDetails frm = new frmHotelOfferDetails(int.Parse(id.ToString()))
            {
                AutoScroll = false,
                TopLevel=false,
                WindowState= FormWindowState.Maximized
            };
           
            this.Parent.Controls.Add(frm);
            frm.Show();

        }

        private async void frmHotelOffer_Load(object sender, EventArgs e)
        {
            APIService _hotelService = new APIService("hotel");
            var hotels = await _hotelService.Get<List<HotelDTO>>(null);
            cmbBox_HotelNames.DataSource = hotels;
            cmbBox_HotelNames.DisplayMember = "HotelName";
            cmbBox_HotelNames.ValueMember = "Id"; 
        }
    }
}
