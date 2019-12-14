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

namespace eTravelAgency.Desktop.Attractions
{
    public partial class frmAttraction : Form
    {
        private readonly APIService _service = new APIService("attraction");
        public frmAttraction()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNewCompany_Click(object sender, EventArgs e)
        {
            frmAttractionDetails frm = new frmAttractionDetails();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            attractionPanel.Controls.Clear();
            attractionPanel.Controls.Add(frm);
            frm.Show();
        }

       

        private async void frmAttraction_Load(object sender, EventArgs e)
        {
            var cities = await new APIService("city").Get<List<CityDTO>>(null);

            comboBox_Cities.DataSource = new BindingSource(cities, null);
            comboBox_Cities.DisplayMember = "CityName";
            comboBox_Cities.ValueMember = "Id";


        }

        private async  void searchButton_Click(object sender, EventArgs e)
        {
            var attractions = await _service.Get<List<AttractionDTO>>(new AttractionSearchRequest { CityId = int.Parse(comboBox_Cities.SelectedValue.ToString()) });
            attrGrid.DataSource = new BindingSource(attractions, null);
            attrGrid.Columns[0].Visible = false;
            attrGrid.Columns[1].Visible = false;
        }

        private void attrGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = attrGrid.SelectedRows[0].Cells[0].Value;
            frmAttractionDetails frm = new frmAttractionDetails(int.Parse(id.ToString()))
            {
                TopLevel = false,
                AutoScroll = false,
                WindowState = FormWindowState.Maximized
            };
            attrGrid.Parent.Controls.Add(frm);
            frm.Show();
        }
    }
}
