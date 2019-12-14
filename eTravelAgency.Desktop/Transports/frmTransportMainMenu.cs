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

namespace eTravelAgency.Desktop.Transports
{
    public partial class frmTransportMainMenu : Form
    {
        private readonly APIService _apiService = new APIService("transports");
        public frmTransportMainMenu()
        {

            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCompanies_Click(object sender, EventArgs e)
        {
            frmTransportCompany company = new frmTransportCompany();
            company.TopLevel = false;
            company.AutoScroll = false;
            company.WindowState = FormWindowState.Maximized;
            company.StartPosition = FormStartPosition.CenterParent;
            company.Dock = DockStyle.Fill;
            TransportPanel.Controls.Clear();
            TransportPanel.Controls.Add(company);
            company.Show();
        }

        private void BtnTypes_Click(object sender, EventArgs e)
        {
            frmTransportTypes types = new frmTransportTypes();
            types.AutoScroll = false;
            types.TopLevel = false;
            types.Dock = DockStyle.Fill;
            types.Size = new Size { Height = TransportPanel.Height, Width = TransportPanel.Width };
            TransportPanel.Controls.Clear();
            TransportPanel.Controls.Add(types);
            types.Show();
        }

        private void BtnOffers_Click(object sender, EventArgs e)
        {
            frmTransportOffers offers = new frmTransportOffers();
            offers.AutoScroll = false;
            offers.TopLevel = false;
            offers.WindowState = FormWindowState.Maximized;
            offers.StartPosition = FormStartPosition.CenterParent;
            offers.Dock = DockStyle.Fill;
            TransportPanel.Controls.Clear();
            TransportPanel.Controls.Add(offers);
            offers.Show();
        }
    }
}
