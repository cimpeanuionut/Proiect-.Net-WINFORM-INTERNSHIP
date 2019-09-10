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
    public partial class LoginForm : Form
    {
        public static int id;
        public LoginForm()
        {
            InitializeComponent();
            
        }
       

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Parola nu este completata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            BLLogin bl = new BLLogin();
            UserModel user = bl.CheckUser(txtUserName.Text, txtPassword.Text, out int status);
            id = user.UserId;

            if (status == 2)
            {                
                MainMenuForm mainMenu = new MainMenuForm();                
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;

            }

            else
            {
                if (status == 0)
                {
                    MessageBox.Show("Parola introdusa este incorecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();

                    return;
                }
                else
                {
                    MessageBox.Show("Username-ul introdus este gresit", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    return;
                }
            }
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }        
        
    }
}
