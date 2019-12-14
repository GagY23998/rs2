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

namespace eTravelAgency.Desktop.Hotels.Hotel
{
    public partial class frmHotel : Form
    {
        private readonly APIService _service = new APIService("hotel");
        public frmHotel()
        {
            InitializeComponent();
        }

        private async void FrmHotel_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<HotelDTO>>(new HotelSearchRequest { HotelName = "" });
            if (result.Count == 0) return;
            BindingSource source = new BindingSource(result,null);
            hotelGrid.DataSource = source;
            hotelGrid.Columns[0].Visible = false;
            hotelGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Hotel.Text)) return;
            var result = await _service.Get<List<HotelDTO>>(new HotelSearchRequest { HotelName = txtBox_Hotel.Text });
            if (result.Count == 0) return;
            BindingSource source = new BindingSource(result, null);
            hotelGrid.DataSource = source;
            
        }

        private void BtnNewHotel_Click(object sender, EventArgs e)
        {
            frmHotelDetails details = new frmHotelDetails();
            
            details.TopLevel = false;
            details.AutoScroll = false;
            details.WindowState = FormWindowState.Maximized;
            this.Parent.Controls.Add(details);
            details.Height = this.Parent.Height;
            details.Width = this.Parent.Width;
            details.Show();
        }

        private void hotelGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = hotelGrid.SelectedRows[0].Cells[0].Value;
            frmHotelDetails frm = new frmHotelDetails(int.Parse(id.ToString()));
            frm.TopLevel = false;
            frm.AutoScroll = false;
            frm.WindowState = FormWindowState.Maximized;
            this.Parent.Controls.Add(frm);
            frm.Show();
        }
    }
}
