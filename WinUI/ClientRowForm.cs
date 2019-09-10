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
    public partial class ClientRowForm : Form
    {
        private int clientId;
        private string clientCodeInitial;
        private string clientCodeFinal;
        private ClientsListForm cform;
        private BindingList<ClientAddressModel> listAddress = new BindingList<ClientAddressModel>();
        private string initialName, initialSurname, initialCode, initialPhone, initialEmail;
        private bool changeDataGridView = true;
        private int statusCL;
        
        public ClientRowForm()
        {
            InitializeComponent();
            
        }
        public ClientRowForm(int clientId, ClientsListForm cform, int statusCL)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.cform = cform;
            this.statusCL = statusCL;
        }

        public void GetInitialValue()
        {
            this.initialName = txtClientName.Text;
            this.initialSurname = txtClientSurName.Text;
            this.initialCode = txtClientCode.Text;
            this.initialPhone = txtClientPhone.Text;
            this.initialEmail = txtClientEmail.Text;
        }

        public bool IsModify()
        {
            if (this.initialName != txtClientName.Text)
                return false;
            else if (this.initialCode != txtClientCode.Text)
                return false;
            else if (this.initialSurname != txtClientSurName.Text)
                return false;
            else if (this.initialPhone != txtClientPhone.Text)
                return false;
            else if (this.initialEmail != txtClientEmail.Text)
                return false;
            else if (!this.changeDataGridView)
                return false;            
                return true;
        }


        private bool BaseValidation()
        {
            if (String.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Numele clientului nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtClientSurName.Text))
            {
                MessageBox.Show("Prenumele clientului nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtClientCode.Text))
            {
                MessageBox.Show("Codul clientului nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (checkForEmail(txtClientEmail.Text) == false)
            {
                MessageBox.Show("Te rog sa introduci un email valid", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void SaveClient()
        {
            if (this.clientId == 0)
            {
                int idInserted = 0;

                BLClient bip = new BLClient();
                string info = bip.InsertClientBI(txtClientName.Text, txtClientSurName.Text,
                    txtClientCode.Text, txtClientPhone.Text, txtClientEmail.Text, out idInserted);
                this.clientId = idInserted;

                if (String.IsNullOrEmpty(info))
                {
                    foreach (ClientAddressModel model in listAddress)
                    {
                        model.ClientId = idInserted;
                    }
                    BLClientAddress bla = new BLClientAddress();
                    bla.BIPrepareClientAddress(listAddress);
                    MessageBox.Show("Clientul a fost inserat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show(info, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                bool ok;
                this.clientCodeFinal = txtClientCode.Text;
                if (clientCodeInitial == clientCodeFinal)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }

                BLClient bl = new BLClient();
                string info = bl.BIUpdateClient(txtClientName.Text, txtClientSurName.Text,
                    txtClientCode.Text, txtClientPhone.Text, txtClientEmail.Text, clientId, ok);

                if (String.IsNullOrWhiteSpace(info))
                {
                    BLClientAddress bla = new BLClientAddress();
                    bla.BIPrepareClientAddress(listAddress);
                    MessageBox.Show("Datele clientului au fost modificate cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.clientCodeInitial = this.clientCodeFinal;
                }
                else
                {
                    MessageBox.Show(info, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(BaseValidation() == false)
            {
                return;
            }
            SaveClient();
            GetInitialValue();
            changeDataGridView = true;
           
        }        

        public bool checkForEmail(String email)
        {
            bool ISValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if ((r.IsMatch(email)) || (email == ""))
                ISValid = true;
            return ISValid;
        }

        private void TxtPartnerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            string message = "Apasa DA daca doresti sa salvezi toate modificarile facute. Apasa Nu daca doresti sa nu salvezi nimic";
            string title = "Atentie";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            ClientModel client = new ClientModel()
            {
                ClientId = clientId,
                ClientName = txtClientName.Text,
                ClientSurname = txtClientSurName.Text,
                ClientCode = txtClientCode.Text,
                PhoneNo = txtClientPhone.Text,
                Email = txtClientEmail.Text,
                status = this.statusCL
            };
            if (!IsModify())
            {
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    cform.Show();
                    this.Hide();
                }
                else
                {
                    SaveClient();

                    cform.UpdateClientsDataGridView(client);
                    cform.Show();
                    this.Hide();
                }
            }
            else
            {
                cform.UpdateClientsDataGridView(client);
                cform.Show();
                this.Hide();
            }
        }       

        public void PopulateForm(string clientName, string clientSurname, string clientCode, int clientId)
        {
            
            BLClient bl = new BLClient();
            BindingList<ClientModel> list = bl.GetClientBi(clientName, clientSurname, clientCode, clientId, null, null);
            foreach (ClientModel cm in list)
            {
                txtClientName.Text = cm.ClientName;
                txtClientSurName.Text = cm.ClientSurname;
                txtClientCode.Text = cm.ClientCode;
                txtClientPhone.Text = cm.PhoneNo;
                txtClientEmail.Text = cm.Email;                               
            }            
            this.clientCodeInitial = txtClientCode.Text;
        }           

        private void BtnAddClientAddress_Click(object sender, EventArgs e)
        {          

            ClientAddressForm caaf = new ClientAddressForm(clientId, 0, this, 0);            
            caaf.Show();
            this.Hide();
            FormState.PreviousPage = this;          
           
        }

       

        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            if (dataGridClientAddress.Rows.Count != 0)
            {
                int i = dataGridClientAddress.SelectedCells[0].RowIndex;
                int selectedId = Convert.ToInt32(dataGridClientAddress.Rows[i].Cells[0].Value.ToString());
                ClientAddressModel deleteAddress = new ClientAddressModel()
                {
                    ClientAddressId = selectedId,
                    ClientId = clientId,
                    City = new CityModel
                    {
                        CityId = 0,
                        CityName = dataGridClientAddress.Rows[i].Cells[2].Value.ToString()
                    },
                    County = new CountyModel
                    {
                        CountyId = 0,
                        CountyName = dataGridClientAddress.Rows[i].Cells[3].Value.ToString()
                    },
                    StreetName = dataGridClientAddress.Rows[i].Cells[4].Value.ToString(),
                    StreetNo = dataGridClientAddress.Rows[i].Cells[5].Value.ToString(),
                    status = 2,
                    unique = dataGridClientAddress.Rows[i].Cells[6].Value.ToString(),
                };
                if (listAddress.Count == 0)
                {
                    listAddress.Add(deleteAddress);
                }
                else
                {

                    foreach (ClientAddressModel model in listAddress)
                    {
                        if (model.unique == deleteAddress.unique && model.ClientAddressId != 0)
                        {
                            model.status = 2;
                            break;
                        }
                        else if (model.unique == deleteAddress.unique && model.ClientAddressId == 0)
                        {
                            listAddress.Remove(model);
                            break;
                        }
                        else if (deleteAddress.ClientAddressId != 0)
                        {
                            listAddress.Add(deleteAddress);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                dataGridClientAddress.Rows.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Nu se poate sterge nicio adresa deoarece nu exista vreo adresa", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

        }

        private void DataGridClientAddress_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            changeDataGridView = false;
        }

        private void ClientRowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cform.Show();
            this.Hide();
        }

        private void DataGridClientAddress_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changeDataGridView = false;
        }

        private void BtnEditAddress_Click(object sender, EventArgs e)
        {
            if (dataGridClientAddress.Rows.Count != 0)
            {
                int i = dataGridClientAddress.SelectedCells[0].RowIndex;
                int selectedClientId = Convert.ToInt32(dataGridClientAddress.Rows[i].Cells[1].Value.ToString());
                int selectedClientAddressId = Convert.ToInt32(dataGridClientAddress.Rows[i].Cells[0].Value.ToString());
                string cityName = dataGridClientAddress.Rows[i].Cells[2].Value.ToString();
                string countyName = dataGridClientAddress.Rows[i].Cells[3].Value.ToString();
                string streetName = dataGridClientAddress.Rows[i].Cells[4].Value.ToString();
                string streetNr = dataGridClientAddress.Rows[i].Cells[5].Value.ToString();
                string unique = dataGridClientAddress.Rows[i].Cells[6].Value.ToString();
                ClientAddressForm caaf = new ClientAddressForm(selectedClientId, selectedClientAddressId, this, 1);
                caaf.PopulateFormAddress(cityName, countyName, streetName, streetNr, unique);
                caaf.Show();
                this.Hide();
                FormState.PreviousPage = this;
            }
            else
            {
                MessageBox.Show("Nu se poate edita nicio adresa deoarece nu exista vreo adresa pentru acest client", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }       
              
        }        

        private void ClientAddForm_Load(object sender, EventArgs e)
        {
            if (clientId == 0)
                btnSave.Text = "Salveaza";
            else
                btnSave.Text = "Modifica";

            dataGridClientAddress.Columns.Add("clientAddressId", "clientAddressId");
            dataGridClientAddress.Columns.Add("clientId", "clientId");
            dataGridClientAddress.Columns.Add("cityName", "Oras");
            dataGridClientAddress.Columns.Add("countyName", "Judet");
            dataGridClientAddress.Columns.Add("streetName", "Strada");
            dataGridClientAddress.Columns.Add("streetNo", "Numar");
            dataGridClientAddress.Columns.Add("unique", "Cod Unic");
            dataGridClientAddress.Columns.Add("status", "status");
            dataGridClientAddress.AutoGenerateColumns = false;
            dataGridClientAddress.Columns[0].Visible = false;
            dataGridClientAddress.Columns[1].Visible = false;
            dataGridClientAddress.Columns[6].Visible = false;
            BLClientAddress blca = new BLClientAddress();
            BindingList<ClientAddressModel> list = blca.GetClientAddressBi(clientId, null);
            foreach (ClientAddressModel address in list)
            {
                dataGridClientAddress.Rows.Add(address.ClientAddressId, address.ClientId, address.City.CityName, address.County.CountyName, address.StreetName, address.StreetNo, address.unique, address.status);
            }

        }

        public void UpdateDataGridAddress(ClientAddressModel address, ClientAddressForm ca)
        {
            if (!ca.IsAddedorModify())
            {
                changeDataGridView = false;
            }

            if (address.status == 0)
            {
                dataGridClientAddress.Rows.Add(address.ClientAddressId, address.ClientId, address.City.CityName, address.County.CountyName, address.StreetName, address.StreetNo, address.unique, address.status);
                listAddress.Add(address);
            }else if (address.status == 1)
            {
                foreach (DataGridViewRow row in dataGridClientAddress.Rows)
                {
                    if (row.Cells[6].Value.ToString() == address.unique.ToString() && row.Cells[0].Value.ToString() == address.ClientAddressId.ToString())
                    {
                        row.Cells[2].Value = address.City.CityName.ToString();
                        row.Cells[3].Value = address.County.CountyName.ToString();
                        row.Cells[4].Value = address.StreetName.ToString();
                        row.Cells[5].Value = address.StreetNo.ToString();                       

                        bool verifyList = listAddress.Any(item => item.unique == address.unique && item.ClientAddressId == address.ClientAddressId);
                        if (!verifyList)
                            listAddress.Add(address);
                        else
                        {
                            foreach (ClientAddressModel model in listAddress)
                            {
                                if (model.unique == address.unique && model.ClientAddressId == address.ClientAddressId)
                                {
                                    model.City.CityName = address.City.CityName;
                                    model.County.CountyName = address.County.CountyName;
                                    model.StreetName = address.StreetName;
                                    model.StreetNo = address.StreetNo;                              

                                    break;
                                }
                            }
                        }


                        break;
                    }
                }
            }
        }
    }
}
