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
    public partial class ClientsListForm : Form
    {
        private int skip_page = 0;
        private int take_page = 10;
        private int total_page = 0;
        private int currentpage = 1;
        private int total_row;
        private int final_page;

        public ClientsListForm()
        {
            InitializeComponent();
        }       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClientRowForm paf = new ClientRowForm(0, this, 0);
            paf.GetInitialValue();
            FormState.PreviousPage = this;
            paf.Show();
            this.Hide();                  
        }

        

        private void PartnersForm_Load(object sender, EventArgs e)
        {
            dataPartners.Columns.Add("clientId", "clientId");
            dataPartners.Columns.Add("clientName", "Nume");
            dataPartners.Columns.Add("clientSurname", "Prenume");
            dataPartners.Columns.Add("clientCode", "Cod Client");
            dataPartners.Columns.Add("phoneNo", "Telefon");
            dataPartners.Columns.Add("clientEmail", "Email");
            dataPartners.AutoGenerateColumns = false;
            dataPartners.Columns[0].Visible = false;
            BLClient bl = new BLClient();
            this.total_row = bl.BLGetTotalRow("", "", "");
            this.total_page = (this.total_row / this.take_page) + 1;
            this.final_page = this.total_row % this.take_page;
            PaginationDataGridView();          

        }

        private void PaginationDataGridView()
        {
            BLClient bl = new BLClient();
            BindingList<ClientModel> list = bl.GetClientBi(txtName.Text, txtSurName.Text, txtClientCode.Text, null, skip_page, take_page);

            foreach (ClientModel client in list)
            {
                dataPartners.Rows.Add(client.ClientId, client.ClientName, client.ClientSurname, client.ClientCode, client.PhoneNo, client.Email);
            }

            lblPage.Text = this.currentpage.ToString() + "/" + this.total_page.ToString();
            txtTotalPage.Text = this.total_page.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mmf = new MainMenuForm();
            mmf.Show();
            this.Hide();
            mmf.FormClosed += Mmf_FormClosed;
        }

        private void Mmf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            BLClient bl = new BLClient();
            this.total_row = bl.BLGetTotalRow(txtName.Text, txtSurName.Text, txtClientCode.Text);
            this.total_page = (this.total_row / this.take_page) + 1;
            this.final_page = this.total_row % this.take_page;
            dataPartners.Rows.Clear();
            this.currentpage = 1;
            this.skip_page = 0;
            PaginationDataGridView();
        }       

        private void BtnDelete_Click(object sender, EventArgs e)        {
            if (dataPartners.Rows.Count != 0)
            {
                int i = dataPartners.SelectedCells[0].RowIndex;
                int selectedId = Convert.ToInt32(dataPartners.Rows[i].Cells[0].Value.ToString());
                BLClient bl = new BLClient();
                string message = bl.DeleteClient(selectedId);
                if (String.IsNullOrWhiteSpace(message))
                {
                    dataPartners.Rows.RemoveAt(i);
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Nu se poate sterge niciun client deoarece nu exista.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataPartners.Rows.Count != 0)
            {
                int i = dataPartners.SelectedCells[0].RowIndex;
                int selectedId = Convert.ToInt32(dataPartners.Rows[i].Cells[0].Value.ToString());

                ClientRowForm caf = new ClientRowForm(selectedId, this, 1);
                caf.PopulateForm("", "", "", selectedId);
                caf.GetInitialValue();
                FormState.PreviousPage = this;
                caf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nu se poate edita niciun client deoarece nu exista vreun client", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }
       
        public void UpdateClientsDataGridView (ClientModel client)
        {
            if (client.status == 0)
            {
                dataPartners.Rows.Add(client.ClientId, client.ClientName, client.ClientSurname, client.ClientCode, client.PhoneNo, client.Email);
            }
            else if (client.status == 1)
            {
                foreach (DataGridViewRow row in dataPartners.Rows)
                {
                    if (row.Cells[0].Value.ToString() == client.ClientId.ToString())
                    {
                        row.Cells[0].Value = client.ClientId.ToString();
                        row.Cells[1].Value = client.ClientName.ToString();
                        row.Cells[2].Value = client.ClientSurname.ToString();
                        row.Cells[3].Value = client.ClientCode.ToString();
                        row.Cells[4].Value = client.PhoneNo.ToString();
                        row.Cells[5].Value = client.Email.ToString();                        
                        break;
                    }
                }
            }
        }        

        private void BtnGoNext_Click(object sender, EventArgs e)
        {
            
            if (this.currentpage == this.total_page)
            {
                MessageBox.Show("Nu mai exista o alta pagina", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else {
                this.skip_page += this.take_page;
                this.currentpage++;
                dataPartners.Rows.Clear();
                lblPage.Text = this.currentpage.ToString() + "/" + this.total_page.ToString();
                PaginationDataGridView();
            }
        }

        private void BtnGoPrevious_Click(object sender, EventArgs e)
        {
            
            if (this.currentpage == 1)
            {
                MessageBox.Show("Nu mai exista o alta pagina", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.skip_page -= this.take_page;
                this.currentpage--;
                dataPartners.Rows.Clear();
                lblPage.Text = this.currentpage.ToString() + "/" + this.total_page.ToString();
                PaginationDataGridView();
            }
        }

        private void BtnGoFirst_Click(object sender, EventArgs e)
        {
            this.skip_page = 0;
            this.currentpage = 1;
            dataPartners.Rows.Clear();
            lblPage.Text = this.currentpage.ToString() + "/" + this.total_page.ToString();
            PaginationDataGridView();
        }

        private void BtnGoLast_Click(object sender, EventArgs e)
        {
            this.skip_page = (this.total_page-1) * this.take_page;
            this.currentpage = this.total_page;
            dataPartners.Rows.Clear();
            lblPage.Text = this.currentpage.ToString() + "/" + this.total_page.ToString();
            PaginationDataGridView();
        }

        private void TxtTotalPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                if (e.KeyChar == (char)13)
                {                  
                    
                        this.currentpage = Convert.ToInt32(txtTotalPage.Text);
                        this.skip_page = (this.currentpage - 1) * take_page;
                        dataPartners.Rows.Clear();
                        lblPage.Text = this.currentpage.ToString() + "/" + this.total_page.ToString();
                        PaginationDataGridView();
                        txtTotalPage.Text = this.currentpage.ToString();

                    
                }
            }
        }
    }
}
