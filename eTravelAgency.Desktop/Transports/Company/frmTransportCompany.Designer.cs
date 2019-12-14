namespace eTravelAgency.Desktop.Transports
{
    partial class frmTransportCompany
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
            this.searchButton = new System.Windows.Forms.Button();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transportsGrid = new System.Windows.Forms.DataGridView();
            this.txtBox_TransportSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search company:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(276, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompany.ForeColor = System.Drawing.Color.White;
            this.btnNewCompany.Location = new System.Drawing.Point(568, 49);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(150, 23);
            this.btnNewCompany.TabIndex = 9;
            this.btnNewCompany.Text = "New Company";
            this.btnNewCompany.UseVisualStyleBackColor = false;
            this.btnNewCompany.Click += new System.EventHandler(this.BtnNewCompany_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transportsGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 342);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companies";
            // 
            // transportsGrid
            // 
            this.transportsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.transportsGrid.Location = new System.Drawing.Point(24, 20);
            this.transportsGrid.Name = "transportsGrid";
            this.transportsGrid.Size = new System.Drawing.Size(682, 314);
            this.transportsGrid.TabIndex = 5;
            this.transportsGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TransportsGrid_MouseDoubleClick);
            // 
            // txtBox_TransportSearch
            // 
            this.txtBox_TransportSearch.Location = new System.Drawing.Point(36, 52);
            this.txtBox_TransportSearch.Name = "txtBox_TransportSearch";
            this.txtBox_TransportSearch.Size = new System.Drawing.Size(173, 20);
            this.txtBox_TransportSearch.TabIndex = 12;
            // 
            // frmTransportCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.txtBox_TransportSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransportCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransportCompany";
            this.Load += new System.EventHandler(this.FrmTransportCompany_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView transportsGrid;
        private System.Windows.Forms.TextBox txtBox_TransportSearch;
    }
}