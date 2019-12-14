using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Transports.Company
{
    public partial class frmCompanyDetails : Form
    {
        private int? _id = null;
        private readonly APIService _service = new APIService("transportcompany");
        public frmCompanyDetails(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                await _service.Delete<TransportCompany>(_id);
            }
        }

        private async void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (txtboxPanel.Controls.OfType<TextBox>().ToArray().Any(_ => _.Text == null)||
                string.IsNullOrEmpty((string)cmbbox_TransportType.SelectedValue.ToString()) ||
                picBox_Picture.Image==null)
            {
                MessageBox.Show("Fields can't be empty", "OK");
                return;
            }


            var ttypes =await new APIService("transporttype").Get<List<TransportTypeDTO>>();

                TransportCompanyInsertRequest request = new TransportCompanyInsertRequest();
            if (int.TryParse(cmbbox_TransportType.SelectedValue.ToString(), out int id))
            {
                request.TransportCompanyName = txtbox_CompanyName.Text;
                request.TransportTypeId = id;
                request.IsActive = (txtBox_Active.Text=="YES")?true:false;
                if(picBox_Picture.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picBox_Picture.Image.Save(ms,picBox_Picture.Image.RawFormat);
                        request.Picture = ms.ToArray();
                    }
                }
            }
            else return;

            if (!_id.HasValue)
            {

                var result = await _service.Insert<TransportCompanyInsertRequest>(request);
            }
            else
            {
                var result = await _service.Update<TransportCompanyInsertRequest>(_id.Value, request);
            }
        }

        private async void FrmCompanyDetails_Load(object sender, EventArgs e)
        {
            

            var result = await new APIService("transporttype").Get<List<TransportTypeDTO>>(new TransportTypeSearchRequest { TransportTypeName=""});
            
            result.Insert(0, new TransportTypeDTO { Id=0,TransportTypeName="Name"});
            var names = result.ToList();

            BindingSource source = new BindingSource(names,null); 
            cmbbox_TransportType.DataSource = source;
            cmbbox_TransportType.DisplayMember = "TransportTypeName";
            cmbbox_TransportType.ValueMember = "Id";
            if (_id.HasValue)
            {
                var res = await _service.GetById<TransportCompanyDTO>(_id);
                cmbbox_TransportType.SelectedItem = cmbbox_TransportType.Items.IndexOf(res.TransportTypeId);
                txtbox_CompanyName.Text = res.TransportCompanyName;
                using (MemoryStream ms = new MemoryStream(res.Picture))
                {
                    picBox_Picture.Image = Image.FromStream(ms);
                }
                    txtBox_Active.Text = res.IsActive ? "YES" : "NO";
                cmbbox_TransportType.SelectedIndex = res.TransportTypeId;
            }

        }

        private void Txtbox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar== '.' && ((TextBox)sender).Text.IndexOf('.')<-1)
            {
                e.Handled = true;
            }
        }

        private void picBox_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG files(*.jpg) | *.jpg | PNG files(*.png) | *.png | All Files(*.*) | *.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string location = dialog.FileName;
                picBox_Picture.ImageLocation = location;
            
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbox_CompanyName.Text = string.Empty;
            txtBox_Active.Text = string.Empty;
        }
    }
}
