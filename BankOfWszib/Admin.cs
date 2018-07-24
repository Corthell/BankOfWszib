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
    public partial class Admin : System.Windows.Forms.Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {
            if(login.Text != "" && haslo.Text != "" && haslo.Text == "wszib2018")
            {
                if(bunifuSwitch1.Value == false)
                {
                    using (var context = new DbBankEntities5())
                    {
                        var user = context.uzytkowniks.Where(t => t.login == login.Text).SingleOrDefault();

                        if (user != null)
                        {
                            user.status = false;
                            context.SaveChanges();
                            infoAdminLb.Text = "Użytkownik został zablokowany";
                        }
                        else
                        {
                            infoAdminLb.Text = "Operacja nie powiadła sie";
                        }

                    }
                }
                else
                {
                    using (var context = new DbBankEntities5())
                    {
                        var user = context.uzytkowniks.Where(t => t.login == login.Text).SingleOrDefault();

                        if (user != null)
                        {
                            user.status = true;
                            context.SaveChanges();
                            infoAdminLb.Text = "Użytkownik został odblokowany";
                        }
                        else
                        {
                            infoAdminLb.Text = "Operacja nie powiadła sie";
                        }

                    }
                }
            }
            else infoAdminLb.Text = "Błędne dane w formularzu";
        }
    }
}
