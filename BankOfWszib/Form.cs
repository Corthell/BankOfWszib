using BankOfWszib.Kontroler;
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
    public partial class Form : System.Windows.Forms.Form
    {
        konto kontoUserOwner;

        public Form(uzytkownik user, konto kontoUzytkownika)
        {
            InitializeComponent();
            InicjalizacjaUkladuPaneli();
            lbNazwisko.Text = user.imie + " " + user.nazwisko;
            lbUserID.Text = user.uzytkownikId.ToString();
            lbEmail.Text = user.email;
            userTopBarLb.Text = user.imie + " " + user.nazwisko;
            ostatnieLogowanieLb.Text = DateTime.Now.ToShortDateString();
            nrKontaTB.Text = label3.Text = user.nrRachunku;
            nrRachunkuTb.Text = kwotaPrzelewuTb.Text = "";

            lbSaldoKonta.Text = kontoUzytkownika.saldo.ToString() + " zł";

            kontoUserOwner = kontoUzytkownika;
        }

        private void InicjalizacjaUkladuPaneli()
        {
            przelewPanel.Location = new Point(1500, 0);
            historiaPanel.Location = new Point(1500, 0);
            saldoPanel.Location = new Point(1500, 0);
            saldoPanel.Visible = przelewPanel.Visible = historiaPanel.Visible = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSaldo_Click(object sender, EventArgs e)
        {
            przelewPanel.Location = new Point(1500, 0);
            historiaPanel.Location = new Point(1500, 0);
            saldoPanel.Location = new Point(220, 100);

            using (var context = new DbBankEntities5())
            {
                var kontoSend = context.kontoes.Where(t => t.uzytkownikId == kontoUserOwner.uzytkownikId).SingleOrDefault();

                lbSaldoKonta.Text = kontoSend.saldo.ToString() + " zł";
            }

            lbDolar.Text = KonwerterWalut.konwertuj("d", lbSaldoKonta.Text);
            lbEuro.Text = KonwerterWalut.konwertuj("e", lbSaldoKonta.Text);
            lbFunt.Text = KonwerterWalut.konwertuj("f", lbSaldoKonta.Text);
        }

        private void btPrzelew_Click(object sender, EventArgs e)
        {
            przelewPanel.Location = new Point(220, 100);
            historiaPanel.Location = new Point(1500, 0);
            saldoPanel.Location = new Point(1500, 0);
            przelewGodzinaLb.Text = DateTime.Now.ToString();
        }

        private void btHistoria_Click(object sender, EventArgs e)
        {
            przelewPanel.Location = new Point(1500, 0);
            historiaPanel.Location = new Point(220, 100);
            saldoPanel.Location = new Point(1500, 0);
        }

        private void wyslijPrzelewBt_Click(object sender, EventArgs e)
        {
            konto kontoUpdate = new konto();
            transakcja transakcjaDoZapisu = new transakcja();
            double kwotaPrzelewuInt;

            if (kwotaPrzelewuTb.Text != "" && nrRachunkuTb.Text != "" && Double.TryParse(kwotaPrzelewuTb.Text, out kwotaPrzelewuInt))
            {

                using (var context = new DbBankEntities5())
                {
                    var userRecive = context.uzytkowniks.Where(t => t.nrRachunku == nrRachunkuTb.Text).SingleOrDefault();
                    var kontoSend = context.kontoes.Where(t => t.uzytkownikId == kontoUserOwner.uzytkownikId).SingleOrDefault();

                    if (userRecive != null)
                    {
                        var konto = context.kontoes.Where(t => t.uzytkownikId == userRecive.uzytkownikId).SingleOrDefault();

                        kontoSend.saldo -= kwotaPrzelewuInt;
                        konto.saldo += kwotaPrzelewuInt;
                        context.SaveChanges();

                        transakcjaDoZapisu.uzytkownikId = kontoSend.uzytkownikId;
                        transakcjaDoZapisu.nrOdbiorcy = nrKontaTB.Text;
                        transakcjaDoZapisu.dataPrzelewu = DateTime.Now;
                        transakcjaDoZapisu.miasto = miastoTb.Text;
                        transakcjaDoZapisu.ulica = ulicaTb.Text;
                        transakcjaDoZapisu.nrLokalu = nrLokaluTb.Text;
                        transakcjaDoZapisu.kwotaPrzelewu = kwotaPrzelewuInt;
                        transakcjaDoZapisu.tytulPrzelewu = tytulPrzelewu.Text;

                        context.transakcjas.Add(transakcjaDoZapisu);
                        context.SaveChanges();

                        wymaganePolaLb.Text = "Przelew został wykonany";
                        miastoTb.Text = ulicaTb.Text = nrLokaluTb.Text = nrRachunkuTb.Text = kwotaPrzelewuTb.Text = tytulPrzelewu.Text = "";

                    }
                    else wymaganePolaLb.Text = "Przelew niewykonany. Spróbuj później...";
                }
            }
            else
            {
                wymaganePolaLb.Text = "Wymagane pola: Rachunek odbiorcy i Kwota przelewu";
            }
        }

        private void btOdswiez_Click(object sender, EventArgs e)
        {
            using (var context = new DbBankEntities5())
            {
                var kontoSend = context.kontoes.Where(t => t.uzytkownikId == kontoUserOwner.uzytkownikId).SingleOrDefault();

                lbSaldoKonta.Text = kontoSend.saldo.ToString() + " zł";
            }

            lbDolar.Text = KonwerterWalut.konwertuj("d", lbSaldoKonta.Text);
            lbEuro.Text = KonwerterWalut.konwertuj("e", lbSaldoKonta.Text);
            lbFunt.Text = KonwerterWalut.konwertuj("f", lbSaldoKonta.Text);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dbBankDataSet.transakcja' . Możesz go przenieść lub usunąć.
            this.transakcjaTableAdapter.Fill(this.dbBankDataSet.transakcja);

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }
    }
}
