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
    public partial class BrisanjeTrenutnoForm : Form
    {
        public BrisanjeTrenutnoForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                TrenutnoIznajmljeni film = DataProvider.GetTrenutnoIznajmljeni("Milan Milanovic", "ne");

                if (film != null)
                {
                    DataProvider.DeleteTrenutnoIznajmljeni("Milan Milanovic", "ne");

                    MessageBox.Show("Uspesno obrisan trenutno iznajmljeni kod korisnika" + 
                        film.korisnik);
                }
                else
                {
                    MessageBox.Show("Nije pronadjeno u bazi!");
                    this.Close();
                    return;
                }
            }
            else
                MessageBox.Show("Brisanje niije moguce, ovo moze da uradi samo administrator!");

            textBox1.Text = "";
            this.Close();
        }
    }
}
