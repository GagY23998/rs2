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

namespace eTravelAgency.Desktop.Reservations
{
    public partial class frmReservationDetails : Form
    {

        private readonly APIService _service = new APIService("reservation");
        private readonly int? _id = null;
        public frmReservationDetails(int? id = null)
        {
            _id = id;
            InitializeComponent();
        }

        private async void FrmReservationDetails_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _service.GetById<ReservationDTO>(_id.Value);
                var user = await (new APIService("user").GetById<UserDTO>(result.UserId));
                txtBox_User.Text = user.FirstName + ' ' + user.LastName;
                txtBox_Date.Text = result.DateReserved.ToString("dd.MM.yyyy");
                txtBox_NumOfPersons.Text = result.NumberOfPersons.ToString();
                txtBox_NumberOfDays.Text = result.NumberOfDays.ToString();
                txtBox_Finished.Text = result.Finished ? "YES" : "NO";
                txtBox_IsCanceled.Text = result.Canceled ? "YES" : "NO";
                txtBox_TripDate.Text = result.StartTripDate.ToString("dd.MM.yyyy");
                txtBox_TotalPrice.Text = string.Format("{0}",result.TotalPrice);
                var textBoxes = DetailPanel.Controls.OfType<TextBox>().ToArray();
                textBoxes.Select(_ => _.ReadOnly = true);
                txtBox_NumberOfDays.ReadOnly = false;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (_id.HasValue)
        //    {
        //        ReservationInsertRequest req = new ReservationInsertRequest();
        //        req.Canceled = txtBox_IsCanceled.Text == "YES" ? true : false;
        //        req.DateReserved = DateTime.Parse(txtBox_Date.Text);
        //        req.StartTripDate = DateTime.Parse(txtBox_TripDate.Text);
        //        req.NumberOfDays =
        //    }
        //}
    }
}
