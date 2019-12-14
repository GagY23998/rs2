namespace eTravelAgency.Desktop.Transports
{
    partial class frmTransportOffers
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
            this.btnNewOffer = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transportsGrid = new System.Windows.Forms.DataGridView();
            this.cmbBox_tCompanies = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewOffer
            // 
            this.btnNewOffer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOffer.ForeColor = System.Drawing.Color.White;
            this.btnNewOffer.Location = new System.Drawing.Point(568, 49);
            this.btnNewOffer.Name = "btnNewOffer";
            this.btnNewOffer.Size = new System.Drawing.Size(150, 23);
            this.btnNewOffer.TabIndex = 14;
            this.btnNewOffer.Text = "New Offer";
            this.btnNewOffer.UseVisualStyleBackColor = false;
            this.btnNewOffer.Click += new System.EventHandler(this.btnNewOffer_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(276, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 21);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transportsGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(26, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 312);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offers";
            // 
            // transportsGrid
            // 
            this.transportsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.transportsGrid.Location = new System.Drawing.Point(10, 26);
            this.transportsGrid.Name = "transportsGrid";
            this.transportsGrid.Size = new System.Drawing.Size(682, 286);
            this.transportsGrid.TabIndex = 11;
            this.transportsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transportsGrid_CellMouseDoubleClick);
            // 
            // cmbBox_tCompanies
            // 
            this.cmbBox_tCompanies.FormattingEnabled = true;
            this.cmbBox_tCompanies.Location = new System.Drawing.Point(36, 51);
            this.cmbBox_tCompanies.Name = "cmbBox_tCompanies";
            this.cmbBox_tCompanies.Size = new System.Drawing.Size(175, 21);
            this.cmbBox_tCompanies.TabIndex = 17;
            // 
            // frmTransportOffers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.cmbBox_tCompanies);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewOffer);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransportOffers";
            this.Text = "frmTransportOffers";
            this.Load += new System.EventHandler(this.frmTransportOffers_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmTransportOffers_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewOffer;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView transportsGrid;
        private System.Windows.Forms.ComboBox cmbBox_tCompanies;
    }
}