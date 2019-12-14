using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Hotels.HotelRooms
{
    public partial class frmHotelRoomsDetail : Form
    {
        private readonly APIService _hRoomService = new APIService("hotelrooms");
        private int? _hotelId = null;
        private int? _roomId = null;
        public frmHotelRoomsDetail(BindingSource src =null,int? hotelid =null,int? roomId=null)
        {
            InitializeComponent();
            _hotelId = hotelid;
            _roomId = roomId;
            cmbBox_RoomTypes.DataSource = src;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBox_RoomNumber.Text = string.Empty;
            txtBox_Price.Text = string.Empty;
            mTxtBox_Active.Text = string.Empty;

        }

        private async  void btnSumbit_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtBox_Price.Text) ||
                                  string.IsNullOrEmpty(txtBox_RoomNumber.Text) ||
                                  string.IsNullOrEmpty(mTxtBox_Active.Text))) return;
            var insertRequest = new HotelRoomsInsertRequest()
            {
                Active = mTxtBox_Active.Text == "YES" ? true : false,
                NumberOfRooms = int.Parse(txtBox_RoomNumber.Text),
                Price = float.Parse(txtBox_Price.Text),
                HotelId = _hotelId.Value,
                RoomTypeId = _roomId.Value
            };
            if (_hotelId.HasValue && _roomId.HasValue)
            {

                await _hRoomService.Update<HotelRoomsInsertRequest>(new { hotelId = _hotelId.Value,
                                                                          roomId = _roomId.Value},insertRequest);
            }
            else
            {
                await _hRoomService.Insert<HotelRoomsInsertRequest>(insertRequest);
            }

        }

        private void frmHotelRoomsDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
