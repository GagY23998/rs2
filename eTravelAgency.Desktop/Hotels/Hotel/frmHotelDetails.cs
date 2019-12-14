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

namespace eTravelAgency.Desktop.Hotels.Hotel
{
    public partial class frmHotelDetails : Form
    {
        private readonly APIService _service = new APIService("hotel");
        private int? _id = null;
        public frmHotelDetails(int? id =null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmHotelDetails_Load(object sender, EventArgs e)
        {
            var res = await (new APIService("city").Get<List<CityDTO>>(new CitySearchRequest { CityName="" }));
            cmbBox_CityName.DataSource = res;
            cmbBox_CityName.DisplayMember = "CityName";
            cmbBox_CityName.ValueMember = "Id";
            if (_id.HasValue)
            {
                var hotel = await _service.GetById<HotelDTO>(_id.Value);
                txtBox_HotelName.Text = hotel.HotelName;
                txtBox_Address.Text = hotel.HotelAddress;
                cmbBox_CityName.SelectedValue = hotel.CityId;
                using (var ms = new MemoryStream(hotel.Picture))
                {
                    hotelPicture.Image= Image.FromStream(ms);
                }
            }
        }

        private async void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_HotelName.Text) || string.IsNullOrEmpty(txtBox_Address.Text))
            {
                MessageBox.Show("Fields can't e empty", "OK");
                return;
            }
            var result = await (new APIService("city").GetById<CityDTO>((int)cmbBox_CityName.SelectedValue));
            if (result == null) return;

                var request = new HotelInsertRequest
                {
                    CityId = result.Id,
                    HotelName = txtBox_HotelName.Text,
                    HotelAddress = txtBox_Address.Text
                };
            using (var ms = new MemoryStream())
            {
                hotelPicture.Image.Save(ms,hotelPicture.Image.RawFormat);
                request.Picture = ms.ToArray();
            }


            HotelDTO res = null;
            if (!_id.HasValue)
            {
                res = await _service.Insert<HotelDTO>(request);
            }
            else
            {
                res = await _service.Update<HotelDTO>(_id, request);
            }
            string message = (res!=null)?"Successsufully added new hotel":"Error: can't add new hotel";
            MessageBox.Show(message);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtBox_Address.Text = string.Empty;
            txtBox_HotelName.Text = string.Empty;
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var res = await _service.Delete<HotelDTO>(_id.Value);
                string msg = (res == null) ? "Error occured during deleting a hotel" : "Hotel Deleted!";
                MessageBox.Show(msg);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string location = "";
                location = dialog.FileName;
                hotelPicture.ImageLocation = location;
            }
        }
    }
}
