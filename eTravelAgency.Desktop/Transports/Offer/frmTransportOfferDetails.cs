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

namespace eTravelAgency.Desktop.Transports.Offer
{
    public partial class frmTransportOfferDetails : Form
    {
        private int? _id = null;
        private readonly APIService _service = new APIService("transportoffer");
        public frmTransportOfferDetails(int? id=null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void BtnSumbit_Click(object sender, EventArgs e)
        {
            if (txtboxPanel.Controls.OfType<TextBox>().ToArray().Any(txt => string.IsNullOrEmpty(txt.Text)) || offerThum.Image == null) return;
            var company = await new APIService("transportcompany").
                GetById<TransportCompanyDTO>(int.Parse(cmbBox_TransportCompany.SelectedValue.ToString()));
            
            if (company == null)return;
            TransportOfferInsertRequest request = new TransportOfferInsertRequest
            {
                TransportCompanyId = int.Parse(cmbBox_TransportCompany.SelectedValue.ToString()),
                CityId = int.Parse(cmbBox_CityDestination.SelectedValue.ToString()),
                Price = float.Parse(txtbox_Price.Text),
                Discount = int.Parse(txtbox_Discount.Text),
                StartDate = DateTime.Parse(txtBox_StartDate.Text),
                EndDate= DateTime.Parse(txtbox_EndDate.Text),
                IsActive = txtBox_Active.Text == "YES"?true:false
            };
            if (_id.HasValue)
            {
                var offer = await _service.GetById<TransportOfferDTO>(_id.Value);
                request.CityId = offer.CityId;
            }

                var image = new Bitmap(offerThum.Image, 400, 400);
                using(var newStream = new MemoryStream())
                {
                    image.Save(newStream,ImageFormat.Png);
                    request.ThumbnailImage = newStream.ToArray();
                }

            TransportOfferDTO res = null;
            if (_id.HasValue)
            {
                 res = await _service.Update<TransportOfferDTO>(_id.Value,request);
            }
            else
            {
                res = await _service.Insert<TransportOfferDTO>(request);
            }
            var message = (res != null) ? "Successufully added new transport offer" : "Error: couldn't add new transport offer";
            MessageBox.Show(message);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            var textBoxes = txtboxPanel.Controls.OfType<TextBox>().ToArray();
            var mTxtBox = txtboxPanel.Controls.OfType<MaskedTextBox>().ToArray();
            foreach (var mtxt in mTxtBox)
            {
                mtxt.Text = string.Empty;
            }
            foreach(var txtbox in textBoxes)
            {
                txtbox.Text = string.Empty;
            }
        }

        private async void FrmTransportOfferDetails_Load(object sender, EventArgs e)
        {
            var tCompanies = await new APIService("transportcompany").Get<List<TransportCompanyDTO>>(null);
            cmbBox_TransportCompany.ValueMember = "Id";
            cmbBox_TransportCompany.DisplayMember = "TransportCompanyName";
            cmbBox_TransportCompany.DataSource = new BindingSource(tCompanies, null);

            var cities = await new APIService("city").Get<List<CityDTO>>(null);
            cmbBox_CityDestination.ValueMember = "Id";
            cmbBox_CityDestination.DisplayMember = "CityName";
            cmbBox_CityDestination.DataSource = new BindingSource(cities, null);


            if (_id.HasValue)
            {
                APIService _reservationService = new APIService("reservation");
                var reservations = (await _reservationService.Get<List<ReservationDTO>>(new ReservationSearchRequest { TransportOfferId = _id.Value }));
                bool tripSet = reservations.All(_=>_.StartTripDate != DateTime.MinValue);
                if (tripSet)
                {
                    mTxtBox_TripDate.Text = reservations.FirstOrDefault()?.StartTripDate.ToString("dd.MM.yyyy");
                }
                var res = await _service.GetById<TransportOfferDTO>(_id.Value);
//                cmbBox_TransportCompany.SelectedItem = cmbBox_TransportCompany.Items.IndexOf(res.TransportCompanyId);
                cmbBox_TransportCompany.SelectedValue = res.TransportCompanyId;
                cmbBox_CityDestination.SelectedValue = res.CityId;
        //        cmbBox_CityDestination.SelectedValue = cmbBox_CityDestination.Items.IndexOf(res.CityId);
                txtBox_Active.Text = res.IsActive ? "YES" : "NO";
                txtbox_Discount.Text = res.Discount.ToString();
                txtbox_EndDate.Text = res.EndDate.ToString("dd.MM.yyyy");
                txtBox_StartDate.Text = res.StartDate.ToString("dd.MM.yyyy");
                txtbox_Price.Text = res.Price.ToString();
                using (var ms = new MemoryStream(res.ThumbnailImage))
                {
                    offerThum.Image = Image.FromStream(ms);

                }


            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string location = "";
                location = dialog.FileName;
                offerThum.ImageLocation = location;
            }
        }

        private async void btnBack_ClickAsync(object sender, EventArgs e)
        {
                if(mTxtBox_TripDate.Text != "  -  -")
                {
    
                    APIService _reservationService = new APIService("reservation");
    
                    var reservations = await _reservationService.Get<List<ReservationDTO>>(new ReservationSearchRequest { TransportOfferId = _id.Value });
                    foreach (var item in reservations)
                    {
                        var req = new ReservationInsertRequest
                        {
                            StartTripDate = DateTime.Parse(mTxtBox_TripDate.Text),
                            Canceled = item.Canceled,
                            Finished = item.Finished,
                            DateReserved = item.DateReserved,
                            HotelOfferId = item.HotelOfferId,
                            TransportOfferId = item.TransportOfferId,
                            NumberOfDays = item.NumberOfDays,
                            NumberOfPersons = item.NumberOfPersons,
                            TotalPrice = item.TotalPrice,
                            UserId = item.UserId
                        };
                        var res = await _reservationService.Update<ReservationDTO>(item.Id, req);
                        if (res == null) MessageBox.Show("Problem occured while trying to update reservations", "OK");
                }
            }
        }
    }
}
