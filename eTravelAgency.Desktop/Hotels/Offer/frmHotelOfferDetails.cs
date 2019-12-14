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

namespace eTravelAgency.Desktop.Hotels.Offer
{
    public partial class frmHotelOfferDetails : Form
    {
        private readonly APIService _service = new APIService("hoteloffer");
        private int? _id = null;
        public frmHotelOfferDetails(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }
        
 

        private async void BtnSumbit_Click(object sender, EventArgs e)
        {
            var textBoxes = offerPanel.Controls.OfType<TextBox>().ToArray();
            var maskedBoxes = offerPanel.Controls.OfType<MaskedTextBox>().ToArray();
            if (textBoxes.Any(_ => string.IsNullOrEmpty(_.Text)) ||
                maskedBoxes.Any(_ => string.IsNullOrEmpty(_.Text)))
            {
                MessageBox.Show("Fields can't be empty", "OK");
                return;
            }

            var foundHotel = (await new APIService("hotel").GetById<HotelDTO>(int.Parse(cmbBox_HotelName.SelectedValue.ToString())));
            if (foundHotel == null) return;
            string message = "";
            HotelOfferInsertRequest request = new HotelOfferInsertRequest {
                Discount = int.Parse(txtBox_Discount.Text),
                StarDate = DateTime.Parse(mtxtBox_StartDate.Text),
                EndDate = DateTime.Parse(mtxtBox_EndDate.Text),
                PricePerPerson = float.Parse(txtBox_Price.Text),
                IsActive = txtBox_Active.Text == "YES"?true:false,
                HotelId =foundHotel.Id
            };
            Image image = null;
            using (var ms = new MemoryStream(foundHotel.Picture))
            {
               image = new Bitmap(Image.FromStream(ms),400,400);
               using(var newStream= new MemoryStream())
               {
                    image.Save(newStream, ImageFormat.Png);
                    request.ThumbnailImage = newStream.ToArray();
               }
            }
                HotelOfferInsertRequest res = null;
            if (_id.HasValue)
            {
               res = await _service.Update<HotelOfferInsertRequest>(_id,request);
            }
            else
            {
                res = await _service.Insert<HotelOfferInsertRequest>(request);
            }
            message= (res!=null)?"Successufully added new offer":"Error: Can't add new offer";
            MessageBox.Show(message);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            var controls = offerPanel.Controls.OfType<TextBox>().ToArray();
            foreach (var control in controls)
            {
                control.Text = string.Empty;
            }
            foreach (var control in offerPanel.Controls.OfType<MaskedTextBox>().ToArray())
            {
                control.Text = string.Empty;
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!_id.HasValue)
            {
                MessageBox.Show("This offer does not exist");
            }
            else
            {
                var res = await _service.Delete<HotelOfferDTO>(_id);
                if (res != null)
                    MessageBox.Show("Successufully deleted offer");
                else
                    MessageBox.Show("Error: can not delete offer");
            }
            
        }

        private async void FrmHotelOfferDetails_Load(object sender, EventArgs e)
        {
            var hotels = await (new APIService("hotel").Get<List<HotelDTO>>(new HotelSearchRequest { HotelName = "" }));

            cmbBox_HotelName.DataSource = new BindingSource(hotels, null);
            cmbBox_HotelName.DisplayMember = "HotelName";
            cmbBox_HotelName.ValueMember = "Id";
            if (_id.HasValue)
            {
                var res = await _service.GetById<HotelOfferDTO>(_id);
                if (res != null)
                {   
                    txtBox_Discount.Text = res.Discount.ToString();
                    txtBox_Active.Text = res.IsActive ? "YES" : "NO";
                    txtBox_Price.Text = res.PricePerPerson.ToString();
                    mtxtBox_StartDate.Text = res.StartDate.ToString("dd.MM.yyyy");
                    mtxtBox_EndDate.Text = res.EndDate.ToString("dd.MM.yyyy");
                    cmbBox_HotelName.SelectedItem = cmbBox_HotelName.Items.IndexOf(res.HotelId);
                }
            }
        }

      
    }
}
