using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop.Users
{
    public partial class frmUsersMenu : Form
    {
        public frmUsersMenu()
        {
            InitializeComponent();
        }

        private void Panel1_Enter(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.TopLevel = false;
            frmUsers.AutoScroll = false;
            frmUsers.Height = UsersPanel.Height;
            frmUsers.Width = UsersPanel.Width;
            UsersPanel.Controls.Clear();
            UsersPanel.Controls.Add(frmUsers);
            frmUsers.Show();
            UsersPanel.Controls.SetChildIndex(frmUsers, 1);
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails();
            frmUserDetails.TopLevel = false;
            frmUserDetails.AutoScroll = false;
            frmUserDetails.FormBorderStyle = FormBorderStyle.None;
            frmUserDetails.WindowState = FormWindowState.Maximized;
            UsersPanel.Controls.Clear();
            UsersPanel.Controls.Add(frmUserDetails);
            UsersPanel.Controls.SetChildIndex(frmUserDetails, 1);
            frmUserDetails.Show();
        }
    }
}
