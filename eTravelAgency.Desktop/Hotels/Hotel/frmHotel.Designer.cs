namespace eTravelAgency.Desktop.Hotels.Hotel
{
    partial class frmHotel
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
            this.txtBox_Hotel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotelGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewHotel
            // 
            this.btnNewHotel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHotel.ForeColor = System.Drawing.Color.White;
            this.btnNewHotel.Location = new System.Drawing.Point(624, 54);
            this.btnNewHotel.Name = "btnNewHotel";
            this.btnNewHotel.Size = new System.Drawing.Size(150, 23);
            this.btnNewHotel.TabIndex = 14;
            this.btnNewHotel.Text = "New Hotel";
            this.btnNewHotel.UseVisualStyleBackColor = false;
            this.btnNewHotel.Click += new System.EventHandler(this.BtnNewHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(89, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search Hotel:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(332, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // txtBox_Hotel
            // 
            this.txtBox_Hotel.Location = new System.Drawing.Point(92, 55);
            this.txtBox_Hotel.Name = "txtBox_Hotel";
            this.txtBox_Hotel.Size = new System.Drawing.Size(174, 20);
            this.txtBox_Hotel.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotelGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(92, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 247);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotels";
            // 
            // hotelGrid
            // 
            this.hotelGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.hotelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.hotelGrid.Location = new System.Drawing.Point(6, 24);
            this.hotelGrid.Name = "hotelGrid";
            this.hotelGrid.Size = new System.Drawing.Size(670, 217);
            this.hotelGrid.TabIndex = 11;
            this.hotelGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.hotelGrid_CellMouseDoubleClick);
            // 
            // frmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.txtBox_Hotel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmHotel";
            this.Load += new System.EventHandler(this.FrmHotel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtBox_Hotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView hotelGrid;
    }
}