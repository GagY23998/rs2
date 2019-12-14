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

namespace eTravelAgency.Desktop.Cities
{
    public partial class frmCities : Form
    {
        private readonly APIService _service = new APIService("city");

        public frmCities()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewCity_Click(object sender, EventArgs e)
        {
            frmCityDetails frm = new frmCityDetails();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(frm);
            panel1.Controls.SetChildIndex(frm, 0);
            frm.Show();

        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_City.Text))
            {
                MessageBox.Show("Field's can't be empty");
                return;
            }
            var result = await _service.Get<List<CityDTO>>(new CityInsertRequest { CityName = txtBox_City.Text });
            BindingSource source = new BindingSource(result, null);
            citiesGrid.DataSource = source;
            citiesGrid.Columns[0].Visible = false;
            citiesGrid.Columns[1].Visible = false;
        }

        private void CitiesGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = citiesGrid.SelectedRows[0].Cells[0].Value;

            frmCityDetails frm = new frmCityDetails(int.Parse(id.ToString()))
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
