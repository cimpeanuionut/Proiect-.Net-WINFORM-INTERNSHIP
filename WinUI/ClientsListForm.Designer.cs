namespace WinUI
{
    partial class ClientsListForm
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
            this.dataPartners = new System.Windows.Forms.DataGridView();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTitleFilters = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGoFirst = new System.Windows.Forms.Button();
            this.btnGoPrevious = new System.Windows.Forms.Button();
            this.btnGoNext = new System.Windows.Forms.Button();
            this.btnGoLast = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblPageSize = new System.Windows.Forms.Label();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartners)).BeginInit();
            this.panelFilters.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPartners
            // 
            this.dataPartners.AllowUserToAddRows = false;
            this.dataPartners.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartners.Location = new System.Drawing.Point(239, 70);
            this.dataPartners.Name = "dataPartners";
            this.dataPartners.ReadOnly = true;
            this.dataPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartners.Size = new System.Drawing.Size(599, 332);
            this.dataPartners.TabIndex = 0;
            // 
            // panelFilters
            // 
            this.panelFilters.Controls.Add(this.btnFilter);
            this.panelFilters.Controls.Add(this.txtClientCode);
            this.panelFilters.Controls.Add(this.lblCode);
            this.panelFilters.Controls.Add(this.txtSurName);
            this.panelFilters.Controls.Add(this.lblSurName);
            this.panelFilters.Controls.Add(this.txtName);
            this.panelFilters.Controls.Add(this.lblName);
            this.panelFilters.Controls.Add(this.lblTitleFilters);
            this.panelFilters.Location = new System.Drawing.Point(12, 12);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(200, 390);
            this.panelFilters.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnFilter.FlatAppearance.BorderSize = 2;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilter.Location = new System.Drawing.Point(55, 318);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(114, 42);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filtreaza";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(31, 251);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(166, 20);
            this.txtClientCode.TabIndex = 6;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCode.Location = new System.Drawing.Point(27, 220);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(80, 19);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Cod Client";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(27, 166);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(170, 20);
            this.txtSurName.TabIndex = 4;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSurName.Location = new System.Drawing.Point(23, 131);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(112, 19);
            this.lblSurName.TabIndex = 3;
            this.lblSurName.Text = "Prenume Client";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(27, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(23, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nume Client";
            // 
            // lblTitleFilters
            // 
            this.lblTitleFilters.AutoSize = true;
            this.lblTitleFilters.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFilters.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitleFilters.Location = new System.Drawing.Point(23, 10);
            this.lblTitleFilters.Name = "lblTitleFilters";
            this.lblTitleFilters.Size = new System.Drawing.Size(146, 22);
            this.lblTitleFilters.TabIndex = 0;
            this.lblTitleFilters.Text = "Filtre de cautare";
            this.lblTitleFilters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(3, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Location = new System.Drawing.Point(212, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 42);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Modifica";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(437, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 42);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(239, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 51);
            this.panel1.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(12, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 52);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Inapoi la Meniul Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnGoFirst
            // 
            this.btnGoFirst.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGoFirst.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoFirst.FlatAppearance.BorderSize = 2;
            this.btnGoFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoFirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoFirst.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoFirst.Location = new System.Drawing.Point(242, 443);
            this.btnGoFirst.Name = "btnGoFirst";
            this.btnGoFirst.Size = new System.Drawing.Size(34, 35);
            this.btnGoFirst.TabIndex = 13;
            this.btnGoFirst.Text = "|<";
            this.btnGoFirst.UseVisualStyleBackColor = false;
            this.btnGoFirst.Click += new System.EventHandler(this.BtnGoFirst_Click);
            // 
            // btnGoPrevious
            // 
            this.btnGoPrevious.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGoPrevious.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoPrevious.FlatAppearance.BorderSize = 2;
            this.btnGoPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPrevious.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoPrevious.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoPrevious.Location = new System.Drawing.Point(282, 443);
            this.btnGoPrevious.Name = "btnGoPrevious";
            this.btnGoPrevious.Size = new System.Drawing.Size(34, 35);
            this.btnGoPrevious.TabIndex = 14;
            this.btnGoPrevious.Text = "<";
            this.btnGoPrevious.UseVisualStyleBackColor = false;
            this.btnGoPrevious.Click += new System.EventHandler(this.BtnGoPrevious_Click);
            // 
            // btnGoNext
            // 
            this.btnGoNext.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGoNext.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoNext.FlatAppearance.BorderSize = 2;
            this.btnGoNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoNext.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoNext.Location = new System.Drawing.Point(509, 443);
            this.btnGoNext.Name = "btnGoNext";
            this.btnGoNext.Size = new System.Drawing.Size(34, 35);
            this.btnGoNext.TabIndex = 15;
            this.btnGoNext.Text = ">";
            this.btnGoNext.UseVisualStyleBackColor = false;
            this.btnGoNext.Click += new System.EventHandler(this.BtnGoNext_Click);
            // 
            // btnGoLast
            // 
            this.btnGoLast.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGoLast.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnGoLast.FlatAppearance.BorderSize = 2;
            this.btnGoLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoLast.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoLast.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGoLast.Location = new System.Drawing.Point(549, 443);
            this.btnGoLast.Name = "btnGoLast";
            this.btnGoLast.Size = new System.Drawing.Size(34, 35);
            this.btnGoLast.TabIndex = 16;
            this.btnGoLast.Text = ">|";
            this.btnGoLast.UseVisualStyleBackColor = false;
            this.btnGoLast.Click += new System.EventHandler(this.BtnGoLast_Click);
            // 
            // lblPage
            // 
            this.lblPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPage.Location = new System.Drawing.Point(333, 443);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(158, 35);
            this.lblPage.TabIndex = 17;
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPageSize
            // 
            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageSize.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPageSize.Location = new System.Drawing.Point(599, 420);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(68, 19);
            this.lblPageSize.TabIndex = 18;
            this.lblPageSize.Text = "Page Size";
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(589, 443);
            this.txtTotalPage.Multiline = true;
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(111, 35);
            this.txtTotalPage.TabIndex = 19;
            this.txtTotalPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotalPage_KeyPress);
            // 
            // ClientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 505);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.lblPageSize);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.btnGoLast);
            this.Controls.Add(this.btnGoNext);
            this.Controls.Add(this.btnGoPrevious);
            this.Controls.Add(this.btnGoFirst);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.dataPartners);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.PartnersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPartners)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPartners;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTitleFilters;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGoFirst;
        private System.Windows.Forms.Button btnGoPrevious;
        private System.Windows.Forms.Button btnGoNext;
        private System.Windows.Forms.Button btnGoLast;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.TextBox txtTotalPage;
    }
}