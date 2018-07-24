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
    public partial class RegistrationScreen : System.Windows.Forms.Form
    {
        public RegistrationScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btZarejestruj_Click(object sender, EventArgs e)
        {
            btZarejestruj.Enabled = true;

            if (imie.Text != "" && nazwisko.Text != "" && miasto.Text != "" && nrLokalu.Text != "" && pesel.Text != "")
            {
                uzytkownik user = new uzytkownik();
                konto kontoUser = new konto();
                Random r = new Random();
                int random = r.Next(100, 999);

                user.login = login.Text;
                user.imie = imie.Text;
                user.nazwisko = nazwisko.Text;
                user.haslo = haslo.Text;
                user.miasto = miasto.Text;
                user.ulica = ulica.Text;
                user.nrLokalu = nrLokalu.Text;
                user.telefon = telefon.Text;
                user.pesel = pesel.Text;
                user.email = email.Text;

                user.nrRachunku = random.ToString() + pesel.Text;
                user.status = true;

                using (var context = new DbBankEntities5())
                {
                    context.uzytkowniks.Add(user);
                    context.SaveChanges();

                    var varKonto = context.uzytkowniks.Where(t => t.login == login.Text).SingleOrDefault();

                    kontoUser.uzytkownikId = varKonto.uzytkownikId;
                    kontoUser.saldo = 0;

                    context.kontoes.Add(kontoUser);
                    context.SaveChanges();

                    login.Text = imie.Text = nazwisko.Text = haslo.Text = miasto.Text = ulica.Text = nrLokalu.Text = telefon.Text = pesel.Text = email.Text = "";

                    infoRejestracjaLb.Text = "Zarejestrowano użytkownika";
                    btZarejestruj.Enabled = false;
                }

            }
            else MessageBox.Show("Uzupełnij brakujące pola!", "Niekompletne dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login.Text = "tbala";
            imie.Text = "Tomek";
            nazwisko.Text = "Bała";
            haslo.Text = "q1w2";
            miasto.Text = "Balice";
            ulica.Text = "Jagodowa";
            nrLokalu.Text = "622";
            telefon.Text = "505509112";
            pesel.Text = "88031218892";
            email.Text = "tomek.bala@gmail.com";
        }
    }
}
