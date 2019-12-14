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

namespace eTravelAgency.Desktop.Transports.Type
{
    public partial class frmTransportTypeDetails : Form
    {
        public int? _id = null;
        private readonly APIService _service = new APIService("transporttype");
        public frmTransportTypeDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox_TypeName.Text))
            {
                TransportTypeInsertRequest request = new TransportTypeInsertRequest();
                request.TransportTypeName = txtbox_TypeName.Text;
                TransportTypeInsertRequest res = null;
                if (_id.HasValue)
                {
                    res = await _service.Update<TransportTypeInsertRequest>(_id, request);
                }
                else
                {
                    res = await _service.Insert<TransportTypeInsertRequest>(request);
                }
                var message =
                 (res != null) ? "Successufully added new transport type!" : "Error: Couldn't add new transport type!";
                MessageBox.Show(message);
            }
            MessageBox.Show("Fields can't be empty");
        }

        private async void FrmTransportTypeDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var res = await _service.GetById<TransportTypeDTO>(_id);
                if (res != null)
                {
                    txtbox_TypeName.Text = res.TransportTypeName;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbox_TypeName.Text = string.Empty;
        }
    }
}
