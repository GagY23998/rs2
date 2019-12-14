using eTravelAgency.Desktop.Hotels.Hotel;
using eTravelAgency.Desktop.Hotels.HotelRooms;
using eTravelAgency.Desktop.Hotels.Offer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Hotels
{
    public partial class frmHotelMainMenu : Form
    {
        public frmHotelMainMenu()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private void Btn_Hotel_Click(object sender, EventArgs e)
        {
            frmHotel hotel = new frmHotel();
            hotel.AutoScroll = false;
            hotel.TopLevel = false;
            hotel.WindowState = FormWindowState.Normal;
            hotel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hotel.Size = new Size { Height = HotelPanel.Height, Width = HotelPanel.Width };
            HotelPanel.Controls.Clear();
            HotelPanel.Controls.Add(hotel);
            
            hotel.Show();
        }

        private void Btn_HotelOffer_Click(object sender, EventArgs e)
        {
            frmHotelOffer offer = new frmHotelOffer();
            offer.WindowState = FormWindowState.Maximized;
            offer.AutoScroll = false;
            offer.TopLevel = false;
            HotelPanel.Controls.Clear();
            HotelPanel.Controls.Add(offer);
            offer.Show();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHotelRooms frm = new frmHotelRooms()
            {
                AutoScroll = false,
                TopLevel = false,
                WindowState = FormWindowState.Maximized
            };
            HotelPanel.Controls.Clear();
            HotelPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
