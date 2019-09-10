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
    public partial class ClientAddressForm : Form
    {
        private int addressId;
        private int clientId;
        private ClientRowForm cAddForm;
        private int status;
        private ClientAddressModel address = new ClientAddressModel();
        private bool isAdded = true;
        private string unique = "";
        public ClientAddressForm()
        {
            InitializeComponent();
        }

        public ClientAddressForm(int clientId, int addressId, ClientRowForm cAddForm, int status)
        {
            InitializeComponent();            
            this.clientId = clientId;
            this.addressId = addressId;
            this.cAddForm = cAddForm;
            this.status = status;
        }

        public ClientAddressForm(int clientId)
        {
            InitializeComponent();            
            this.clientId = clientId;
        }
        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (BasicValidationAddress() == false)
            {
                return;
            }

            address.ClientId = this.clientId;
            address.ClientAddressId = this.addressId;
            address.City = new CityModel
            {
                CityId = 0,
                CityName = comboCity.Text
            };
            address.County = new CountyModel
            {
                CountyId = 0,
                CountyName = comboDistrict.Text
            };
            address.StreetName = txtStreet.Text;
            address.StreetNo = txtNumber.Text;
            address.status = this.status;
            if(this.unique == "")
            {
                address.unique = address.RandomString(8);
            }
            else
            {
                address.unique = this.unique;
            }
            isAdded = false;
            cAddForm.UpdateDataGridAddress(address, this);           
            cAddForm.Show();            
            this.Hide();
           

        }

        public bool IsAddedorModify()
        {
            return isAdded;
        }
       

        private void ClientAddressAddForm_Load(object sender, EventArgs e)
        {            
           
            if (status == 0)
            {
                btnSave.Text = "Salveaza";
            }
            else
            {
                btnSave.Text = "Modifica";
            }

            BLClientAddress blac = new BLClientAddress();
            BindingList<CityModel> citylist = blac.GetCityBi();

            for (int i = 0; i < citylist.Count; i++)
            {
                comboCity.Items.Add(citylist[i].CityName);
            }

            BindingList<CountyModel> countylist = blac.GetCountyBi();

            for (int i=0; i<countylist.Count; i++)
            {
                comboDistrict.Items.Add(countylist[i].CountyName);
            }            
        }

        private bool BasicValidationAddress()
        {
            if (String.IsNullOrWhiteSpace(comboCity.Text))
            {
                MessageBox.Show("Orasul trebuie completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrWhiteSpace(comboDistrict.Text))
            {
                MessageBox.Show("Judetul trebuie completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }       
               

        public void PopulateFormAddress(string cityName, string countyName, string street, string nr, string unique)
        {
            comboCity.Text = cityName;
            comboDistrict.Text = countyName;
            txtStreet.Text = street;
            txtNumber.Text = nr;
            this.unique = unique;

        }

        private void ClientAddressAddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cAddForm.Show();
            this.Hide();
        }
    }
}
