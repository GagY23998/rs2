namespace eTravelAgency.Desktop.Reviews
{
    partial class frmReviews
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
            this.label_City = new System.Windows.Forms.Label();
            this.txtBox_tCompany = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_Hotel = new System.Windows.Forms.TextBox();
            this.label_Hotel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.reviewsGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label_Rating = new System.Windows.Forms.Label();
            this.txtBox_Rating = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label_City.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_City.Location = new System.Drawing.Point(11, 28);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(115, 15);
            this.label_City.TabIndex = 0;
            this.label_City.Text = "Transport company:";
            // 
            // txtBox_tCompany
            // 
            this.txtBox_tCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.txtBox_tCompany.Location = new System.Drawing.Point(138, 25);
            this.txtBox_tCompany.Name = "txtBox_tCompany";
            this.txtBox_tCompany.Size = new System.Drawing.Size(117, 21);
            this.txtBox_tCompany.TabIndex = 1;
            // 
            // txtBox_Hotel
            // 
            this.txtBox_Hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.txtBox_Hotel.Location = new System.Drawing.Point(345, 24);
            this.txtBox_Hotel.Name = "txtBox_Hotel";
            this.txtBox_Hotel.Size = new System.Drawing.Size(117, 21);
            this.txtBox_Hotel.TabIndex = 2;
            // 
            // label_Hotel
            // 
            this.label_Hotel.AutoSize = true;
            this.label_Hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label_Hotel.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_Hotel.Location = new System.Drawing.Point(280, 27);
            this.label_Hotel.Name = "label_Hotel";
            this.label_Hotel.Size = new System.Drawing.Size(39, 15);
            this.label_Hotel.TabIndex = 3;
            this.label_Hotel.Text = "Hotel:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(697, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 25);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // reviewsGrid
            // 
            this.reviewsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reviewsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.reviewsGrid.Location = new System.Drawing.Point(12, 71);
            this.reviewsGrid.Name = "reviewsGrid";
            this.reviewsGrid.Size = new System.Drawing.Size(776, 308);
            this.reviewsGrid.TabIndex = 24;
            this.reviewsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.reviewsGrid_CellMouseDoubleClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(323, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 25;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label_Rating
            // 
            this.label_Rating.AutoSize = true;
            this.label_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.label_Rating.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_Rating.Location = new System.Drawing.Point(491, 28);
            this.label_Rating.Name = "label_Rating";
            this.label_Rating.Size = new System.Drawing.Size(46, 15);
            this.label_Rating.TabIndex = 27;
            this.label_Rating.Text = "Rating:";
            // 
            // txtBox_Rating
            // 
            this.txtBox_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.txtBox_Rating.Location = new System.Drawing.Point(553, 25);
            this.txtBox_Rating.Name = "txtBox_Rating";
            this.txtBox_Rating.Size = new System.Drawing.Size(117, 21);
            this.txtBox_Rating.TabIndex = 26;
            // 
            // frmReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Rating);
            this.Controls.Add(this.txtBox_Rating);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.reviewsGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label_Hotel);
            this.Controls.Add(this.txtBox_Hotel);
            this.Controls.Add(this.txtBox_tCompany);
            this.Controls.Add(this.label_City);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReviews";
            this.Text = "frmReviews";
            ((System.ComponentModel.ISupportInitialize)(this.reviewsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.MaskedTextBox txtBox_tCompany;
        private System.Windows.Forms.TextBox txtBox_Hotel;
        private System.Windows.Forms.Label label_Hotel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView reviewsGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_Rating;
        private System.Windows.Forms.TextBox txtBox_Rating;
    }
}