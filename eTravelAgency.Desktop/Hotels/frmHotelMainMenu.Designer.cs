namespace eTravelAgency.Desktop.Hotels
{
    partial class frmHotelMainMenu
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Hotel = new System.Windows.Forms.Button();
            this.btn_HotelOffer = new System.Windows.Forms.Button();
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Back.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Location = new System.Drawing.Point(662, 397);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(121, 43);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Hotel
            // 
            this.btn_Hotel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Hotel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hotel.ForeColor = System.Drawing.Color.White;
            this.btn_Hotel.Location = new System.Drawing.Point(121, 397);
            this.btn_Hotel.Name = "btn_Hotel";
            this.btn_Hotel.Size = new System.Drawing.Size(121, 43);
            this.btn_Hotel.TabIndex = 6;
            this.btn_Hotel.Text = "Hotels";
            this.btn_Hotel.UseVisualStyleBackColor = false;
            this.btn_Hotel.Click += new System.EventHandler(this.Btn_Hotel_Click);
            // 
            // btn_HotelOffer
            // 
            this.btn_HotelOffer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_HotelOffer.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HotelOffer.ForeColor = System.Drawing.Color.White;
            this.btn_HotelOffer.Location = new System.Drawing.Point(295, 397);
            this.btn_HotelOffer.Name = "btn_HotelOffer";
            this.btn_HotelOffer.Size = new System.Drawing.Size(144, 43);
            this.btn_HotelOffer.TabIndex = 7;
            this.btn_HotelOffer.Text = "Hotel Offers";
            this.btn_HotelOffer.UseVisualStyleBackColor = false;
            this.btn_HotelOffer.Click += new System.EventHandler(this.Btn_HotelOffer_Click);
            // 
            // HotelPanel
            // 
            this.HotelPanel.Location = new System.Drawing.Point(1, -1);
            this.HotelPanel.Name = "HotelPanel";
            this.HotelPanel.Size = new System.Drawing.Size(933, 342);
            this.HotelPanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(471, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hotel Rooms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHotelMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HotelPanel);
            this.Controls.Add(this.btn_HotelOffer);
            this.Controls.Add(this.btn_Hotel);
            this.Controls.Add(this.btn_Back);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHotelMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHotelMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Hotel;
        private System.Windows.Forms.Button btn_HotelOffer;
        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Button button1;
    }
}