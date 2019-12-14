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

namespace eTravelAgency.Desktop.Countries
{
    public partial class frmCountryDetails : Form
    {
        private readonly APIService _service = new APIService("country");
        private int? _id = null;
        public frmCountryDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_CountryDetails.Text) ||
                string.IsNullOrEmpty(txtBox_CountryName.Text) ||
                picBox_CountryPic.Image == null) 
            {
                MessageBox.Show("Fields can't be empty", "OK");
                return;
            }

            var request = new CountryInsertRequest { CountryName = txtBox_CountryName.Text, CountryDetails = txtBox_CountryDetails.Text };
            using(MemoryStream stream =new MemoryStream())
            {
                picBox_CountryPic.Image.Save(stream,picBox_CountryPic.Image.RawFormat);
                request.Picture = stream.ToArray();
            }

            CountryInsertRequest res=null;
            if (_id.HasValue)
            {
                res = await _service.Update<CountryInsertRequest>(_id.Value,request);
            }
            else
            {
                res = await _service.Insert<CountryInsertRequest>(request);
            }
            var message = (res != null) ? "Successufully added new country" : "Error: can not add new country";
            MessageBox.Show(message);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtBox_CountryDetails.Text = string.Empty;
            txtBox_CountryName.Text = string.Empty;
        }


        private async void FrmCountryDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var res = await _service.GetById<CountryDTO>(_id);
                if (res != null)
                {
                    txtBox_CountryName.Text = res.CountryName;
                    txtBox_CountryDetails.Text = res.CountryDetails;
                    using(MemoryStream stream = new MemoryStream(res.Picture))
                    {
                        Image image = new Bitmap(Image.FromStream(stream), picBox_CountryPic.Width,picBox_CountryPic.Height);
                        picBox_CountryPic.Image = image;
                    }
                }
            }
        }

        private void PicBox_CountryPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "JPG files(*.jpg)|*jpg| PNG files(*.png)|*png| All files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string location = "";
                location = openFile.FileName;
                picBox_CountryPic.ImageLocation = location;
            }
        }
    }
}
