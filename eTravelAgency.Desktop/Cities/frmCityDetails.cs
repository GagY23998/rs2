using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Cities
{
    public partial class frmCityDetails : Form
    {
        private readonly APIService _service = new APIService("city");
        private int? _id = null;
        public frmCityDetails(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_CityName.Text) || string.IsNullOrEmpty(txtBox_ZipCode.Text)|| picBox_Picture.Image == null) {
                MessageBox.Show("Fields can't be empty");
                return;
            }
            var result = await new APIService("country").GetById<CountryDTO>(int.Parse(cmbBox_Country.SelectedValue.ToString()));
            if (result == null) {
                MessageBox.Show("Result not found");
                return;
            }
            var request = new CityInsertRequest
            {
                CityName = txtBox_CityName.Text,
                ZipCode = txtBox_ZipCode.Text,
                CountryId = result.Id
            };
            using (var ms = new MemoryStream())
            {
                picBox_Picture.Image.Save(ms,ImageFormat.Png);
                request.Picture = ms.ToArray();
            }
                CityInsertRequest res = null;
            if (_id.HasValue)
            {
                res = await _service.Update<CityInsertRequest>(_id,request);
            }
            else
            {
                res = await _service.Insert<CityInsertRequest>(request);
            }
            var message = (res != null) ? "Successufully added city" : "Error: can't add new city";
            MessageBox.Show(message);
        }

        private async void FrmCityDetails_Load(object sender, EventArgs e)
        {
            var result = await(new APIService("country").Get<List<CountryDTO>>(new CountryInsertRequest { CountryName =""}));
            if (result.Count == 0)
            {
                MessageBox.Show("There are no countries,can't add new city");
            }
            else
            {
                cmbBox_Country.DataSource = new BindingSource(result, null);
                cmbBox_Country.DisplayMember = "CountryName";
                cmbBox_Country.ValueMember = "Id";                
            }
            if (_id.HasValue)
            {
                var res = await _service.GetById<CityDTO>(_id);
                cmbBox_Country.SelectedValue =res.CountryId;
                txtBox_CityName.Text = res.CityName;
                txtBox_ZipCode.Text = res.ZipCode;
                if (res.Picture != null)
                {
                    using (var ms = new MemoryStream(res.Picture))
                    {
                        picBox_Picture.Image = Image.FromStream(ms);

                    }
                }
                
            }
        }

        private void picBox_Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter= "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string location = dialog.FileName;
                picBox_Picture.ImageLocation = location;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBox_CityName.Text = string.Empty;
            txtBox_ZipCode.Text = string.Empty;
        }
    }
}
