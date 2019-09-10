using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            this.Close();
        }

        private void BtnPartners_Click(object sender, EventArgs e)
        {
            ClientsListForm partners = new ClientsListForm();
            partners.Show();
            this.Hide();           
            partners.FormClosed += Partners_FormClosed;
        }

        private void Partners_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            InvoiceListForm invoice = new InvoiceListForm();
            invoice.Show();
            this.Hide();
            invoice.FormClosed += Invoice_FormClosed;
        }

        private void Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
