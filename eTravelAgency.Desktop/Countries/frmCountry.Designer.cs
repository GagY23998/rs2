namespace eTravelAgency.Desktop.Countries
{
    partial class frmCountry
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
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtBox_TransportSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.CountryPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countryGrid = new System.Windows.Forms.DataGridView();
            this.CountryPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewCompany.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompany.ForeColor = System.Drawing.Color.White;
            this.btnNewCompany.Location = new System.Drawing.Point(567, 45);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(150, 23);
            this.btnNewCompany.TabIndex = 14;
            this.btnNewCompany.Text = "New Company";
            this.btnNewCompany.UseVisualStyleBackColor = false;
            this.btnNewCompany.Click += new System.EventHandler(this.BtnNewCompany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search company:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(275, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // txtBox_TransportSearch
            // 
            this.txtBox_TransportSearch.Location = new System.Drawing.Point(35, 46);
            this.txtBox_TransportSearch.Name = "txtBox_TransportSearch";
            this.txtBox_TransportSearch.Size = new System.Drawing.Size(174, 21);
            this.txtBox_TransportSearch.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(342, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // CountryPanel
            // 
            this.CountryPanel.Controls.Add(this.groupBox1);
            this.CountryPanel.Controls.Add(this.btnNewCompany);
            this.CountryPanel.Controls.Add(this.label1);
            this.CountryPanel.Controls.Add(this.searchButton);
            this.CountryPanel.Controls.Add(this.txtBox_TransportSearch);
            this.CountryPanel.Location = new System.Drawing.Point(12, 12);
            this.CountryPanel.Name = "CountryPanel";
            this.CountryPanel.Size = new System.Drawing.Size(808, 386);
            this.CountryPanel.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countryGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(35, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 295);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companies";
            // 
            // countryGrid
            // 
            this.countryGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.countryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.countryGrid.Location = new System.Drawing.Point(6, 20);
            this.countryGrid.Name = "countryGrid";
            this.countryGrid.Size = new System.Drawing.Size(663, 269);
            this.countryGrid.TabIndex = 11;
            this.countryGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CountryGrid_MouseDoubleClick);
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(860, 485);
            this.Controls.Add(this.CountryPanel);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCountry";
            this.Text = "frmCountry";
            this.CountryPanel.ResumeLayout(false);
            this.CountryPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtBox_TransportSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel CountryPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView countryGrid;
    }
}