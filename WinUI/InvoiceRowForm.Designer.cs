namespace WinUI
{
    partial class InvoiceRowForm
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
            this.lblNrInvoice = new System.Windows.Forms.Label();
            this.txtNrInvoice = new System.Windows.Forms.TextBox();
            this.lblDateInvoice = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.comboBoxClientName = new System.Windows.Forms.ComboBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.comboBoxClientAddress = new System.Windows.Forms.ComboBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panelInvoiceAdd = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInvoiceAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNrInvoice
            // 
            this.lblNrInvoice.AutoSize = true;
            this.lblNrInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrInvoice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNrInvoice.Location = new System.Drawing.Point(9, 17);
            this.lblNrInvoice.Name = "lblNrInvoice";
            this.lblNrInvoice.Size = new System.Drawing.Size(110, 19);
            this.lblNrInvoice.TabIndex = 0;
            this.lblNrInvoice.Text = "Numar Factura";
            // 
            // txtNrInvoice
            // 
            this.txtNrInvoice.Location = new System.Drawing.Point(156, 18);
            this.txtNrInvoice.Name = "txtNrInvoice";
            this.txtNrInvoice.Size = new System.Drawing.Size(173, 20);
            this.txtNrInvoice.TabIndex = 1;
            // 
            // lblDateInvoice
            // 
            this.lblDateInvoice.AutoSize = true;
            this.lblDateInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateInvoice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDateInvoice.Location = new System.Drawing.Point(378, 19);
            this.lblDateInvoice.Name = "lblDateInvoice";
            this.lblDateInvoice.Size = new System.Drawing.Size(97, 19);
            this.lblDateInvoice.TabIndex = 2;
            this.lblDateInvoice.Text = "Data Factura";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClient.Location = new System.Drawing.Point(9, 84);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(93, 19);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Nume Client";
            // 
            // comboBoxClientName
            // 
            this.comboBoxClientName.FormattingEnabled = true;
            this.comboBoxClientName.Location = new System.Drawing.Point(156, 85);
            this.comboBoxClientName.Name = "comboBoxClientName";
            this.comboBoxClientName.Size = new System.Drawing.Size(173, 21);
            this.comboBoxClientName.TabIndex = 5;
            this.comboBoxClientName.SelectedValueChanged += new System.EventHandler(this.ComboBoxClientName_SelectedValueChanged);
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClientAddress.Location = new System.Drawing.Point(378, 87);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(101, 19);
            this.lblClientAddress.TabIndex = 6;
            this.lblClientAddress.Text = "Adresa Client";
            // 
            // comboBoxClientAddress
            // 
            this.comboBoxClientAddress.FormattingEnabled = true;
            this.comboBoxClientAddress.Location = new System.Drawing.Point(532, 88);
            this.comboBoxClientAddress.Name = "comboBoxClientAddress";
            this.comboBoxClientAddress.Size = new System.Drawing.Size(192, 21);
            this.comboBoxClientAddress.TabIndex = 7;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblObs.Location = new System.Drawing.Point(9, 166);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(79, 19);
            this.lblObs.TabIndex = 8;
            this.lblObs.Text = "Observatii";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(156, 151);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(568, 84);
            this.txtObs.TabIndex = 9;
            // 
            // panelInvoiceAdd
            // 
            this.panelInvoiceAdd.Controls.Add(this.btnBack);
            this.panelInvoiceAdd.Controls.Add(this.btnSave);
            this.panelInvoiceAdd.Controls.Add(this.dateTimePickerInvoiceDate);
            this.panelInvoiceAdd.Controls.Add(this.lblNrInvoice);
            this.panelInvoiceAdd.Controls.Add(this.txtObs);
            this.panelInvoiceAdd.Controls.Add(this.txtNrInvoice);
            this.panelInvoiceAdd.Controls.Add(this.lblObs);
            this.panelInvoiceAdd.Controls.Add(this.lblDateInvoice);
            this.panelInvoiceAdd.Controls.Add(this.comboBoxClientAddress);
            this.panelInvoiceAdd.Controls.Add(this.lblClientAddress);
            this.panelInvoiceAdd.Controls.Add(this.lblClient);
            this.panelInvoiceAdd.Controls.Add(this.comboBoxClientName);
            this.panelInvoiceAdd.Location = new System.Drawing.Point(3, 12);
            this.panelInvoiceAdd.Name = "panelInvoiceAdd";
            this.panelInvoiceAdd.Size = new System.Drawing.Size(785, 324);
            this.panelInvoiceAdd.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(596, 257);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 39);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(356, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInvoiceDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(532, 17);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(192, 26);
            this.dateTimePickerInvoiceDate.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Adauga un Articol";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Location = new System.Drawing.Point(276, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(221, 39);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Modifica un Articol";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(573, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 39);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Sterge un Articol";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 48);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(779, 197);
            this.dataGridViewItems.TabIndex = 16;
            this.dataGridViewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewItems_CellValueChanged);
            this.dataGridViewItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridViewItems_RowsRemoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewItems);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(6, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 248);
            this.panel1.TabIndex = 11;           
            // 
            // InvoiceRowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInvoiceAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoiceRowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceAddForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceRowForm_FormClosed);
            this.Load += new System.EventHandler(this.InvoiceAddForm_Load);
            this.panelInvoiceAdd.ResumeLayout(false);
            this.panelInvoiceAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNrInvoice;
        private System.Windows.Forms.TextBox txtNrInvoice;
        private System.Windows.Forms.Label lblDateInvoice;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox comboBoxClientName;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.ComboBox comboBoxClientAddress;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Panel panelInvoiceAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panel1;
    }
}