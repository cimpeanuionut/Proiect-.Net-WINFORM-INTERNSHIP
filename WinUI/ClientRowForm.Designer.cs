namespace WinUI
{
    partial class ClientRowForm
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
            this.panelPartnerDate = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.lblPartnerCode = new System.Windows.Forms.Label();
            this.txtClientSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelClientAddress = new System.Windows.Forms.Panel();
            this.btnAddClientAddress = new System.Windows.Forms.Button();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.dataGridClientAddress = new System.Windows.Forms.DataGridView();
            this.panelPartnerDate.SuspendLayout();
            this.panelClientAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPartnerDate
            // 
            this.panelPartnerDate.Controls.Add(this.btnBack);
            this.panelPartnerDate.Controls.Add(this.btnSave);
            this.panelPartnerDate.Controls.Add(this.txtClientEmail);
            this.panelPartnerDate.Controls.Add(this.lblEmail);
            this.panelPartnerDate.Controls.Add(this.txtClientPhone);
            this.panelPartnerDate.Controls.Add(this.lblPhone);
            this.panelPartnerDate.Controls.Add(this.txtClientCode);
            this.panelPartnerDate.Controls.Add(this.lblPartnerCode);
            this.panelPartnerDate.Controls.Add(this.txtClientSurName);
            this.panelPartnerDate.Controls.Add(this.lblSurName);
            this.panelPartnerDate.Controls.Add(this.txtClientName);
            this.panelPartnerDate.Controls.Add(this.lblName);
            this.panelPartnerDate.Location = new System.Drawing.Point(12, 12);
            this.panelPartnerDate.Name = "panelPartnerDate";
            this.panelPartnerDate.Size = new System.Drawing.Size(776, 195);
            this.panelPartnerDate.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(416, 126);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 47);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(240, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 48);
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(343, 84);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(430, 20);
            this.txtClientEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Location = new System.Drawing.Point(260, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 19);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(85, 85);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(157, 20);
            this.txtClientPhone.TabIndex = 7;
            this.txtClientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPartnerPhone_KeyPress);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPhone.Location = new System.Drawing.Point(20, 84);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 19);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefon";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(623, 26);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(150, 20);
            this.txtClientCode.TabIndex = 5;
            // 
            // lblPartnerCode
            // 
            this.lblPartnerCode.AutoSize = true;
            this.lblPartnerCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerCode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPartnerCode.Location = new System.Drawing.Point(519, 25);
            this.lblPartnerCode.Name = "lblPartnerCode";
            this.lblPartnerCode.Size = new System.Drawing.Size(80, 19);
            this.lblPartnerCode.TabIndex = 4;
            this.lblPartnerCode.Text = "Cod Client";
            // 
            // txtClientSurName
            // 
            this.txtClientSurName.Location = new System.Drawing.Point(343, 24);
            this.txtClientSurName.Name = "txtClientSurName";
            this.txtClientSurName.Size = new System.Drawing.Size(152, 20);
            this.txtClientSurName.TabIndex = 3;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSurName.Location = new System.Drawing.Point(260, 23);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(68, 19);
            this.lblSurName.TabIndex = 2;
            this.lblSurName.Text = "Prenume";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(86, 23);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(157, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(20, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nume";
            // 
            // panelClientAddress
            // 
            this.panelClientAddress.Controls.Add(this.btnAddClientAddress);
            this.panelClientAddress.Controls.Add(this.btnEditAddress);
            this.panelClientAddress.Controls.Add(this.btnDeleteAddress);
            this.panelClientAddress.Controls.Add(this.dataGridClientAddress);
            this.panelClientAddress.Location = new System.Drawing.Point(12, 213);
            this.panelClientAddress.Name = "panelClientAddress";
            this.panelClientAddress.Size = new System.Drawing.Size(776, 290);
            this.panelClientAddress.TabIndex = 1;
            // 
            // btnAddClientAddress
            // 
            this.btnAddClientAddress.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddClientAddress.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAddClientAddress.FlatAppearance.BorderSize = 2;
            this.btnAddClientAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClientAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClientAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddClientAddress.Location = new System.Drawing.Point(13, 16);
            this.btnAddClientAddress.Name = "btnAddClientAddress";
            this.btnAddClientAddress.Size = new System.Drawing.Size(215, 47);
            this.btnAddClientAddress.TabIndex = 14;
            this.btnAddClientAddress.Text = "Adauga o Adresa";
            this.btnAddClientAddress.UseVisualStyleBackColor = false;
            this.btnAddClientAddress.Click += new System.EventHandler(this.BtnAddClientAddress_Click);
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditAddress.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEditAddress.FlatAppearance.BorderSize = 2;
            this.btnEditAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditAddress.Location = new System.Drawing.Point(253, 16);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(242, 47);
            this.btnEditAddress.TabIndex = 13;
            this.btnEditAddress.Text = "Modifica o Adresa";
            this.btnEditAddress.UseVisualStyleBackColor = false;
            this.btnEditAddress.Click += new System.EventHandler(this.BtnEditAddress_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDeleteAddress.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnDeleteAddress.FlatAppearance.BorderSize = 2;
            this.btnDeleteAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteAddress.Location = new System.Drawing.Point(523, 16);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(218, 47);
            this.btnDeleteAddress.TabIndex = 12;
            this.btnDeleteAddress.Text = "Sterge o Adresa";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.BtnDeleteAddress_Click);
            // 
            // dataGridClientAddress
            // 
            this.dataGridClientAddress.AllowUserToAddRows = false;
            this.dataGridClientAddress.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridClientAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientAddress.Location = new System.Drawing.Point(3, 69);
            this.dataGridClientAddress.Name = "dataGridClientAddress";
            this.dataGridClientAddress.ReadOnly = true;
            this.dataGridClientAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientAddress.Size = new System.Drawing.Size(770, 211);
            this.dataGridClientAddress.TabIndex = 0;
            this.dataGridClientAddress.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridClientAddress_CellValueChanged);
            this.dataGridClientAddress.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridClientAddress_RowsRemoved);
            // 
            // ClientRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.panelClientAddress);
            this.Controls.Add(this.panelPartnerDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientRowForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientAddForm_Load);
            this.panelPartnerDate.ResumeLayout(false);
            this.panelPartnerDate.PerformLayout();
            this.panelClientAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPartnerDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtClientSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Label lblPartnerCode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelClientAddress;
        private System.Windows.Forms.Button btnAddClientAddress;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.DataGridView dataGridClientAddress;
    }
}