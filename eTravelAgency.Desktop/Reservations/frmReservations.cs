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
    public partial class frmReservations : Form
    {
        private readonly APIService _service = new APIService("reservation");
        public frmReservations()
        {
            InitializeComponent();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            //var textBoxes = filterPanel.Controls.OfType<TextBox>().ToArray();
            //if (!textBoxes.Any(_ => string.IsNullOrEmpty(_.Text)) || string.IsNullOrEmpty(mtxtBox_FromDate.Text)) return;

            var request = new ReservationSearchRequest();

            request.FromDate = (mtxtBox_FromDate.Text != "  -  -") ? DateTime.Parse(mtxtBox_FromDate.Text) : DateTime.MinValue;
            request.ToDate = (mTxtBox_ToDate.Text != "  -  -") ? DateTime.Parse(mTxtBox_ToDate.Text) : DateTime.MinValue;
            //request.DateReserved = (mtxtBox_FromDate.Text != "  -  -") ? DateTime.Parse(mtxtBox_FromDate.Text) : DateTime.MinValue;
            request.Canceled = txtBox_Canceled.Text == "YES" ? true : false;
            request.FromDays = !string.IsNullOrEmpty(txtBox_FromDays.Text) ? int.Parse(txtBox_FromDays.Text) : 0;
            request.ToDays = !string.IsNullOrEmpty(txtBox_ToDays.Text) ? int.Parse(txtBox_ToDays.Text) : 0;
            request.FromPersons = !string.IsNullOrEmpty(txtBox_FromPersons.Text) ? int.Parse(txtBox_FromPersons.Text) : 0;
            request.ToPersons = !string.IsNullOrEmpty(txtBox_ToPersons.Text) ? int.Parse(txtBox_ToPersons.Text) : 0;
            request.FromPrice = !string.IsNullOrEmpty(txtBox_FromPrice.Text) ? float.Parse(txtBox_FromPrice.Text) : 0;
            request.ToPrice = !string.IsNullOrEmpty(txtBox_ToPrice.Text) ? float.Parse(txtBox_ToPrice.Text) : 0;
            
            
            var result = await _service.Get<List<ReservationDTO>>(request);
            
            
            BindingSource source = new BindingSource(result, null);
            reservationGrid.DataSource = source;
            reservationGrid.Columns[0].Visible = false;
            reservationGrid.Columns[1].Visible = false;
            reservationGrid.Columns[2].Visible = false;
            reservationGrid.Columns[3].Visible = false;
        }

        private void reservationGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = (int)reservationGrid.SelectedRows[0].Cells[0].Value;
            frmReservationDetails frm = new frmReservationDetails(id);
            frm.TopLevel = false;
            frm.AutoScroll = false;
            frm.WindowState = FormWindowState.Maximized;
            this.Controls.Clear();
            this.Controls.Add(frm);
            frm.Show();
        }
    }
}
