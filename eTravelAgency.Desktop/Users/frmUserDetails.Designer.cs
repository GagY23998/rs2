namespace eTravelAgency.Desktop.Users
{
    partial class frmUserDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.submitUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resetUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBox_FirstName = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_UserName = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_LastName = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_Email = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_Password = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_PasswordConfirmation = new System.Windows.Forms.MaskedTextBox();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox_Role = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // submitUser
            // 
            this.submitUser.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.submitUser.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.submitUser.Location = new System.Drawing.Point(219, 265);
            this.submitUser.Name = "submitUser";
            this.submitUser.Size = new System.Drawing.Size(125, 32);
            this.submitUser.TabIndex = 0;
            this.submitUser.Text = "Submit";
            this.submitUser.UseVisualStyleBackColor = false;
            this.submitUser.Click += new System.EventHandler(this.SubmitUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(88, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // resetUser
            // 
            this.resetUser.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.resetUser.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetUser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.resetUser.Location = new System.Drawing.Point(422, 265);
            this.resetUser.Name = "resetUser";
            this.resetUser.Size = new System.Drawing.Size(125, 32);
            this.resetUser.TabIndex = 3;
            this.resetUser.Text = "Reset";
            this.resetUser.UseVisualStyleBackColor = false;
            this.resetUser.Click += new System.EventHandler(this.ResetUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(88, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(88, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(88, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(490, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "User Photo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(88, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(88, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(88, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Confirmation:";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(171, 38);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(145, 20);
            this.txtBox_FirstName.TabIndex = 1;
            this.txtBox_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_FirstName_Validating);
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Location = new System.Drawing.Point(171, 94);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(145, 20);
            this.txtBox_UserName.TabIndex = 4;
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Location = new System.Drawing.Point(171, 67);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(145, 20);
            this.txtBox_LastName.TabIndex = 6;
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(171, 124);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(145, 20);
            this.txtBox_Email.TabIndex = 8;
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Location = new System.Drawing.Point(171, 152);
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(145, 20);
            this.txtBox_Phone.TabIndex = 12;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(171, 178);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(145, 20);
            this.txtBox_Password.TabIndex = 14;
            // 
            // txtBox_PasswordConfirmation
            // 
            this.txtBox_PasswordConfirmation.Location = new System.Drawing.Point(171, 204);
            this.txtBox_PasswordConfirmation.Name = "txtBox_PasswordConfirmation";
            this.txtBox_PasswordConfirmation.Size = new System.Drawing.Size(145, 20);
            this.txtBox_PasswordConfirmation.TabIndex = 16;
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.White;
            this.userPicture.Location = new System.Drawing.Point(493, 41);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(153, 131);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPicture.TabIndex = 18;
            this.userPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(493, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Change picture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(361, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Roles:";
            // 
            // listBox_Role
            // 
            this.listBox_Role.FormattingEnabled = true;
            this.listBox_Role.Location = new System.Drawing.Point(364, 67);
            this.listBox_Role.Name = "listBox_Role";
            this.listBox_Role.Size = new System.Drawing.Size(83, 94);
            this.listBox_Role.TabIndex = 21;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.listBox_Role);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBox_PasswordConfirmation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_UserName);
            this.Controls.Add(this.resetUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_FirstName);
            this.Controls.Add(this.submitUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.FrmUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.MaskedTextBox txtBox_PasswordConfirmation;
        private System.Windows.Forms.MaskedTextBox txtBox_Password;
        private System.Windows.Forms.MaskedTextBox txtBox_Phone;
        private System.Windows.Forms.MaskedTextBox txtBox_Email;
        private System.Windows.Forms.MaskedTextBox txtBox_LastName;
        private System.Windows.Forms.MaskedTextBox txtBox_UserName;
        private System.Windows.Forms.MaskedTextBox txtBox_FirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.CheckedListBox listBox_Role;
        private System.Windows.Forms.Label label9;
    }
}