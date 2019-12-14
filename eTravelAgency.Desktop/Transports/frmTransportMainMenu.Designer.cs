namespace eTravelAgency.Desktop.Transports
{
    partial class frmTransportMainMenu
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
            this.TransportPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCompanies = new System.Windows.Forms.Button();
            this.btnOffers = new System.Windows.Forms.Button();
            this.btnTypes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransportPanel
            // 
            this.TransportPanel.Location = new System.Drawing.Point(0, 2);
            this.TransportPanel.Name = "TransportPanel";
            this.TransportPanel.Size = new System.Drawing.Size(933, 422);
            this.TransportPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(622, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnCompanies
            // 
            this.btnCompanies.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCompanies.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanies.ForeColor = System.Drawing.Color.White;
            this.btnCompanies.Location = new System.Drawing.Point(46, 429);
            this.btnCompanies.Name = "btnCompanies";
            this.btnCompanies.Size = new System.Drawing.Size(150, 43);
            this.btnCompanies.TabIndex = 7;
            this.btnCompanies.Text = "Companies";
            this.btnCompanies.UseVisualStyleBackColor = false;
            this.btnCompanies.Click += new System.EventHandler(this.BtnCompanies_Click);
            // 
            // btnOffers
            // 
            this.btnOffers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOffers.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffers.ForeColor = System.Drawing.Color.White;
            this.btnOffers.Location = new System.Drawing.Point(238, 430);
            this.btnOffers.Name = "btnOffers";
            this.btnOffers.Size = new System.Drawing.Size(150, 43);
            this.btnOffers.TabIndex = 8;
            this.btnOffers.Text = "Offers";
            this.btnOffers.UseVisualStyleBackColor = false;
            this.btnOffers.Click += new System.EventHandler(this.BtnOffers_Click);
            // 
            // btnTypes
            // 
            this.btnTypes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTypes.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypes.ForeColor = System.Drawing.Color.White;
            this.btnTypes.Location = new System.Drawing.Point(433, 429);
            this.btnTypes.Name = "btnTypes";
            this.btnTypes.Size = new System.Drawing.Size(150, 43);
            this.btnTypes.TabIndex = 9;
            this.btnTypes.Text = "Types";
            this.btnTypes.UseVisualStyleBackColor = false;
            this.btnTypes.Click += new System.EventHandler(this.BtnTypes_Click);
            // 
            // frmTransportMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.Controls.Add(this.btnTypes);
            this.Controls.Add(this.btnOffers);
            this.Controls.Add(this.btnCompanies);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TransportPanel);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransportMainMenu";
            this.Text = "frmTransportMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TransportPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCompanies;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnTypes;
    }
}