namespace eTravelAgency.Desktop.Transports.Offer
{
    partial class frmTransportOfferDetails
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
            this.txtbox_Price = new System.Windows.Forms.TextBox();
            this.txtbox_EndDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_StartDate = new System.Windows.Forms.MaskedTextBox();
            this.txtboxPanel = new System.Windows.Forms.Panel();
            this.cmbBox_CityDestination = new System.Windows.Forms.ComboBox();
            this.cmbBox_TransportCompany = new System.Windows.Forms.ComboBox();
            this.txtBox_Active = new System.Windows.Forms.TextBox();
            this.txtbox_Discount = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.offerThum = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mTxtBox_TripDate = new System.Windows.Forms.MaskedTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerThum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_Price
            // 
            this.txtbox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Price.Location = new System.Drawing.Point(35, 77);
            this.txtbox_Price.Name = "txtbox_Price";
            this.txtbox_Price.Size = new System.Drawing.Size(163, 26);
            this.txtbox_Price.TabIndex = 6;
            // 
            // txtbox_EndDate
            // 
            this.txtbox_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_EndDate.Location = new System.Drawing.Point(35, 175);
            this.txtbox_EndDate.Mask = "00/00/0000";
            this.txtbox_EndDate.Name = "txtbox_EndDate";
            this.txtbox_EndDate.Size = new System.Drawing.Size(163, 26);
            this.txtbox_EndDate.TabIndex = 16;
            this.txtbox_EndDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtBox_StartDate
            // 
            this.txtBox_StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_StartDate.Location = new System.Drawing.Point(35, 142);
            this.txtBox_StartDate.Mask = "00/00/0000";
            this.txtBox_StartDate.Name = "txtBox_StartDate";
            this.txtBox_StartDate.Size = new System.Drawing.Size(163, 26);
            this.txtBox_StartDate.TabIndex = 15;
            this.txtBox_StartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtboxPanel
            // 
            this.txtboxPanel.Controls.Add(this.cmbBox_CityDestination);
            this.txtboxPanel.Controls.Add(this.cmbBox_TransportCompany);
            this.txtboxPanel.Controls.Add(this.txtbox_EndDate);
            this.txtboxPanel.Controls.Add(this.txtbox_Price);
            this.txtboxPanel.Controls.Add(this.txtBox_StartDate);
            this.txtboxPanel.Controls.Add(this.txtBox_Active);
            this.txtboxPanel.Controls.Add(this.txtbox_Discount);
            this.txtboxPanel.Location = new System.Drawing.Point(216, 51);
            this.txtboxPanel.Name = "txtboxPanel";
            this.txtboxPanel.Size = new System.Drawing.Size(201, 245);
            this.txtboxPanel.TabIndex = 30;
            // 
            // cmbBox_CityDestination
            // 
            this.cmbBox_CityDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbBox_CityDestination.FormattingEnabled = true;
            this.cmbBox_CityDestination.Location = new System.Drawing.Point(35, 39);
            this.cmbBox_CityDestination.Name = "cmbBox_CityDestination";
            this.cmbBox_CityDestination.Size = new System.Drawing.Size(163, 28);
            this.cmbBox_CityDestination.TabIndex = 18;
            // 
            // cmbBox_TransportCompany
            // 
            this.cmbBox_TransportCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbBox_TransportCompany.FormattingEnabled = true;
            this.cmbBox_TransportCompany.Location = new System.Drawing.Point(35, 5);
            this.cmbBox_TransportCompany.Name = "cmbBox_TransportCompany";
            this.cmbBox_TransportCompany.Size = new System.Drawing.Size(163, 28);
            this.cmbBox_TransportCompany.TabIndex = 17;
            // 
            // txtBox_Active
            // 
            this.txtBox_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Active.Location = new System.Drawing.Point(35, 212);
            this.txtBox_Active.Name = "txtBox_Active";
            this.txtBox_Active.Size = new System.Drawing.Size(163, 26);
            this.txtBox_Active.TabIndex = 7;
            // 
            // txtbox_Discount
            // 
            this.txtbox_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Discount.Location = new System.Drawing.Point(35, 110);
            this.txtbox_Discount.Name = "txtbox_Discount";
            this.txtbox_Discount.Size = new System.Drawing.Size(163, 26);
            this.txtbox_Discount.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(351, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 35);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.ForeColor = System.Drawing.Color.White;
            this.btnSumbit.Location = new System.Drawing.Point(186, 325);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(99, 35);
            this.btnSumbit.TabIndex = 26;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = false;
            this.btnSumbit.Click += new System.EventHandler(this.BtnSumbit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(45, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Active:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(45, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(45, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(45, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Transport Company:";
            // 
            // offerThum
            // 
            this.offerThum.Location = new System.Drawing.Point(525, 56);
            this.offerThum.Name = "offerThum";
            this.offerThum.Size = new System.Drawing.Size(163, 117);
            this.offerThum.TabIndex = 0;
            this.offerThum.TabStop = false;
            this.offerThum.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(459, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Picture:";
            // 
            // mTxtBox_TripDate
            // 
            this.mTxtBox_TripDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mTxtBox_TripDate.Location = new System.Drawing.Point(560, 212);
            this.mTxtBox_TripDate.Mask = "00/00/0000";
            this.mTxtBox_TripDate.Name = "mTxtBox_TripDate";
            this.mTxtBox_TripDate.Size = new System.Drawing.Size(128, 26);
            this.mTxtBox_TripDate.TabIndex = 50;
            this.mTxtBox_TripDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(560, 257);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 35);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Set Trip Date";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_ClickAsync);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(459, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Trip Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(45, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Destination:";
            // 
            // frmTransportOfferDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(742, 402);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mTxtBox_TripDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.offerThum);
            this.Controls.Add(this.txtboxPanel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransportOfferDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransportOfferDetails";
            this.Load += new System.EventHandler(this.FrmTransportOfferDetails_Load);
            this.txtboxPanel.ResumeLayout(false);
            this.txtboxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerThum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_Price;
        private System.Windows.Forms.MaskedTextBox txtbox_EndDate;
        private System.Windows.Forms.MaskedTextBox txtBox_StartDate;
        private System.Windows.Forms.Panel txtboxPanel;
        private System.Windows.Forms.TextBox txtbox_Discount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_TransportCompany;
        private System.Windows.Forms.TextBox txtBox_Active;
        private System.Windows.Forms.PictureBox offerThum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mTxtBox_TripDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBox_CityDestination;
        private System.Windows.Forms.Label label9;
    }
}