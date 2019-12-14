namespace eTravelAgency.Desktop.Cities
{
    partial class frmCityDetails
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
            this.txtBox_CityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.cmbBox_Country = new System.Windows.Forms.ComboBox();
            this.txtBox_ZipCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBox_Picture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(230, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City Name:";
            // 
            // txtBox_CityName
            // 
            this.txtBox_CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBox_CityName.Location = new System.Drawing.Point(505, 120);
            this.txtBox_CityName.Name = "txtBox_CityName";
            this.txtBox_CityName.Size = new System.Drawing.Size(161, 26);
            this.txtBox_CityName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(230, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country Name:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(505, 278);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 35);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.ForeColor = System.Drawing.Color.White;
            this.btnSumbit.Location = new System.Drawing.Point(340, 278);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(99, 35);
            this.btnSumbit.TabIndex = 15;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = false;
            this.btnSumbit.Click += new System.EventHandler(this.BtnSumbit_Click);
            // 
            // cmbBox_Country
            // 
            this.cmbBox_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbBox_Country.FormattingEnabled = true;
            this.cmbBox_Country.Location = new System.Drawing.Point(505, 209);
            this.cmbBox_Country.Name = "cmbBox_Country";
            this.cmbBox_Country.Size = new System.Drawing.Size(161, 28);
            this.cmbBox_Country.TabIndex = 18;
            // 
            // txtBox_ZipCode
            // 
            this.txtBox_ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBox_ZipCode.Location = new System.Drawing.Point(505, 164);
            this.txtBox_ZipCode.Name = "txtBox_ZipCode";
            this.txtBox_ZipCode.Size = new System.Drawing.Size(161, 26);
            this.txtBox_ZipCode.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(230, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Zip Code:";
            // 
            // picBox_Picture
            // 
            this.picBox_Picture.BackColor = System.Drawing.Color.White;
            this.picBox_Picture.Location = new System.Drawing.Point(504, 28);
            this.picBox_Picture.Name = "picBox_Picture";
            this.picBox_Picture.Size = new System.Drawing.Size(162, 75);
            this.picBox_Picture.TabIndex = 21;
            this.picBox_Picture.TabStop = false;
            this.picBox_Picture.Click += new System.EventHandler(this.picBox_Picture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(230, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Picture:";
            // 
            // frmCityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_Picture);
            this.Controls.Add(this.txtBox_ZipCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBox_Country);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_CityName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCityDetails";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmCityDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_CityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.ComboBox cmbBox_Country;
        private System.Windows.Forms.TextBox txtBox_ZipCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBox_Picture;
        private System.Windows.Forms.Label label4;
    }
}