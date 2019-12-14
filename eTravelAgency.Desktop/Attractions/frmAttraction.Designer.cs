namespace eTravelAgency.Desktop.Attractions
{
    partial class frmAttraction
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
            this.attractionPanel = new System.Windows.Forms.Panel();
            this.comboBox_Cities = new System.Windows.Forms.ComboBox();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.attrGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.attractionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attrGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // attractionPanel
            // 
            this.attractionPanel.Controls.Add(this.comboBox_Cities);
            this.attractionPanel.Controls.Add(this.btnNewCompany);
            this.attractionPanel.Controls.Add(this.label1);
            this.attractionPanel.Controls.Add(this.searchButton);
            this.attractionPanel.Controls.Add(this.attrGrid);
            this.attractionPanel.Location = new System.Drawing.Point(47, 25);
            this.attractionPanel.Name = "attractionPanel";
            this.attractionPanel.Size = new System.Drawing.Size(708, 386);
            this.attractionPanel.TabIndex = 0;
            // 
            // comboBox_Cities
            // 
            this.comboBox_Cities.FormattingEnabled = true;
            this.comboBox_Cities.Location = new System.Drawing.Point(15, 43);
            this.comboBox_Cities.Name = "comboBox_Cities";
            this.comboBox_Cities.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Cities.TabIndex = 15;
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCompany.ForeColor = System.Drawing.Color.White;
            this.btnNewCompany.Location = new System.Drawing.Point(547, 41);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(150, 23);
            this.btnNewCompany.TabIndex = 14;
            this.btnNewCompany.Text = "New Attraction";
            this.btnNewCompany.UseVisualStyleBackColor = false;
            this.btnNewCompany.Click += new System.EventHandler(this.BtnNewCompany_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search attraction:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(255, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // attrGrid
            // 
            this.attrGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.attrGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attrGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.attrGrid.Location = new System.Drawing.Point(15, 91);
            this.attrGrid.Name = "attrGrid";
            this.attrGrid.Size = new System.Drawing.Size(682, 286);
            this.attrGrid.TabIndex = 10;
            this.attrGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.attrGrid_CellMouseDoubleClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(328, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // frmAttraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(853, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.attractionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttraction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAttraction";
            this.Load += new System.EventHandler(this.frmAttraction_Load);
            this.attractionPanel.ResumeLayout(false);
            this.attractionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attrGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel attractionPanel;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView attrGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_Cities;
    }
}