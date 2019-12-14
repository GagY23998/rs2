namespace eTravelAgency.Desktop.Reservations
{
    partial class frmReservations
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
            this.reservationGrid = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.mtxtBox_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_ToPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_FromPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Canceled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_FromPersons = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mTxtBox_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_ToPersons = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_ToDays = new System.Windows.Forms.TextBox();
            this.txtBox_FromDays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGrid)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reservationGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 308);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservations";
            // 
            // reservationGrid
            // 
            this.reservationGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reservationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.reservationGrid.Location = new System.Drawing.Point(16, 19);
            this.reservationGrid.Name = "reservationGrid";
            this.reservationGrid.Size = new System.Drawing.Size(730, 283);
            this.reservationGrid.TabIndex = 5;
            this.reservationGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reservationGrid_CellMouseDoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(672, 55);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number Of Persons:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(9, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Reservation Date:";
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.label8);
            this.filterPanel.Controls.Add(this.txtBox_ToDays);
            this.filterPanel.Controls.Add(this.txtBox_FromDays);
            this.filterPanel.Controls.Add(this.label7);
            this.filterPanel.Controls.Add(this.txtBox_ToPersons);
            this.filterPanel.Controls.Add(this.mTxtBox_ToDate);
            this.filterPanel.Controls.Add(this.label6);
            this.filterPanel.Controls.Add(this.mtxtBox_FromDate);
            this.filterPanel.Controls.Add(this.txtBox_ToPrice);
            this.filterPanel.Controls.Add(this.label3);
            this.filterPanel.Controls.Add(this.txtBox_FromPrice);
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Controls.Add(this.txtBox_Canceled);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.txtBox_FromPersons);
            this.filterPanel.Location = new System.Drawing.Point(108, 12);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(558, 112);
            this.filterPanel.TabIndex = 26;
            // 
            // mtxtBox_FromDate
            // 
            this.mtxtBox_FromDate.Location = new System.Drawing.Point(12, 15);
            this.mtxtBox_FromDate.Mask = "00/00/0000";
            this.mtxtBox_FromDate.Name = "mtxtBox_FromDate";
            this.mtxtBox_FromDate.Size = new System.Drawing.Size(112, 20);
            this.mtxtBox_FromDate.TabIndex = 33;
            this.mtxtBox_FromDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtBox_ToPrice
            // 
            this.txtBox_ToPrice.Location = new System.Drawing.Point(495, 43);
            this.txtBox_ToPrice.Name = "txtBox_ToPrice";
            this.txtBox_ToPrice.Size = new System.Drawing.Size(41, 20);
            this.txtBox_ToPrice.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(471, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "To";
            // 
            // txtBox_FromPrice
            // 
            this.txtBox_FromPrice.Location = new System.Drawing.Point(424, 43);
            this.txtBox_FromPrice.Name = "txtBox_FromPrice";
            this.txtBox_FromPrice.Size = new System.Drawing.Size(41, 20);
            this.txtBox_FromPrice.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(286, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Price:";
            // 
            // txtBox_Canceled
            // 
            this.txtBox_Canceled.Location = new System.Drawing.Point(424, 18);
            this.txtBox_Canceled.Name = "txtBox_Canceled";
            this.txtBox_Canceled.Size = new System.Drawing.Size(112, 20);
            this.txtBox_Canceled.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(286, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Canceled Reservation:";
            // 
            // txtBox_FromPersons
            // 
            this.txtBox_FromPersons.Location = new System.Drawing.Point(12, 46);
            this.txtBox_FromPersons.Name = "txtBox_FromPersons";
            this.txtBox_FromPersons.Size = new System.Drawing.Size(112, 20);
            this.txtBox_FromPersons.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(374, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 27;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(130, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "To:";
            // 
            // mTxtBox_ToDate
            // 
            this.mTxtBox_ToDate.Location = new System.Drawing.Point(159, 15);
            this.mTxtBox_ToDate.Mask = "00/00/0000";
            this.mTxtBox_ToDate.Name = "mTxtBox_ToDate";
            this.mTxtBox_ToDate.Size = new System.Drawing.Size(112, 20);
            this.mTxtBox_ToDate.TabIndex = 34;
            this.mTxtBox_ToDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtBox_ToPersons
            // 
            this.txtBox_ToPersons.Location = new System.Drawing.Point(159, 46);
            this.txtBox_ToPersons.Name = "txtBox_ToPersons";
            this.txtBox_ToPersons.Size = new System.Drawing.Size(112, 20);
            this.txtBox_ToPersons.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(130, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "To:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(130, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "To:";
            // 
            // txtBox_ToDays
            // 
            this.txtBox_ToDays.Location = new System.Drawing.Point(159, 72);
            this.txtBox_ToDays.Name = "txtBox_ToDays";
            this.txtBox_ToDays.Size = new System.Drawing.Size(112, 20);
            this.txtBox_ToDays.TabIndex = 38;
            // 
            // txtBox_FromDays
            // 
            this.txtBox_FromDays.Location = new System.Drawing.Point(12, 72);
            this.txtBox_FromDays.Name = "txtBox_FromDays";
            this.txtBox_FromDays.Size = new System.Drawing.Size(112, 20);
            this.txtBox_FromDays.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(9, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Number Of Days:";
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(817, 485);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservations";
            this.Text = "frmReservations";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationGrid)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView reservationGrid;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.MaskedTextBox mtxtBox_FromDate;
        private System.Windows.Forms.TextBox txtBox_ToPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_FromPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Canceled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_FromPersons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox mTxtBox_ToDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_ToPersons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_ToDays;
        private System.Windows.Forms.TextBox txtBox_FromDays;
        private System.Windows.Forms.Label label9;
    }
}