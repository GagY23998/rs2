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

namespace eTravelAgency.Desktop.Attractions
{
    public partial class frmAttractionDetails : Form
    {
        private readonly APIService _service = new APIService("attraction");
        private int? _id = null;
        private int? _cityId = null;
        public frmAttractionDetails(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtBox_AttrName.Text = string.Empty;
            txtBox_AttrDetails.Text = string.Empty;
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!_id.HasValue)
            {
                MessageBox.Show("This attraction doesn't exist");
            }
            else
            {
                var res = await _service.Delete<AttractionDTO>(_id);
                var message = (res != null) ? "Successufully deleted attraction" : "Error: can't delete attraction";
                MessageBox.Show(message);
            }
        }

        private async void FrmAttractionDetails_Load(object sender, EventArgs e)
        {
            var cities = (await new APIService("city").Get<List<CityDTO>>(null));
            cmbBox_City.DataSource = new BindingSource(cities, null);
            cmbBox_City.DisplayMember = "CityName";
            cmbBox_City.ValueMember = "Id";
            if (_id.HasValue)
            {
                var res = await _service.GetById<AttractionDTO>(_id.Value);
                txtBox_AttrName.Text= res.AttractionName;
                txtBox_AttrDetails.Text = res.AttractionDetails;
                _cityId = res.CityId;
                cmbBox_City.SelectedValue =res.CityId;
                using (MemoryStream stream = new MemoryStream(res.Picture))
                {
                    Image image = new Bitmap(Image.FromStream(stream), picBox_AttractionPicture.Width, picBox_AttractionPicture.Height);
                    picBox_AttractionPicture.Image = image;
                }

            }
        }

        private async void btnSumbit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBox_AttrDetails.Text)|| string.IsNullOrEmpty(txtBox_AttrName.Text) || cmbBox_City.SelectedValue == null)
            {
                MessageBox.Show("Fields can't be emtpy", "OK");
                return;
            }
            AttractionInsertRequest req = new AttractionInsertRequest();
                req.AttractionDetails = txtBox_AttrDetails.Text;
                req.AttractionName = txtBox_AttrName.Text;
                req.CityId = _cityId.Value;
                using (var ms = new MemoryStream())
                {
                    picBox_AttractionPicture.Image.Save(ms, ImageFormat.Png);
                    req.Picture = ms.ToArray();
                }
            var res = _id.HasValue ? await _service.Update<AttractionDTO>(_id.Value, req) : await _service.Insert<AttractionDTO>(req);
            if (res != null) MessageBox.Show("Successufully proceeded request", "OK");
        }
    }
}
 