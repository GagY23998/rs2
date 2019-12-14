using eTravelAgency.Desktop.Attractions;
using eTravelAgency.Desktop.Cities;
using eTravelAgency.Desktop.Countries;
using eTravelAgency.Desktop.Hotels;
using eTravelAgency.Desktop.Reservations;
using eTravelAgency.Desktop.Reviews;
using eTravelAgency.Desktop.Transports;
using eTravelAgency.Desktop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTravelAgency.Desktop
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            frmUsers.MdiParent = this;
            frmUsers.WindowState = FormWindowState.Maximized;
            frmUsers.Show();
        }

        private void NewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frmUserDetails = new frmUserDetails();
            frmUserDetails.MdiParent = this;
            frmUserDetails.WindowState = FormWindowState.Maximized;
            frmUserDetails.Show();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            frmUsersMenu usersMenu = new frmUsersMenu();
            usersMenu.TopLevel = false;
            usersMenu.AutoScroll = false;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(usersMenu);
            usersMenu.Show();
        }

        private void Transports_Click(object sender, EventArgs e)
        {
            frmTransportMainMenu frmTransportMainMenu = new frmTransportMainMenu();
            frmTransportMainMenu.TopLevel = false;
            frmTransportMainMenu.AutoScroll = false;
            frmTransportMainMenu.WindowState = FormWindowState.Maximized;
            frmTransportMainMenu.StartPosition = FormStartPosition.CenterParent;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(frmTransportMainMenu);
            frmTransportMainMenu.Show();
        }

        private void Hotels_Click(object sender, EventArgs e)
        {
            frmHotelMainMenu menu = new frmHotelMainMenu();
            menu.AutoScroll = false;
            menu.WindowState = FormWindowState.Maximized;
            menu.StartPosition = FormStartPosition.CenterParent;
            menu.TopLevel = false;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(menu);
            menu.Show();
        }

        private void Btn_Cities_Click(object sender, EventArgs e)
        {
            frmCities frm = new frmCities();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(frm);
            frm.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            frmCountry frm = new frmCountry();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(frm);
            frm.Show();

        }

        private void Attractions_Click(object sender, EventArgs e)
        {
            frmAttraction frm = new frmAttraction();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(frm);
            frm.Show();
        }

        private void Reservations_Click(object sender, EventArgs e)
        {
            frmReservations frm = new frmReservations();
            frm.TopLevel = false;
            frm.AutoScroll = false;
            frm.WindowState = FormWindowState.Maximized;
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(frm);
            frm.Show();
        }

        private void Reviews_Click(object sender, EventArgs e)
        {
            frmReviews frm = new frmReviews()
            {
                TopLevel = false,
                AutoScroll = false,
                WindowState = FormWindowState.Maximized
            };
            FormPanel.Controls.Clear();
            FormPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
