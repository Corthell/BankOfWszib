using BankOfWszib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankOfWszib
{
    public partial class LoginScreen : System.Windows.Forms.Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            RegistrationScreen rs = new RegistrationScreen();
            rs.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {
            errorMessage.Text = "";
            
            log lastLogin = new log();
            uzytkownik logedUser = new uzytkownik();
            konto kontoUzytkownika = new konto();
            bool access = false;
            using (var context = new DbBankEntities5())
            {
                var user = context.uzytkowniks.Where(t => t.login == login.Text).SingleOrDefault();

                if (user != null)
                {
                    if(user.haslo == haslo.Text && user.status == true)
                    {
                        var saldo = context.kontoes.Where(t => t.uzytkownikId == user.uzytkownikId).SingleOrDefault();

                        access = true;
                        logedUser = user;
                        kontoUzytkownika = saldo;

                        lastLogin.uzytkownikId = user.uzytkownikId;
                        lastLogin.dataLogowania = DateTime.Now;
                        context.logs.Add(lastLogin);
                        context.SaveChanges();

                    }
                }
            }

            if (access)
            {
                this.WindowState = FormWindowState.Minimized;
                Form start = new Form(logedUser, kontoUzytkownika);
                start.Show();
            }
            else
            {
                errorMessage.Text = "Nieprawidłowy login lub hasło!";
                login.Text = haslo.Text = "";
            }
                
        }
    }
}
