namespace eTravelAgency.Desktop.Hotels.Offer
{
    partial class frmHotelOffer
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
            this.btnNewHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.offerGrid = new System.Windows.Forms.DataGridView();
            this.cmbBox_HotelNames = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewHotel
            // 
            this.btnNewHotel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHotel.ForeColor = System.Drawing.Color.White;
            this.btnNewHotel.Location = new System.Drawing.Point(611, 50);
            this.btnNewHotel.Name = "btnNewHotel";
            this.btnNewHotel.Size = new System.Drawing.Size(150, 23);
            this.btnNewHotel.TabIndex = 19;
            this.btnNewHotel.Text = "New Offer";
            this.btnNewHotel.UseVisualStyleBackColor = false;
            this.btnNewHotel.Click += new System.EventHandler(this.BtnNewHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Offer:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(319, 50);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.offerGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(79, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 252);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offers";
            // 
            // offerGrid
            // 
            this.offerGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.offerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offerGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.offerGrid.Location = new System.Drawing.Point(6, 25);
            this.offerGrid.Name = "offerGrid";
            this.offerGrid.Size = new System.Drawing.Size(670, 221);
            this.offerGrid.TabIndex = 16;
            this.offerGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OfferGrid_CellMouseDoubleClick);
            // 
            // cmbBox_HotelNames
            // 
            this.cmbBox_HotelNames.FormattingEnabled = true;
            this.cmbBox_HotelNames.Location = new System.Drawing.Point(85, 50);
            this.cmbBox_HotelNames.Name = "cmbBox_HotelNames";
            this.cmbBox_HotelNames.Size = new System.Drawing.Size(184, 21);
            this.cmbBox_HotelNames.TabIndex = 21;
            // 
            // frmHotelOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 342);
            this.Controls.Add(this.cmbBox_HotelNames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHotelOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHotelOffer";
            this.Load += new System.EventHandler(this.frmHotelOffer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.offerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView offerGrid;
        private System.Windows.Forms.ComboBox cmbBox_HotelNames;
    }
}