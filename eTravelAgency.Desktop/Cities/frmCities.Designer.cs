namespace eTravelAgency.Desktop.Cities
{
    partial class frmCities
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewCity = new System.Windows.Forms.Button();
            this.citiesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_City = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(335, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 16;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewCity);
            this.panel1.Controls.Add(this.citiesGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_City);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 419);
            this.panel1.TabIndex = 17;
            // 
            // btnNewCity
            // 
            this.btnNewCity.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewCity.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCity.ForeColor = System.Drawing.Color.White;
            this.btnNewCity.Location = new System.Drawing.Point(624, 43);
            this.btnNewCity.Name = "btnNewCity";
            this.btnNewCity.Size = new System.Drawing.Size(175, 25);
            this.btnNewCity.TabIndex = 22;
            this.btnNewCity.Text = "New City";
            this.btnNewCity.UseVisualStyleBackColor = false;
            this.btnNewCity.Click += new System.EventHandler(this.BtnNewCity_Click);
            // 
            // citiesGrid
            // 
            this.citiesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.citiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.citiesGrid.Location = new System.Drawing.Point(3, 96);
            this.citiesGrid.Name = "citiesGrid";
            this.citiesGrid.Size = new System.Drawing.Size(796, 308);
            this.citiesGrid.TabIndex = 18;
            this.citiesGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CitiesGrid_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search city:";
            // 
            // txtBox_City
            // 
            this.txtBox_City.Location = new System.Drawing.Point(3, 44);
            this.txtBox_City.Name = "txtBox_City";
            this.txtBox_City.Size = new System.Drawing.Size(202, 21);
            this.txtBox_City.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(283, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 25);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // frmCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(825, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCities";
            this.Text = "frmCities";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewCity;
        private System.Windows.Forms.DataGridView citiesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_City;
        private System.Windows.Forms.Button searchButton;
    }
}