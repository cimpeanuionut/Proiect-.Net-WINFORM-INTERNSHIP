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
    public partial class InvoiceRowForm : Form
    {        
        BindingList<ClientModel> listClients;
        private int invoiceIdSelected;
        private BindingList<InvoiceDetailModel> listDetail = new BindingList<InvoiceDetailModel>();
        private InvoiceListForm iform;

        private string initialivNr;
        private DateTime initialDate;
        private string initialName;
        private string initialAddress;
        private string initialObs;     
        private bool changeDataGridView = true;
        private int statusInv;
        public InvoiceRowForm()
        {
            InitializeComponent();
        }
        public InvoiceRowForm(int selectedId, InvoiceListForm iform, int statusInv)
        {
            InitializeComponent();
            this.invoiceIdSelected = selectedId;
            this.iform = iform;
            this.statusInv = statusInv;
        }  
        
        public void GetInitialValue()
        {
            this.initialivNr = txtNrInvoice.Text;
            this.initialDate = dateTimePickerInvoiceDate.Value;
            this.initialName = comboBoxClientName.Text;
            this.initialAddress = comboBoxClientAddress.Text;
            this.initialObs = txtObs.Text;            
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            string message = "Apasa DA daca doresti sa salvezi toate modificarile facute. Apasa Nu daca doresti sa nu salvezi nimic";
            string title = "Atentie";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            InvoiceModel invoice = new InvoiceModel()
            {
                invoiceId = invoiceIdSelected,
                invoiceNumber = txtNrInvoice.Text,
                invoiceDate = dateTimePickerInvoiceDate.Value,
                clientId = 0,
                clientName = comboBoxClientName.Text,
                clientAddressId = 0,
                clientAddress = comboBoxClientAddress.Text,
                userId = LoginForm.id,
                observations = txtObs.Text,
                status = this.statusInv
            };
            if (!IsModify())
            {
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    iform.Show();
                    this.Hide();
                }
                else
                {
                    if (BasicValidation() == false)
                    {
                        return;
                    }
                    SaveInvoice();

                    iform.UpdateDataGridView(invoice);
                    iform.Show();
                    this.Hide();
                }
            }
            else
            {
                iform.UpdateDataGridView(invoice);
                iform.Show();
                this.Hide();
            }
        }

        private bool IsModify()
        {
            if (initialivNr != txtNrInvoice.Text)
                return false;
            else if (initialDate != dateTimePickerInvoiceDate.Value)
                return false;
            else if (initialName != comboBoxClientName.Text)
                return false;
            else if (initialAddress != comboBoxClientAddress.Text)
                return false;
            else if (initialObs != txtObs.Text)
                return false;
            else if (!changeDataGridView)
                return false;
            else
                return true;
        }   

        public void SaveInvoice()
        {
            if (invoiceIdSelected == 0)
            {
                LoginForm lf = new LoginForm();
                BLInvoice bl = new BLInvoice();
                invoiceIdSelected = bl.BLInsertInvoice(txtNrInvoice.Text, dateTimePickerInvoiceDate.Value, comboBoxClientName.Text,
                                    comboBoxClientAddress.Text, LoginForm.id, txtObs.Text);
                foreach (InvoiceDetailModel detail in listDetail)
                {
                    detail.invoiceId = invoiceIdSelected;
                }
                BLInvoiceDetail bli = new BLInvoiceDetail();
                bli.BLPrepareInvoiceDetail(listDetail);
                MessageBox.Show("Factura a fost adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                BLInvoice bl = new BLInvoice();
                bl.BLUpdateInvoice(invoiceIdSelected, txtNrInvoice.Text, dateTimePickerInvoiceDate.Value, txtObs.Text, comboBoxClientName.Text, comboBoxClientAddress.Text);
                BLInvoiceDetail bli = new BLInvoiceDetail();
                bli.BLPrepareInvoiceDetail(listDetail);
                MessageBox.Show("Factura a fost modificata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BasicValidation() == false)
            {
                return;
            }
            SaveInvoice();
            GetInitialValue();
            changeDataGridView = true;


        }

        private bool BasicValidation()
        {
            if (String.IsNullOrWhiteSpace(txtNrInvoice.Text))
            {
                MessageBox.Show("Numarul de factura este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrWhiteSpace(dateTimePickerInvoiceDate.Value.ToString()))
            {
                MessageBox.Show("Data pentru factura este obligatorie", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrWhiteSpace(comboBoxClientName.Text))
            {
                MessageBox.Show("Numele clientului este obligatoriu", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrWhiteSpace(comboBoxClientAddress.Text))
            {
                MessageBox.Show("Adresa clientului este obligatorie", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void InvoiceAddForm_Load(object sender, EventArgs e)
        {
            if (invoiceIdSelected == 0)
                btnSave.Text = "Salveaza";
            else
                btnSave.Text = "Modifica";
            BLClient bl = new BLClient();
            listClients = bl.GetClientBi("", "", "", null, null, null);
            foreach(ClientModel client in listClients)
            {
                comboBoxClientName.Items.Add(client.ClientName + ' ' + client.ClientSurname);
                              
            }

            dataGridViewItems.Columns.Add("invoiceDetailId", "invoiceDetailId");
            dataGridViewItems.Columns.Add("invoiceId", "invoiceId");
            dataGridViewItems.Columns.Add("itemId", "itemId");
            dataGridViewItems.Columns.Add("itemName", "Nume Articol");
            dataGridViewItems.Columns.Add("qtty", "Cantitate");
            dataGridViewItems.Columns.Add("price", "Pret");
            dataGridViewItems.Columns.Add("amount", "Valoare");
            dataGridViewItems.Columns.Add("observation", "Observatii");
            dataGridViewItems.Columns.Add("status", "Status");
            dataGridViewItems.Columns.Add("Unique", "Codul Unic");

            dataGridViewItems.Columns[0].Visible = false;
            dataGridViewItems.Columns[1].Visible = false;
            dataGridViewItems.Columns[2].Visible = false;
            dataGridViewItems.Columns[9].Visible = false;

            BLInvoiceDetail blid = new BLInvoiceDetail();
            BindingList<InvoiceDetailModel> list = blid.BLGetInvoiceDetail(invoiceIdSelected, null);
            foreach (InvoiceDetailModel detail in list)
            {
                dataGridViewItems.Rows.Add(detail.invoiceDetailId, detail.invoiceId, detail.itemId, detail.itemName, detail.qtty, detail.price, detail.amount, detail.observation, detail.status, detail.unique);
            }
        }

        private void ComboBoxClientName_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = 0;
            comboBoxClientAddress.Items.Clear();
            comboBoxClientAddress.Text = "";
            foreach (ClientModel client in listClients)
            {
                if (comboBoxClientName.Text == client.ClientName + ' ' + client.ClientSurname)
                {
                    id = client.ClientId;
                    break;
                }
            }         
            BLClientAddress bla = new BLClientAddress();
            BindingList<ClientAddressModel> listAddress = bla.GetClientAddressBi(id, null);

            foreach (ClientAddressModel clientAddress in listAddress)
            {
                comboBoxClientAddress.Items.Add(clientAddress.StreetName + ' ' + clientAddress.StreetNo + ' '
                + clientAddress.City.CityName + ' ' + clientAddress.County.CountyName);
            }            
        }   
        
        public void InvoicePopulateForm( DateTime date)
        {
            BLInvoice bl = new BLInvoice();
            BindingList<InvoiceModel> list = bl.BLGetInvoice(invoiceIdSelected, date, date, "", "");
            foreach(InvoiceModel invoice in list)
            {
                txtNrInvoice.Text = invoice.invoiceNumber;
                dateTimePickerInvoiceDate.Value = invoice.invoiceDate;
                comboBoxClientName.Text = invoice.clientName;
                comboBoxClientAddress.Text = invoice.clientAddress;
                txtObs.Text = invoice.observations;
            }            
                      
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            InvoiceDetailForm iva = new InvoiceDetailForm(invoiceIdSelected, 0, this, 0);
            iva.Show();
            this.Hide();
           
        }       

        public void AddItemToDataGridViewAndList(InvoiceDetailForm iva)
        {
            InvoiceDetailModel detail = iva.GetInvoiceDetail();
            if (!iva.IsAddedorModify())
            {
                changeDataGridView = false;
            }
            if (detail.status == 0)
            {
                dataGridViewItems.Rows.Add(detail.invoiceDetailId, detail.invoiceId, detail.itemId, detail.itemName, detail.qtty, detail.price, detail.amount, detail.observation, detail.status, detail.unique);
                listDetail.Add(detail);
            }
            else if (detail.status == 1)
            {
                foreach(DataGridViewRow row in dataGridViewItems.Rows)
                {
                    if(row.Cells[9].Value.ToString() == detail.unique.ToString() && row.Cells[0].Value.ToString() == detail.invoiceDetailId.ToString())
                    {
                        row.Cells[2].Value = detail.itemId.ToString();
                        row.Cells[3].Value = detail.itemName.ToString();
                        row.Cells[4].Value = detail.qtty.ToString();
                        row.Cells[5].Value = detail.price.ToString();
                        row.Cells[6].Value = detail.amount.ToString();
                        row.Cells[7].Value = detail.observation.ToString();
                        row.Cells[8].Value = detail.status.ToString();

                        bool verifyList = listDetail.Any(item => item.unique == detail.unique && item.invoiceDetailId == detail.invoiceDetailId);
                        if(!verifyList)
                        listDetail.Add(detail);
                        else
                        {
                            foreach( InvoiceDetailModel model in listDetail)
                            {
                                if (model.unique == detail.unique && model.invoiceDetailId == detail.invoiceDetailId)
                                {
                                    model.itemId = detail.itemId;
                                    model.itemName = detail.itemName;
                                    model.qtty = detail.qtty;
                                    model.price = detail.price;
                                    model.amount = detail.amount;
                                    model.observation = detail.observation;

                                    break;
                                }
                            }
                        }

                       
                        break;
                    }
                }                
                
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.Rows.Count != 0)
            {
                int i = dataGridViewItems.SelectedCells[0].RowIndex;
                int selectedInvoiceDetailId = Convert.ToInt32(dataGridViewItems.Rows[i].Cells[0].Value.ToString());
                InvoiceDetailForm iaif = new InvoiceDetailForm(invoiceIdSelected, selectedInvoiceDetailId, this, 1);
                string selectedItemName = dataGridViewItems.Rows[i].Cells[3].Value.ToString();
                decimal selectedQtty = Convert.ToDecimal(dataGridViewItems.Rows[i].Cells[4].Value.ToString());
                decimal selectedPrice = Convert.ToDecimal(dataGridViewItems.Rows[i].Cells[5].Value.ToString());
                decimal selectedAmount = Convert.ToDecimal(dataGridViewItems.Rows[i].Cells[6].Value.ToString());
                string unique = dataGridViewItems.Rows[i].Cells[9].Value.ToString();
                string selectedObs = dataGridViewItems.Rows[i].Cells[7].Value.ToString();
                iaif.PopulareInvoiceAddItemForm(selectedItemName, selectedQtty, selectedPrice, selectedAmount, selectedObs, unique);
                iaif.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nu poate fi editat niciun detaliu de factura deoarece nu exista niciunul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          

        }       

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.Rows.Count != 0)
            {
                int i = dataGridViewItems.SelectedCells[0].RowIndex;
                int selectedInvoiceDetailId = Convert.ToInt32(dataGridViewItems.Rows[i].Cells[0].Value.ToString());
                InvoiceDetailModel iv = new InvoiceDetailModel()
                {
                    invoiceDetailId = selectedInvoiceDetailId,
                    invoiceId = invoiceIdSelected,
                    itemId = Convert.ToInt32(dataGridViewItems.Rows[i].Cells[2].Value.ToString()),
                    itemName = dataGridViewItems.Rows[i].Cells[3].Value.ToString(),
                    qtty = Convert.ToDecimal(dataGridViewItems.Rows[i].Cells[4].Value.ToString()),
                    price = Convert.ToDecimal(dataGridViewItems.Rows[i].Cells[5].Value.ToString()),
                    amount = Convert.ToDecimal(dataGridViewItems.Rows[i].Cells[6].Value.ToString()),
                    observation = dataGridViewItems.Rows[i].Cells[7].Value.ToString(),
                    status = 2,
                    unique = dataGridViewItems.Rows[i].Cells[9].Value.ToString()
                };

                if (listDetail.Count == 0)
                {
                    listDetail.Add(iv);
                }
                else
                {

                    foreach (InvoiceDetailModel model in listDetail)
                    {
                        if (model.unique == iv.unique && model.invoiceDetailId != 0)
                        {
                            model.status = 2;
                            break;
                        }
                        else if (model.unique == iv.unique && model.invoiceDetailId == 0)
                        {
                            listDetail.Remove(model);
                            break;
                        }
                        else if (iv.invoiceDetailId != 0)
                        {
                            listDetail.Add(iv);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                dataGridViewItems.Rows.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Nu se poate sterge niciun detaliu de factura deoarece nu exista niciunul", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }        

        private void DataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changeDataGridView = false;
        }
       

        private void DataGridViewItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changeDataGridView = false;
        }

        private void InvoiceRowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            iform.Show();
            this.Hide();
        }
        
    }
}
