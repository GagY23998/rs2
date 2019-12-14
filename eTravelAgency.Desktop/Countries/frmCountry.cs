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

namespace eTravelAgency.Desktop.Countries
{
    public partial class frmCountry : Form
    {
        private readonly APIService _service = new APIService("country");
        public frmCountry()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewCompany_Click(object sender, EventArgs e)
        {
            frmCountryDetails frm = new frmCountryDetails();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            CountryPanel.Controls.Clear();
            CountryPanel.Controls.Add(frm);
            frm.Show();

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_TransportSearch.Text))
            {
                var request = new CountrySearchRequest { CountryName = txtBox_TransportSearch.Text };
                var result = await _service.Get<List<CountryDTO>>(request);
                BindingSource source = new BindingSource(result, null);
                countryGrid.DataSource = source;
                countryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void CountryGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = countryGrid.SelectedRows[0].Cells[0].Value;
            frmCountryDetails frm = new frmCountryDetails(int.Parse(id.ToString())) { TopLevel = false, WindowState = FormWindowState.Maximized };
            this.Controls.Clear();
            this.Controls.Add(frm);
            frm.Show();

        }
    }
}
