namespace WinUI
{
    partial class ClientAddressForm
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
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.comboDistrict = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStreet.Location = new System.Drawing.Point(29, 35);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(53, 19);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Strada";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(113, 35);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(205, 20);
            this.txtStreet.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(113, 100);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(205, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNumber.Location = new System.Drawing.Point(29, 101);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(55, 19);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Numar";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCity.Location = new System.Drawing.Point(29, 168);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 19);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "Oras";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCounty.Location = new System.Drawing.Point(29, 236);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(46, 19);
            this.lblCounty.TabIndex = 5;
            this.lblCounty.Text = "Judet";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(149, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // comboCity
            // 
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(113, 165);
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(205, 21);
            this.comboCity.TabIndex = 8;
            // 
            // comboDistrict
            // 
            this.comboDistrict.FormattingEnabled = true;
            this.comboDistrict.Location = new System.Drawing.Point(113, 233);
            this.comboDistrict.Name = "comboDistrict";
            this.comboDistrict.Size = new System.Drawing.Size(205, 21);
            this.comboDistrict.TabIndex = 9;
            // 
            // ClientAddressAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 380);
            this.Controls.Add(this.comboDistrict);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientAddressAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adresa Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientAddressAddForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientAddressAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.ComboBox comboDistrict;
    }
}