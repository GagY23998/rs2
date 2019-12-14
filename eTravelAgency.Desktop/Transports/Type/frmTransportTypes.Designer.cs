namespace eTravelAgency.Desktop.Transports
{
    partial class frmTransportTypes
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
            this.btnNewTypes = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtBox_TransportSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transportsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search Types:";
            // 
            // btnNewTypes
            // 
            this.btnNewTypes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewTypes.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTypes.ForeColor = System.Drawing.Color.White;
            this.btnNewTypes.Location = new System.Drawing.Point(568, 49);
            this.btnNewTypes.Name = "btnNewTypes";
            this.btnNewTypes.Size = new System.Drawing.Size(150, 23);
            this.btnNewTypes.TabIndex = 20;
            this.btnNewTypes.Text = "New Type";
            this.btnNewTypes.UseVisualStyleBackColor = false;
            this.btnNewTypes.Click += new System.EventHandler(this.BtnNewTypes_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.searchButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.searchButton.Location = new System.Drawing.Point(276, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 21);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search\r\n";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // txtBox_TransportSearch
            // 
            this.txtBox_TransportSearch.Location = new System.Drawing.Point(36, 49);
            this.txtBox_TransportSearch.Name = "txtBox_TransportSearch";
            this.txtBox_TransportSearch.Size = new System.Drawing.Size(174, 21);
            this.txtBox_TransportSearch.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transportsGrid);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(36, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 324);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types";
            // 
            // transportsGrid
            // 
            this.transportsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.transportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.transportsGrid.Location = new System.Drawing.Point(12, 20);
            this.transportsGrid.Name = "transportsGrid";
            this.transportsGrid.Size = new System.Drawing.Size(664, 286);
            this.transportsGrid.TabIndex = 17;
            this.transportsGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TransportsGrid_MouseDoubleClick);
            // 
            // frmTransportTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewTypes);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.txtBox_TransportSearch);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransportTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransportTypes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTransportTypes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transportsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewTypes;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox txtBox_TransportSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView transportsGrid;
    }
}