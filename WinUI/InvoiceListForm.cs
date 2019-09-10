using BusinessLogic;
using Entities;
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
    public partial class InvoiceListForm : Form
    {
        private bool checkedStartDate = false;
        private bool checkedFinishDate = false;
        public InvoiceListForm()
        {
            InitializeComponent();
        }
        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            this.Hide();
            mainMenu.FormClosed += MainMenu_FormClosed;
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InvoiceRowForm ivf = new InvoiceRowForm(0, this, 0);
            ivf.GetInitialValue();
            FormState.PreviousPage = this;
            ivf.Show();
            this.Hide();          
        }

       

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            BLClient bl = new BLClient();
            BindingList<ClientModel> listClients = bl.GetClientBi("", "", "", null, null, null);
            foreach (ClientModel client in listClients)
            {
                comboBoxFilterClientName.Items.Add(client.ClientName + ' ' + client.ClientSurname);

            }

            this.dateTimePickerStartDate.CustomFormat = " ";
            this.dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerFinishDate.CustomFormat = " ";
            this.dateTimePickerFinishDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.ValueChanged += DateTimePickerStartDate_ValueChanged;
            dateTimePickerStartDate.ShowCheckBox = true;
            dateTimePickerFinishDate.ValueChanged += DateTimePickerFinishDate_ValueChanged;
            dateTimePickerFinishDate.ShowCheckBox = true;

            dataGridViewInvoice.Columns.Add("invoiceId", "invoiceId");
            dataGridViewInvoice.Columns.Add("invoiceNumber", "Numar Factura");
            dataGridViewInvoice.Columns.Add("invoiceDate", "Data Factura");
            dataGridViewInvoice.Columns.Add("clientId", "clientId");
            dataGridViewInvoice.Columns.Add("clientName", "Nume Client");
            dataGridViewInvoice.Columns.Add("clientAddressId", "clientAddressId");
            dataGridViewInvoice.Columns.Add("clientAddress", "Adresa Client");
            dataGridViewInvoice.Columns.Add("userId", "userId");
            dataGridViewInvoice.Columns.Add("invoiceObs", "Observatii");
            dataGridViewInvoice.Columns.Add("invoiceStatus", "invoiceStatus");
            dataGridViewInvoice.AutoGenerateColumns = false;
            dataGridViewInvoice.Columns[0].Visible = false;
            dataGridViewInvoice.Columns[3].Visible = false;
            dataGridViewInvoice.Columns[5].Visible = false;
            dataGridViewInvoice.Columns[7].Visible = false;
            dataGridViewInvoice.Columns[9].Visible = false;

            BLInvoice bliv = new BLInvoice();
            BindingList<InvoiceModel> listInvoice = bliv.BLGetInvoice(null, Convert.ToDateTime("01/01/1980"), Convert.ToDateTime("01/01/3000"), txtNrInvoice.Text, comboBoxFilterClientName.Text);
            foreach(InvoiceModel invoice in listInvoice)
            {
                dataGridViewInvoice.Rows.Add(invoice.invoiceId, invoice.invoiceNumber, invoice.invoiceDate, invoice.clientId, invoice.clientName, invoice.clientAddressId, invoice.clientAddress, invoice.userId, invoice.observations, invoice.status);
            }
            
        }

        private void DateTimePickerFinishDate_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.ShowCheckBox)
            {
                if (dtp.Checked == false)
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtp.Format = DateTimePickerFormat.Short;
                }
            }

            else
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
            if (dtp.Checked)
                checkedFinishDate = true;
            else
                checkedFinishDate = false;


        }

        private void DateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;

            if (dtp.ShowCheckBox)
            {
                if (dtp.Checked == false)
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtp.Format = DateTimePickerFormat.Short;
                }
            }

            else
            {
                dtp.Format = DateTimePickerFormat.Short;
            }

            if (dtp.Checked)
                checkedStartDate = true;
            else
                checkedStartDate = false;

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            if (checkedStartDate)            
                startDate = dateTimePickerStartDate.Value;            
            else
                startDate = Convert.ToDateTime("01/01/1980");

            if (checkedFinishDate)
                endDate = dateTimePickerFinishDate.Value;
            else
                endDate = Convert.ToDateTime("01/01/3000");

            BLInvoice bliv = new BLInvoice();
            BindingList<InvoiceModel> listInvoice = bliv.BLGetInvoice(null, startDate, endDate, txtNrInvoice.Text, comboBoxFilterClientName.Text);
            dataGridViewInvoice.Rows.Clear();
            foreach (InvoiceModel invoice in listInvoice)
            {
                dataGridViewInvoice.Rows.Add(invoice.invoiceId, invoice.invoiceNumber, invoice.invoiceDate, invoice.clientId, invoice.clientName, invoice.clientAddressId, invoice.clientAddress, invoice.userId, invoice.observations, invoice.status);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoice.Rows.Count != 0)
            {
                int i = dataGridViewInvoice.SelectedCells[0].RowIndex;
                int selectedId = Convert.ToInt32(dataGridViewInvoice.Rows[i].Cells[0].Value.ToString());
                dataGridViewInvoice.Rows.RemoveAt(i);
                BLInvoice bl = new BLInvoice();
                bl.BLDeleteInvoice(selectedId);
            }
            else
            {
                MessageBox.Show("Nu se poate sterge nicio factura deoarece nu exista niciuna", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoice.Rows.Count != 0)
            {
                int i = dataGridViewInvoice.SelectedCells[0].RowIndex;
                int selectedInvoiceId = Convert.ToInt32(dataGridViewInvoice.Rows[i].Cells[0].Value.ToString());
                DateTime date = Convert.ToDateTime(dataGridViewInvoice.Rows[i].Cells[2].Value.ToString());

                InvoiceRowForm iv = new InvoiceRowForm(selectedInvoiceId, this, 1);
                iv.InvoicePopulateForm(date);
                iv.GetInitialValue();
                FormState.PreviousPage = this;
                iv.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nu exista nicio factura pentru editare", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }         
            
        }     

        public void UpdateDataGridView(InvoiceModel invoice)
        {
            if (invoice.status == 0)
            {
                dataGridViewInvoice.Rows.Add(invoice.invoiceId, invoice.invoiceNumber, invoice.invoiceDate, invoice.clientId, invoice.clientName, invoice.clientAddressId, invoice.clientAddress, invoice.userId, invoice.observations, invoice.status);
            }
            else if (invoice.status == 1)
            {
                foreach (DataGridViewRow row in dataGridViewInvoice.Rows)
                {
                    if (row.Cells[0].Value.ToString() == invoice.invoiceId.ToString())
                    {
                        row.Cells[0].Value = invoice.invoiceId.ToString();
                        row.Cells[1].Value = invoice.invoiceNumber.ToString();
                        row.Cells[2].Value = invoice.invoiceDate.ToString();
                        row.Cells[3].Value = invoice.clientId.ToString();
                        row.Cells[4].Value = invoice.clientName.ToString();
                        row.Cells[5].Value = invoice.clientAddressId.ToString();
                        row.Cells[6].Value = invoice.clientAddress.ToString();
                        row.Cells[7].Value = invoice.userId.ToString();
                        row.Cells[8].Value = invoice.observations.ToString();
                        row.Cells[9].Value = invoice.status.ToString();

                        break;
                    }
                }
            }
        }
    }
}
