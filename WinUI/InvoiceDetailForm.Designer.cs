namespace WinUI
{
    partial class InvoiceDetailForm
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
            this.lblQtty = new System.Windows.Forms.Label();
            this.txtQtty = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblQtty
            // 
            this.lblQtty.AutoSize = true;
            this.lblQtty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblQtty.Location = new System.Drawing.Point(12, 102);
            this.lblQtty.Name = "lblQtty";
            this.lblQtty.Size = new System.Drawing.Size(71, 19);
            this.lblQtty.TabIndex = 0;
            this.lblQtty.Text = "Cantitate";
            // 
            // txtQtty
            // 
            this.txtQtty.Location = new System.Drawing.Point(130, 102);
            this.txtQtty.Name = "txtQtty";
            this.txtQtty.Size = new System.Drawing.Size(187, 20);
            this.txtQtty.TabIndex = 1;
            this.txtQtty.TextChanged += new System.EventHandler(this.TxtQtty_TextChanged);
            this.txtQtty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtty_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrice.Location = new System.Drawing.Point(12, 162);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 19);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Pret";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 161);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.TxtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAmount.Location = new System.Drawing.Point(12, 217);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(61, 19);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Valoare";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(130, 218);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(187, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblObs.Location = new System.Drawing.Point(12, 276);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(79, 19);
            this.lblObs.TabIndex = 6;
            this.lblObs.Text = "Observatii";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(130, 277);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(187, 98);
            this.txtObs.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.Location = new System.Drawing.Point(102, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 47);
            this.btnSave.TabIndex = 15;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblItem.Location = new System.Drawing.Point(12, 41);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(54, 19);
            this.lblItem.TabIndex = 16;
            this.lblItem.Text = "Articol";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(130, 38);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(187, 21);
            this.comboBoxItem.TabIndex = 17;
            // 
            // InvoiceAddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 493);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQtty);
            this.Controls.Add(this.lblQtty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoiceAddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceAddItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceAddItemForm_FormClosed);
            this.Load += new System.EventHandler(this.InvoiceAddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtty;
        private System.Windows.Forms.TextBox txtQtty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox comboBoxItem;
    }
}