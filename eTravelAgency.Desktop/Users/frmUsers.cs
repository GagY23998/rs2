using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.Desktop.Users;
using System.IO;
using System.Drawing.Imaging;

namespace eTravelAgency.Desktop
{
    public partial class frmUsers : Form
    {
        private readonly APIService _apiService = new APIService("user");
        public frmUsers()
        {
            InitializeComponent();
        }

        private void DgvUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUsers.SelectedRows[0].Cells[0].Value;
            frmUserDetails userDetails = new frmUserDetails(int.Parse(id.ToString()));
            userDetails.WindowState = FormWindowState.Maximized;
            userDetails.FormBorderStyle = FormBorderStyle.None;
            userDetails.TopLevel = false;
            var parentOfThisOne =this.Parent.Controls;
            parentOfThisOne.Add(userDetails);
            parentOfThisOne.SetChildIndex(userDetails, 1);
            userDetails.Show();
            this.Hide();

        }


        private async void Btn_SearchUser_Click(object sender, EventArgs e)
        {
            UserSearchRequest search = null;
            if (txtBox_SearchUser.Text.Contains(" "))
                {

                string[] list = txtBox_SearchUser.Text.Trim().Split(' ');
                search = new UserSearchRequest
                    {
                        FirstName = list[0],
                        LastName = list.Length>1?list[1]:null
                    };
                }
            else {
                search = new UserSearchRequest
                    {
                        FirstName = txtBox_SearchUser.Text
                    };
            }
           var results = await _apiService.Get<List<UserDTO>>(search);

           
            foreach (var result in results)
            {
                Image image = null;
                Image thumbnail = null;
                if(result.Picture.Count() !=0)
                {
                    using (var stream = new MemoryStream(result.Picture))
                    {
                        image = Image.FromStream(stream);
                        thumbnail = image.GetThumbnailImage(64,64, null, IntPtr.Zero);
                    }
                    using (var stream = new MemoryStream())
                    {
                        thumbnail.Save(stream, ImageFormat.Bmp);
                        result.Picture = stream.ToArray();
                    }

                }
            }

           BindingSource source = new BindingSource(results,null);
            dgvUsers.DataSource = source;
            dgvUsers.Columns[0].Visible = false;
           
         }
          
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
