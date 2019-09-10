namespace WinUI
{
    partial class InvoiceListForm
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
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.comboBoxFilterClientName = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtNrInvoice = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceNr = new System.Windows.Forms.Label();
            this.dateTimePickerFinishDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblMeniuFilter = new System.Windows.Forms.Label();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(254, 114);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(553, 367);
            this.dataGridViewInvoice.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.comboBoxFilterClientName);
            this.panelFilter.Controls.Add(this.btnFilter);
            this.panelFilter.Controls.Add(this.lblClientName);
            this.panelFilter.Controls.Add(this.txtNrInvoice);
            this.panelFilter.Controls.Add(this.dateTimePickerStartDate);
            this.panelFilter.Controls.Add(this.lblInvoiceNr);
            this.panelFilter.Controls.Add(this.dateTimePickerFinishDate);
            this.panelFilter.Controls.Add(this.lblFinishDate);
            this.panelFilter.Controls.Add(this.lblStartDate);
            this.panelFilter.Controls.Add(this.lblMeniuFilter);
            this.panelFilter.Location = new System.Drawing.Point(12, 12);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(220, 413);
            this.panelFilter.TabIndex = 1;
            // 
            // comboBoxFilterClientName
            // 
            this.comboBoxFilterClientName.FormattingEnabled = true;
            this.comboBoxFilterClientName.Location = new System.Drawing.Point(17, 303);
            this.comboBoxFilterClientName.Name = "comboBoxFilterClientName";
            this.comboBoxFilterClientName.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFilterClientName.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnFilter.FlatAppearance.BorderSize = 2;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilter.Location = new System.Drawing.Point(69, 342);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(134, 54);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filtreaza";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblClientName.Location = new System.Drawing.Point(21, 280);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(93, 19);
            this.lblClientName.TabIndex = 9;
            this.lblClientName.Text = "Nume Client";
            // 
            // txtNrInvoice
            // 
            this.txtNrInvoice.Location = new System.Drawing.Point(17, 233);
            this.txtNrInvoice.Name = "txtNrInvoice";
            this.txtNrInvoice.Size = new System.Drawing.Size(200, 20);
            this.txtNrInvoice.TabIndex = 8;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Checked = false;
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(17, 76);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStartDate.TabIndex = 5;
            this.dateTimePickerStartDate.Value = new System.DateTime(2019, 9, 4, 0, 0, 0, 0);
            // 
            // lblInvoiceNr
            // 
            this.lblInvoiceNr.AutoSize = true;
            this.lblInvoiceNr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNr.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInvoiceNr.Location = new System.Drawing.Point(21, 211);
            this.lblInvoiceNr.Name = "lblInvoiceNr";
            this.lblInvoiceNr.Size = new System.Drawing.Size(126, 19);
            this.lblInvoiceNr.TabIndex = 7;
            this.lblInvoiceNr.Text = "Numar de factura";
            // 
            // dateTimePickerFinishDate
            // 
            this.dateTimePickerFinishDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinishDate.Checked = false;
            this.dateTimePickerFinishDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinishDate.Location = new System.Drawing.Point(17, 152);
            this.dateTimePickerFinishDate.Name = "dateTimePickerFinishDate";
            this.dateTimePickerFinishDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFinishDate.TabIndex = 6;
            this.dateTimePickerFinishDate.Value = new System.DateTime(2019, 9, 4, 0, 0, 0, 0);
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFinishDate.Location = new System.Drawing.Point(21, 130);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(108, 19);
            this.lblFinishDate.TabIndex = 3;
            this.lblFinishDate.Text = "Data de sfarsit";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStartDate.Location = new System.Drawing.Point(21, 54);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(114, 19);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Data de inceput";
            // 
            // lblMeniuFilter
            // 
            this.lblMeniuFilter.AutoSize = true;
            this.lblMeniuFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeniuFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMeniuFilter.Location = new System.Drawing.Point(21, 3);
            this.lblMeniuFilter.Name = "lblMeniuFilter";
            this.lblMeniuFilter.Size = new System.Drawing.Size(146, 22);
            this.lblMeniuFilter.TabIndex = 0;
            this.lblMeniuFilter.Text = "Filtre de cautare";
            // 
            // panelMeniu
            // 
            this.panelMeniu.Controls.Add(this.btnDelete);
            this.panelMeniu.Controls.Add(this.btnEdit);
            this.panelMeniu.Controls.Add(this.btnAdd);
            this.panelMeniu.Location = new System.Drawing.Point(254, 12);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(553, 62);
            this.panelMeniu.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(415, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Location = new System.Drawing.Point(208, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 54);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnMainMenu.FlatAppearance.BorderSize = 2;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMainMenu.Location = new System.Drawing.Point(12, 438);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(220, 54);
            this.btnMainMenu.TabIndex = 12;
            this.btnMainMenu.Text = "Inapoi la meniu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 504);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridViewInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelMeniu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMeniuFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtNrInvoice;
        private System.Windows.Forms.Label lblInvoiceNr;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinishDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.ComboBox comboBoxFilterClientName;
    }
}