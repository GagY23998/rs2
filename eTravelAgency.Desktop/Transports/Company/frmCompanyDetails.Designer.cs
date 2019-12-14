namespace eTravelAgency.Desktop.Transports.Company
{
    partial class frmCompanyDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_CompanyName = new System.Windows.Forms.TextBox();
            this.txtBox_Active = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbbox_TransportType = new System.Windows.Forms.ComboBox();
            this.txtboxPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_Picture = new System.Windows.Forms.PictureBox();
            this.txtboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(89, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport Company:";
            // 
            // txtbox_CompanyName
            // 
            this.txtbox_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_CompanyName.Location = new System.Drawing.Point(37, 55);
            this.txtbox_CompanyName.Name = "txtbox_CompanyName";
            this.txtbox_CompanyName.Size = new System.Drawing.Size(163, 26);
            this.txtbox_CompanyName.TabIndex = 5;
            // 
            // txtBox_Active
            // 
            this.txtBox_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Active.Location = new System.Drawing.Point(37, 88);
            this.txtBox_Active.Name = "txtBox_Active";
            this.txtBox_Active.Size = new System.Drawing.Size(163, 26);
            this.txtBox_Active.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(89, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Active:";
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.ForeColor = System.Drawing.Color.White;
            this.btnSumbit.Location = new System.Drawing.Point(197, 259);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(99, 35);
            this.btnSumbit.TabIndex = 12;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = false;
            this.btnSumbit.Click += new System.EventHandler(this.BtnSumbit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(362, 259);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 35);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(89, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Transport type:";
            // 
            // cmbbox_TransportType
            // 
            this.cmbbox_TransportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbbox_TransportType.FormattingEnabled = true;
            this.cmbbox_TransportType.Location = new System.Drawing.Point(37, 21);
            this.cmbbox_TransportType.Name = "cmbbox_TransportType";
            this.cmbbox_TransportType.Size = new System.Drawing.Size(163, 28);
            this.cmbbox_TransportType.TabIndex = 18;
            // 
            // txtboxPanel
            // 
            this.txtboxPanel.Controls.Add(this.cmbbox_TransportType);
            this.txtboxPanel.Controls.Add(this.txtbox_CompanyName);
            this.txtboxPanel.Controls.Add(this.txtBox_Active);
            this.txtboxPanel.Location = new System.Drawing.Point(325, 93);
            this.txtboxPanel.Name = "txtboxPanel";
            this.txtboxPanel.Size = new System.Drawing.Size(209, 140);
            this.txtboxPanel.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Picture:";
            // 
            // picBox_Picture
            // 
            this.picBox_Picture.Location = new System.Drawing.Point(362, 9);
            this.picBox_Picture.Name = "picBox_Picture";
            this.picBox_Picture.Size = new System.Drawing.Size(163, 78);
            this.picBox_Picture.TabIndex = 21;
            this.picBox_Picture.TabStop = false;
            this.picBox_Picture.Click += new System.EventHandler(this.picBox_Picture_Click);
            // 
            // frmCompanyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(628, 319);
            this.Controls.Add(this.picBox_Picture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCompanyDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCompanyDetails_Load);
            this.txtboxPanel.ResumeLayout(false);
            this.txtboxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_CompanyName;
        private System.Windows.Forms.TextBox txtBox_Active;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbbox_TransportType;
        private System.Windows.Forms.Panel txtboxPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_Picture;
    }
}