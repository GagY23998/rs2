using eTravelAgency.Core.Requests;
using eTravelAgency.Desktop.Transports.Company;
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
    public partial class frmTransportCompany : Form
    {
        private readonly APIService _service = new APIService("transportcompany");
        public frmTransportCompany()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_TransportSearch.Text)) return;
            var searchrequest = new TransportCompanySearchRequest
            {
                TransportCompanyName = txtBox_TransportSearch.Text
            };
            var result = await _service.Get<List<TransportCompanyDTO>>(searchrequest);
            if(result == null)
            {
                MessageBox.Show("Company could not be found");
                return;
            }
            transportsGrid.DataSource = new BindingSource(result, null);
            transportsGrid.Columns[0].Visible = false;
        }

        private async void FrmTransportCompany_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<TransportCompanyDTO>>(null);
            BindingSource bindingSource = new BindingSource(result, null);
            transportsGrid.DataSource = bindingSource;
            transportsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // transportsGrid.RowHeadersVisible = false;
            transportsGrid.Columns[0].Visible = false;
            transportsGrid.Columns[1].Visible = false;
            transportsGrid.Columns[2].HeaderText = "Transport Company Name";
        }

        private void BtnNewCompany_Click(object sender, EventArgs e)
        {
            frmCompanyDetails details = new frmCompanyDetails();
            details.TopLevel = false;
            details.AutoScroll = false;
            details.StartPosition = FormStartPosition.CenterParent;
            this.Parent.Controls.Add(details);
            details.Show();
            this.Close();
        }

        private void TransportsGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = transportsGrid.SelectedRows[0].Cells[0].Value;
            frmCompanyDetails frm = new frmCompanyDetails(int.Parse(id.ToString())) 
            {   TopLevel = false,
                AutoScroll = false, 
                WindowState = FormWindowState.Maximized
            };
            
            this.Parent.Controls.Add(frm);
            frm.Show();

        }
    }
}
