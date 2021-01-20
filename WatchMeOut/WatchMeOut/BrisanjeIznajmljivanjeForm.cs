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
    public partial class BrisanjeIznajmljivanjeForm : Form
    {
        public BrisanjeIznajmljivanjeForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                IznajmljivanjePoFilmu film = DataProvider.GetIznajmljivanjePoFilmu("Scent of a Woman", "da");

                if (film != null)
                {
                    DataProvider.DeleteIznajmljivanjePoFilmu("Scent of a Woman", "da");

                    MessageBox.Show("Uspesno obrisan iznajmljeni film" +
                        film.nazivFilma);
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
