using BusinessLogic;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class InvoiceDetailForm : Form
    {
        private int invoiceId;
        private int invoiceDetailId;
        private InvoiceDetailModel invoiceDetail = new InvoiceDetailModel();
        BindingList<ItemModel> list;
        private InvoiceRowForm invoiceAddForm;
        private int status;
        private bool isAdded = true;
        private string unique = "";
        public InvoiceDetailForm()
        {
            InitializeComponent();
        }

        public InvoiceDetailForm(int invoiceId, int invoiceDetailId, InvoiceRowForm invoiceAddForm, int status)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
            this.invoiceDetailId = invoiceDetailId;
            this.invoiceAddForm = invoiceAddForm;
            this.status = status;
        }

        private void InvoiceAddItemForm_Load(object sender, EventArgs e)
        {
            BLItem bl = new BLItem();
            list = bl.BLGetItem();
            foreach (ItemModel item in list)
            {
                comboBoxItem.Items.Add(item.itemName.ToString());
            }

            if (invoiceDetailId == 0)
                btnSave.Text = "Salveaza";
            else
                btnSave.Text = "Modifica";
        }

        public bool IsAddedorModify()
        {
            return isAdded;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BasicValidation())
            {

                invoiceDetail.invoiceDetailId = invoiceDetailId;
                invoiceDetail.invoiceId = invoiceId;
                foreach (ItemModel item in list)
                {
                    if (item.itemName == comboBoxItem.Text)
                        invoiceDetail.itemId = item.itemId;
                }

                invoiceDetail.itemName = comboBoxItem.Text;
                invoiceDetail.qtty = Convert.ToDecimal(txtQtty.Text);
                invoiceDetail.price = Convert.ToDecimal(txtPrice.Text);
                invoiceDetail.amount = Convert.ToDecimal(txtAmount.Text);
                invoiceDetail.observation = txtObs.Text;
                invoiceDetail.status = status;
                if (this.unique == "")
                {
                    invoiceDetail.unique = invoiceDetail.RandomString(8);
                }
                else
                {
                    invoiceDetail.unique = this.unique;
                }


                isAdded = false;
                invoiceAddForm.AddItemToDataGridViewAndList(this);
                invoiceAddForm.Show();
                this.Hide();
            }

        }

        public bool BasicValidation()
        {
            if (String.IsNullOrWhiteSpace(comboBoxItem.Text))
            {
                MessageBox.Show("Articolul este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtQtty.Text) || txtQtty.Text == ".")
            {
                MessageBox.Show("Cantitate este obligatorie", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtPrice.Text) || txtPrice.Text == ".")
            {
                MessageBox.Show("Pretul este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        public InvoiceDetailModel GetInvoiceDetail()
        {
            return this.invoiceDetail;
        }

        private void TextBox_Validation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }
        }

        private void TxtQtty_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_Validation(sender, e);
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox_Validation(sender, e);
        }

        private void CalculateAmount()
        {
            decimal price, qtty;
            if (txtPrice.Text == "" || txtPrice.Text == ".")
                price = 0;
            else
                price = Convert.ToDecimal(txtPrice.Text);

            if (txtQtty.Text == "" || txtQtty.Text == ".")
                qtty = 0;
            else
                qtty = Convert.ToDecimal(txtQtty.Text);
           
            txtAmount.Text = (qtty * price).ToString();
        }

        private void TxtQtty_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        public void PopulareInvoiceAddItemForm(string itemName, decimal qtty, decimal price, decimal amount, string obs, string unique)
        {            
           comboBoxItem.Text = itemName;
           txtQtty.Text = qtty.ToString();
           txtPrice.Text = price.ToString();
           txtAmount.Text = amount.ToString();
           txtObs.Text = obs;
            this.unique = unique;
        }

        private void InvoiceAddItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            invoiceAddForm.Show();
            this.Hide();
        }
    }
}

       