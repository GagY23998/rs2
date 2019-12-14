using eTravelAgency.Core.Requests;
using eTravelAgency.Desktop.Transports.Type;
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
    public partial class frmTransportTypes : Form
    {
        private readonly APIService _service = new APIService("transporttype");
        public frmTransportTypes()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_TransportSearch.Text))
            {
                var result = await _service.Get<TransportTypeDTO>(new TransportTypeSearchRequest {
                                                            TransportTypeName =txtBox_TransportSearch.Text });
                BindingSource source = new BindingSource(result, null);
                transportsGrid.DataSource = source;
            }

        }

        private void BtnNewTypes_Click(object sender, EventArgs e)
        {
            frmTransportTypeDetails typeDetails = new frmTransportTypeDetails();
            typeDetails.AutoScroll = false;
            typeDetails.TopLevel = false;
            this.Parent.Controls.Add(typeDetails);
            typeDetails.Show();
            this.Close();

        }

        private async void FrmTransportTypes_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<TransportTypeDTO>>(new TransportTypeSearchRequest
            {
                TransportTypeName = txtBox_TransportSearch.Text
            });
            BindingSource source = new BindingSource(result, null);
            transportsGrid.DataSource = source;
            transportsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transportsGrid.Columns[0].Visible = false;
            transportsGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private async void TransportsGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = transportsGrid.SelectedRows[0].Cells[0].Value;

            var res= await _service.GetById<TransportTypeDTO>(int.Parse(id.ToString()));
            if (res != null)
            {
                frmTransportTypeDetails typeDetails = new frmTransportTypeDetails(int.Parse(id.ToString()));
                typeDetails.AutoScroll = false;
                typeDetails.TopLevel = false;
                this.Parent.Controls.Add(typeDetails);
                typeDetails.Show();
                this.Close();
            }
        }
    }
}
