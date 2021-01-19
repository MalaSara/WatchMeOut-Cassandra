using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchMeOutLibrary;
using WatchMeOutLibrary.Tabele;

namespace WatchMeOut
{
    public partial class BrisanjeKorisnikaForm : Form
    {
        public BrisanjeKorisnikaForm()
        {
            InitializeComponent();
            txtSifra.PasswordChar = '*';
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text == "admin")
            {
                Korisnik k = DataProvider.GetKorisnik("1");
                if (k != null)
                {
                    DataProvider.DeleteKorisnik("1");

                    MessageBox.Show("Uspesno obrisan korisnik " + k.ime + k.prezime);
                }
                else
                {
                    MessageBox.Show("U bazi ne postoji korisnik sa id-jem 1!!");
                    this.Close();
                    return;
                }
            }
            else
                MessageBox.Show("Brisanje nije moguce, ovo moze da uradi samo administrator!");

            txtSifra.Text = "";

            this.Close();
        }
    }
}
