using eTravelAgency.Core.Requests;
using eTravelAgency.Desktop.Transports.Offer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Transports
{
    public partial class frmTransportOffers : Form
    {
        private readonly APIService _service = new APIService("transportoffer");
        public frmTransportOffers()
        {
            InitializeComponent();
        }

        private async void FrmTransportOffers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = transportsGrid.SelectedRows[0].Cells[0].Value;
            var res = await _service.GetById<TransportOfferDTO>(int.Parse(id.ToString()));

            frmTransportOfferDetails frm = new frmTransportOfferDetails(int.Parse(id.ToString()));
            this.Parent.Controls.Add(frm);
            frm.Show();
        }

        private async void frmTransportOffers_Load(object sender, EventArgs e)
        {
            var cities = await new APIService("city").Get<List<CityDTO>>(null);
            cmbBox_tCompanies.DataSource= new BindingSource(cities, null);
            cmbBox_tCompanies.DisplayMember = "CityName";
            cmbBox_tCompanies.ValueMember = "Id";

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {

            var tOffers = await _service.Get<List<TransportOfferDTO>>(new TransportOfferDTO { CityId = int.Parse(cmbBox_tCompanies.SelectedValue.ToString())});
            transportsGrid.DataSource = new BindingSource(tOffers, null);
            transportsGrid.Columns[0].Visible = false;
            transportsGrid.Columns[1].Visible = false;
        }

        private void transportsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = transportsGrid.SelectedRows[0].Cells[0].Value;
            frmTransportOfferDetails frm = new frmTransportOfferDetails(int.Parse(id.ToString()))
            {
                TopLevel = false,
                AutoScroll = false,
                WindowState = FormWindowState.Maximized
            };
            this.Parent.Controls.Add(frm);
            frm.Show();
        }

        private void btnNewOffer_Click(object sender, EventArgs e)
        {
            frmTransportOfferDetails frm = new frmTransportOfferDetails()
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
