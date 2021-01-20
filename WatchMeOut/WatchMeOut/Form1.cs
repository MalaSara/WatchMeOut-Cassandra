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
            foreach (Korisnik k in korisnici)
            {
                MessageBox.Show(k.ime + k.prezime + k.idDoniranogFilma);
            }
        }

        private void ObrisiKorisnika_Click(object sender, EventArgs e)
        {
            BrisanjeKorisnikaForm admin = new BrisanjeKorisnikaForm();
            admin.ShowDialog();
        }

        private void VratiSanjinOmiljeniZanr_Click_1(object sender, EventArgs e)
        {
            Korisnik k = DataProvider.GetKorisnik("2");
            MessageBox.Show(k.omiljeniZanr);
        }

        private void btnDodajScentOfAWoman_Click(object sender, EventArgs e)
        {
            DataProvider.AddFilm("1", "2.46", "Scent of a Woman", "Drama", "1992", "Engleski", "SAD", "1", "2", "Al Pacino, Chris O Donnell");
        }

        private void btnVratiFilmove_Click_1(object sender, EventArgs e)
        {
            List<Film> filmovi = DataProvider.GetFilmovi();

            foreach (Film film in filmovi)
            {
                MessageBox.Show(film.nazivFilma + "\t" + film.godina + "\t" + film.glavniGlumci + "\n");
            }
        }

        private void btnDodajModigliani_Click(object sender, EventArgs e)
        {
            DataProvider.AddFilm("2", "2.08", "Modigliani", "Biografija, Drama", "2004", "Engleski", "UK, Nemacka, Rumunija, Francuska, Italija", "2", "5", "Andy Garcia, Elsa Zylberstein");
        }

        private void btnDodajTheAgeOfAdaline_Click(object sender, EventArgs e)
        {
            DataProvider.AddFilm("3", "1.52", "The Age of Adaline", "Drama, Fantazija, Romansa", "2015", "Engleski, Portugalski, Italijanski", "SAD, Kanada", "3", "4", "Blake Lively, Michiel Huisman, Harrison Ford");
        }

        private void btnObrisiFilm_Click(object sender, EventArgs e)
        {
            BrisanjeFilmaForm admin = new BrisanjeFilmaForm();
            admin.ShowDialog();
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            DataProvider.AddTrenutnoIznajmljeni("Milan Milanovic", "The Age of Adaline", "15.1.2021.", "25.1.2021.", "ne");
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            DataProvider.AddTrenutnoIznajmljeni("Ana Krstic", "Scent of a Woman", "17.1.2021.", "27.1.2021.", "ne");
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            DataProvider.AddTrenutnoIznajmljeni("Sanja Djordjevic", "Modigliani", "7.1.2021.", "17.1.2021.", "da");
        }

        private void btnVratiT_Click(object sender, EventArgs e)
        {
            List<TrenutnoIznajmljeni> iznajmljeni = DataProvider.GetTrenutnoIznajmljeni();

            foreach (TrenutnoIznajmljeni iznajmljen in iznajmljeni)
            {
                MessageBox.Show(iznajmljen.korisnik + "\t" + iznajmljen.film + "\t" + iznajmljen.od
                    + "\t" + iznajmljen.Do + "\t" + iznajmljen.vraceno + "\n");
            }
        }

        private void btnObrisiT_Click(object sender, EventArgs e)
        {
            BrisanjeTrenutnoForm admin = new BrisanjeTrenutnoForm();
            admin.ShowDialog();
        }

        private void btnDI1_Click(object sender, EventArgs e)
        {
            DataProvider.AddIznajmljivanjePoFilmu("The Age of Adaline", "da");
        }

        private void btnDI2_Click(object sender, EventArgs e)
        {
            DataProvider.AddIznajmljivanjePoFilmu("Scent of a Woman", "da");
        }

        private void btnDI3_Click(object sender, EventArgs e)
        {
            DataProvider.AddIznajmljivanjePoFilmu("Modigliani", "ne");
        }

        private void btnVratiI_Click(object sender, EventArgs e)
        {
            List<IznajmljivanjePoFilmu> iznajmljivanja = DataProvider.GetIznajmljivanjePoFilmu();

            foreach (IznajmljivanjePoFilmu iznajmljivanje in iznajmljivanja)
            {
                MessageBox.Show(iznajmljivanje.nazivFilma + "\t" + iznajmljivanje.iznajmljen + "\n");
            }
        }

        private void btnObrisiI_Click(object sender, EventArgs e)
        {
            BrisanjeIznajmljivanjeForm admin = new BrisanjeIznajmljivanjeForm();
            admin.ShowDialog();
        }
    }
}
