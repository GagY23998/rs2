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

namespace eTravelAgency.Desktop.Users
{
    public partial class frmUserDetails : Form
    {
        private int? _id=null;
        private readonly APIService _service = new APIService("user");
        private readonly APIService _roleService = new APIService("role");
        public frmUserDetails(int? userId = null)
        {
            _id = userId;
            InitializeComponent();
            
        }

        private async void FrmUserDetails_Load(object sender, EventArgs e)
        {
            var roles = await _roleService.Get<List<RoleDTO>>(null);
            listBox_Role.DataSource = new BindingSource(roles,null);
            listBox_Role.DisplayMember = "Name";
            if (_id.HasValue)
            {
                var myObject = await _service.GetById<UserDTO>(_id);
                txtBox_FirstName.Text = myObject.FirstName;
                txtBox_LastName.Text= myObject.LastName;
                txtBox_Phone.Text= myObject.Phone;
                txtBox_Email.Text= myObject.Email;
                txtBox_UserName.Text = myObject.UserName;
                if (myObject.Picture.Count() != 0)
                {
                    using (MemoryStream stream = new MemoryStream(myObject.Picture))
                    {
                        var image = new Bitmap(Image.FromStream(stream),userPicture.Width,userPicture.Height);
                        userPicture.Image = image;
                    }
                }
                else
                {
                    userPicture.Image = null;
                }
            }
        }

        private async void SubmitUser_Click(object sender, EventArgs e)
        {
            if(string.Compare(txtBox_Password.Text,txtBox_PasswordConfirmation.Text)!=0)
            {
                return;
            }
            UserInsertRequest request = null;
            using (MemoryStream stream = new MemoryStream())
            {
                if (userPicture.Image != null)
                {
                    userPicture.Image.Save(stream, ImageFormat.Png);
                }
                var roles = listBox_Role.CheckedItems.Cast<RoleDTO>().Select(_=>_.Id).ToList();
                request = new UserInsertRequest
                {
                    FirstName = txtBox_FirstName.Text,
                    LastName = txtBox_LastName.Text,
                    Email = txtBox_Email.Text,
                    UserName = txtBox_UserName.Text,
                    Phone = txtBox_Phone.Text,
                    Password = txtBox_Password.Text??null,
                    PasswordConfirmation = txtBox_PasswordConfirmation.Text,
                    Picture = stream.ToArray(),
                    Roles = roles
                };
            }
            UserDTO res = null;
            if (_id.HasValue)
            {
               res= await _service.Update<UserDTO>(_id.Value, request);
                  
            }
            else
            {
               res= await _service.Insert<UserDTO>(request);                
            }
            if (res != null)
            {
                if(res.Id == _id.Value)
                {
                    APIService.Username = res.UserName;
                    APIService.Password = txtBox_Password.Text;
                }
            }
            string msg = res != null ? "Successufully handled request" : "Error occured during request handling";
            MessageBox.Show(msg, "OK");

        }

        private void TxtBox_FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_FirstName.Text))
            {
                error1.SetError(txtBox_FirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error1.SetError(txtBox_FirstName, null);
            }
        }

        private void ResetUser_Click(object sender, EventArgs e)
        {
            txtBox_Email.Text = string.Empty;
            txtBox_FirstName.Text = string.Empty;
            txtBox_LastName.Text = string.Empty;
            txtBox_Password.Text = string.Empty;
            txtBox_PasswordConfirmation.Text = string.Empty;
            txtBox_UserName.Text = string.Empty;
            txtBox_Phone.Text = string.Empty;
            userPicture.Image = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
            if(openFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string location = "";
                location = openFileDialog.FileName;
                userPicture.ImageLocation = location;
            }
        }
    }
}
