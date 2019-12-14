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
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("user");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtBox_Username.Text;
                APIService.Password = txtBox_Password.Text;
                await _service.Get<dynamic>(null);
                frmIndex frm = new frmIndex();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
