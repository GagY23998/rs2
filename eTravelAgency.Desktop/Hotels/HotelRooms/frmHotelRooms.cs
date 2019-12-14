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

namespace eTravelAgency.Desktop.Hotels.HotelRooms
{
    public partial class frmHotelRooms : Form
    {
        private readonly APIService _hService = new APIService("hotel");
        private readonly APIService _hRoomsService = new APIService("hotelrooms");
        private readonly APIService _rTypeService = new APIService("roomtype");

        public frmHotelRooms()
        {
            InitializeComponent();
        }

        private async void frmHotelRooms_Load(object sender, EventArgs e)
        {

            var rTypeData = await _rTypeService.Get<List<RoomTypeDTO>>(null);

            rTypeData.Insert(0, new RoomTypeDTO());

            cmbBox_RoomType.DataSource = new BindingSource(rTypeData, null);
            cmbBox_RoomType.DisplayMember = "RoomTypeName";
            cmbBox_RoomType.ValueMember = "Id";


            var hData = await _hService.Get <List<HotelDTO>>(null);

            hData.Insert(0, new HotelDTO());

            cmbBox_Hotel.DataSource = new BindingSource(hData, null);
            cmbBox_Hotel.DisplayMember = "HotelName";
            cmbBox_Hotel.ValueMember = "Id";

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if ((int)cmbBox_Hotel.SelectedValue != 0 || (int)cmbBox_RoomType.SelectedValue != 0)
            {
                var searchRequest = new HotelRoomsSearchRequest()
                {
                    HotelId = (int)cmbBox_Hotel.SelectedValue,
                    RoomTypeId = (int)cmbBox_RoomType.SelectedValue
                };

                var data = await _hRoomsService.Get<List<HotelRoomsDTO>>(searchRequest);

                hotelRoomsGrid.DataSource = new BindingSource(data, null);
                hotelRoomsGrid.Columns[0].Visible = false;
                hotelRoomsGrid.Columns[1].Visible = false;
            }
        }

        private void btnNewHotelRoom_Click(object sender, EventArgs e)
        {
            frmHotelRoomsDetail frm = new frmHotelRoomsDetail(cmbBox_RoomType.DataSource as BindingSource);
            this.Parent.Controls.Add(frm);
            frm.Show();
        }
    }
}
