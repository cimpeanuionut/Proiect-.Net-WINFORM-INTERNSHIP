namespace WinUI
{
    partial class MainMenuForm
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
            this.panelMeniuPrincipal = new System.Windows.Forms.Panel();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.lblMeniuPrincipal = new System.Windows.Forms.Label();
            this.panelMeniuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeniuPrincipal
            // 
            this.panelMeniuPrincipal.Controls.Add(this.btnItems);
            this.panelMeniuPrincipal.Controls.Add(this.btnClose);
            this.panelMeniuPrincipal.Controls.Add(this.btnInvoice);
            this.panelMeniuPrincipal.Controls.Add(this.btnClients);
            this.panelMeniuPrincipal.Controls.Add(this.lblMeniuPrincipal);
            this.panelMeniuPrincipal.Location = new System.Drawing.Point(29, 23);
            this.panelMeniuPrincipal.Name = "panelMeniuPrincipal";
            this.panelMeniuPrincipal.Size = new System.Drawing.Size(271, 290);
            this.panelMeniuPrincipal.TabIndex = 0;
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnItems.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnItems.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnItems.FlatAppearance.BorderSize = 2;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnItems.Location = new System.Drawing.Point(46, 183);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(174, 35);
            this.btnItems.TabIndex = 4;
            this.btnItems.Text = "Articole";
            this.btnItems.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(46, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Inchide Aplicatie";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInvoice.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnInvoice.FlatAppearance.BorderSize = 2;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInvoice.Location = new System.Drawing.Point(46, 122);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(174, 37);
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.Text = "Facturi";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.BtnInvoice_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClients.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnClients.FlatAppearance.BorderSize = 2;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClients.Location = new System.Drawing.Point(46, 62);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(174, 38);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Clienti";
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.BtnPartners_Click);
            // 
            // lblMeniuPrincipal
            // 
            this.lblMeniuPrincipal.AutoSize = true;
            this.lblMeniuPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMeniuPrincipal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeniuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMeniuPrincipal.Location = new System.Drawing.Point(60, 10);
            this.lblMeniuPrincipal.Name = "lblMeniuPrincipal";
            this.lblMeniuPrincipal.Size = new System.Drawing.Size(146, 22);
            this.lblMeniuPrincipal.TabIndex = 0;
            this.lblMeniuPrincipal.Text = "Meniul Principal";
            this.lblMeniuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(374, 335);
            this.Controls.Add(this.panelMeniuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu principal";
            this.panelMeniuPrincipal.ResumeLayout(false);
            this.panelMeniuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeniuPrincipal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Label lblMeniuPrincipal;
        private System.Windows.Forms.Button btnItems;
    }
}