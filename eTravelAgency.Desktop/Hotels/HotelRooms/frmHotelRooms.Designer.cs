namespace eTravelAgency.Desktop.Hotels.HotelRooms
{
    partial class frmHotelRooms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotelRoomsGrid = new System.Windows.Forms.DataGridView();
            this.btnNewHotelRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBox_RoomType = new System.Windows.Forms.ComboBox();
            this.cmbBox_Hotel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotelRoomsGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(114, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 253);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Rooms:";
            // 
            // hotelRoomsGrid
            // 
            this.hotelRoomsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.hotelRoomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelRoomsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.hotelRoomsGrid.Location = new System.Drawing.Point(6, 24);
            this.hotelRoomsGrid.Name = "hotelRoomsGrid";
            this.hotelRoomsGrid.Size = new System.Drawing.Size(670, 217);
            this.hotelRoomsGrid.TabIndex = 11;
            // 
            // btnNewHotelRoom
            // 
            this.btnNewHotelRoom.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewHotelRoom.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewHotelRoom.ForeColor = System.Drawing.Color.White;
            this.btnNewHotelRoom.Location = new System.Drawing.Point(640, 384);
            this.btnNewHotelRoom.Name = "btnNewHotelRoom";
            this.btnNewHotelRoom.Size = new System.Drawing.Size(150, 23);
            this.btnNewHotelRoom.TabIndex = 19;
            this.btnNewHotelRoom.Text = "New Hotel Room";
            this.btnNewHotelRoom.UseVisualStyleBackColor = false;
            this.btnNewHotelRoom.Click += new System.EventHandler(this.btnNewHotelRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(117, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hotel:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(698, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(416, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Room Type:";
            // 
            // cmbBox_RoomType
            // 
            this.cmbBox_RoomType.FormattingEnabled = true;
            this.cmbBox_RoomType.Location = new System.Drawing.Point(509, 82);
            this.cmbBox_RoomType.Name = "cmbBox_RoomType";
            this.cmbBox_RoomType.Size = new System.Drawing.Size(154, 22);
            this.cmbBox_RoomType.TabIndex = 23;
            // 
            // cmbBox_Hotel
            // 
            this.cmbBox_Hotel.FormattingEnabled = true;
            this.cmbBox_Hotel.Location = new System.Drawing.Point(176, 82);
            this.cmbBox_Hotel.Name = "cmbBox_Hotel";
            this.cmbBox_Hotel.Size = new System.Drawing.Size(154, 22);
            this.cmbBox_Hotel.TabIndex = 24;
            // 
            // frmHotelRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 437);
            this.Controls.Add(this.cmbBox_Hotel);
            this.Controls.Add(this.cmbBox_RoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewHotelRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHotelRooms";
            this.Text = "frmHotelRooms";
            this.Load += new System.EventHandler(this.frmHotelRooms_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelRoomsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView hotelRoomsGrid;
        private System.Windows.Forms.Button btnNewHotelRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBox_RoomType;
        private System.Windows.Forms.ComboBox cmbBox_Hotel;
    }
}