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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DodajMilanaMilanovica_Click(object sender, EventArgs e)
        {
            DataProvider.AddKorisnik("1", "Da", "Milan", "Milanovic", "066-9895999", "Bulevar Nemanjica 23/23", "Ne", "Da", "0", "Akcija", "1");
        }

        private void DodajSanjaDjordjevic_Click(object sender, EventArgs e)
        {
            DataProvider.AddKorisnik("2", "Ne", "Sanja", "Djordjevic", "065-9225999", "7.Juli 22", "Da", "Ne", "1", "Komedija", "2");

        }

        private void DodajAnaKrstic_Click(object sender, EventArgs e)
        {
            DataProvider.AddKorisnik("3", "Ne", "Ana", "Krstic", "062-2323001", "Bozidarceva 11", "Da", "Ne", "2", "Romantika", "-");

        }

        private void VratiKorisnike_Click(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = DataProvider.GetKorisnici();
            foreach( Korisnik k in korisnici)
            {
                MessageBox.Show(k.ime + k.prezime + k.idDoniranogFilma);
            }
        }

        private void ObrisiKorisnika_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteKorisnik("1", "1");
        }

        private void VratiSanjinOmiljeniZanr_Click_1(object sender, EventArgs e)
        {
            Korisnik k = DataProvider.GetKorisnik("Sanja");
            MessageBox.Show(k.omiljeniZanr);
        }
    }
}
