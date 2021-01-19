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
    public partial class BrisanjeFilmaForm : Form
    {
        public BrisanjeFilmaForm()
        {
            InitializeComponent();
            txtSifra.PasswordChar = '*';
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text == "admin")
            {
                Film film = DataProvider.GetFilm("3");

                if (film != null)
                {
                    DataProvider.DeleteFilm("3");

                    MessageBox.Show("Uspesno obrisan film " + film.nazivFilma + " iz " + film.godina + ". godine");
                }
                else
                {
                    MessageBox.Show("U bazi ne postoji film sa id-jem 3!!");
                    this.Close();
                    return;
                }
            }
            else
                MessageBox.Show("Brisanje niije moguce, ovo moze da uradi samo administrator!");

            txtSifra.Text = "";
            this.Close();
        }
    }
}
