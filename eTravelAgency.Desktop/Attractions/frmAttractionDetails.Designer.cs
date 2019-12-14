namespace eTravelAgency.Desktop.Attractions
{
    partial class frmAttractionDetails
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
            this.txtBox_AttrName = new System.Windows.Forms.TextBox();
            this.cmbBox_City = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_AttrDetails = new System.Windows.Forms.TextBox();
            this.picBox_AttractionPicture = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AttractionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(60, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attraction Name:";
            // 
            // txtBox_AttrName
            // 
            this.txtBox_AttrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBox_AttrName.Location = new System.Drawing.Point(292, 66);
            this.txtBox_AttrName.Name = "txtBox_AttrName";
            this.txtBox_AttrName.Size = new System.Drawing.Size(205, 26);
            this.txtBox_AttrName.TabIndex = 1;
            // 
            // cmbBox_City
            // 
            this.cmbBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbBox_City.FormattingEnabled = true;
            this.cmbBox_City.Location = new System.Drawing.Point(291, 22);
            this.cmbBox_City.Name = "cmbBox_City";
            this.cmbBox_City.Size = new System.Drawing.Size(205, 28);
            this.cmbBox_City.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(60, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "City:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(419, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 35);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSumbit
            // 
            this.btnSumbit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSumbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbit.ForeColor = System.Drawing.Color.White;
            this.btnSumbit.Location = new System.Drawing.Point(254, 269);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(99, 35);
            this.btnSumbit.TabIndex = 15;
            this.btnSumbit.Text = "Submit";
            this.btnSumbit.UseVisualStyleBackColor = false;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(60, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Attraction Details:";
            // 
            // txtBox_AttrDetails
            // 
            this.txtBox_AttrDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBox_AttrDetails.Location = new System.Drawing.Point(292, 113);
            this.txtBox_AttrDetails.Multiline = true;
            this.txtBox_AttrDetails.Name = "txtBox_AttrDetails";
            this.txtBox_AttrDetails.Size = new System.Drawing.Size(205, 109);
            this.txtBox_AttrDetails.TabIndex = 19;
            // 
            // picBox_AttractionPicture
            // 
            this.picBox_AttractionPicture.Location = new System.Drawing.Point(561, 69);
            this.picBox_AttractionPicture.Name = "picBox_AttractionPicture";
            this.picBox_AttractionPicture.Size = new System.Drawing.Size(150, 119);
            this.picBox_AttractionPicture.TabIndex = 20;
            this.picBox_AttractionPicture.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(557, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Picture:";
            // 
            // frmAttractionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(935, 340);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBox_AttractionPicture);
            this.Controls.Add(this.txtBox_AttrDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBox_City);
            this.Controls.Add(this.txtBox_AttrName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttractionDetails";
            this.Text = "frmAttractionDetails";
            this.Load += new System.EventHandler(this.FrmAttractionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AttractionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_AttrName;
        private System.Windows.Forms.ComboBox cmbBox_City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_AttrDetails;
        private System.Windows.Forms.PictureBox picBox_AttractionPicture;
        private System.Windows.Forms.Label label4;
    }
}