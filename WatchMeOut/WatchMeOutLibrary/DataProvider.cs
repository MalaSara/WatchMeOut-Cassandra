using System;
using System.Collections.Generic;
using System.Text;
using Cassandra;
using WatchMeOutLibrary.Tabele;
using System.Linq;

namespace WatchMeOutLibrary
{
    public static class DataProvider
    {
        #region Korisnici

        public static Korisnik GetKorisnik(string ime)
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            Row korisnikPodatak = session.Execute("select * from \"Korisnik\" where ime='" + ime + "'").FirstOrDefault();

            if (korisnikPodatak == null)
            {

                korisnik.korisnikId = korisnikPodatak["korisnikId"] != null ? korisnikPodatak["korisnikId"].ToString() : string.Empty;
                korisnik.administrator = korisnikPodatak["administrator"] != null ? korisnikPodatak["administrator"].ToString() : string.Empty;
                korisnik.ime = korisnikPodatak["ime"] != null ? korisnikPodatak["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikPodatak["prezime"] != null ? korisnikPodatak["prezime"].ToString() : string.Empty;
                korisnik.brojtelefona = korisnikPodatak["brojtelefona"] != null ? korisnikPodatak["brojtelefona"].ToString() : string.Empty;
                korisnik.adresa = korisnikPodatak["adresa"] != null ? korisnikPodatak["adresa"].ToString() : string.Empty;
                korisnik.daLiJeIznajmioFilm = korisnikPodatak["daLiJeIznajmioFilm"] != null ? korisnikPodatak["daLiJeIznajmioFilm"].ToString() : string.Empty;
                korisnik.daLiJeVratioSveIznajmljeneFilmove = korisnikPodatak["daLiJeVratioSveIznajmljeneFilmove"] != null ? korisnikPodatak["daLiJeVratioSveIznajmljeneFilmove"].ToString() : string.Empty;
                korisnik.brojIznajmljenihFilmova = korisnikPodatak["brojIznajmljenihFilmova"] != null ? korisnikPodatak["brojIznajmljenihFilmova"].ToString() : string.Empty;
                korisnik.omiljeniZanr = korisnikPodatak["omiljeniZanr"] != null ? korisnikPodatak["omiljeniZanr"].ToString() : string.Empty;
                korisnik.idDoniranogFilma = korisnikPodatak["idDoniranogFilma"] != null ? korisnikPodatak["idDoniranogFilma"].ToString() : string.Empty;


            }

            return korisnik;
        }

        public static List<Korisnik> GetKorisnici()
        {
            ISession session = SessionManager.GetSession();
            List<Korisnik> korisnici = new List<Korisnik>();

            if (session == null)
                return null;

            var korisniciPodatak = session.Execute("select * from \"Korisnik\"");

            foreach (var korisnikPodatak in korisniciPodatak)
            {

                Korisnik korisnik = new Korisnik();
                korisnik.korisnikId = korisnikPodatak["korisnikId"] != null ? korisnikPodatak["korisnikId"].ToString() : string.Empty;
                korisnik.administrator = korisnikPodatak["administrator"] != null ? korisnikPodatak["administrator"].ToString() : string.Empty;
                korisnik.ime = korisnikPodatak["ime"] != null ? korisnikPodatak["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikPodatak["prezime"] != null ? korisnikPodatak["prezime"].ToString() : string.Empty;
                korisnik.brojtelefona = korisnikPodatak["brojtelefona"] != null ? korisnikPodatak["brojtelefona"].ToString() : string.Empty;
                korisnik.adresa = korisnikPodatak["adresa"] != null ? korisnikPodatak["adresa"].ToString() : string.Empty;
                korisnik.daLiJeIznajmioFilm = korisnikPodatak["daLiJeIznajmioFilm"] != null ? korisnikPodatak["daLiJeIznajmioFilm"].ToString() : string.Empty;
                korisnik.daLiJeVratioSveIznajmljeneFilmove = korisnikPodatak["daLiJeVratioSveIznajmljeneFilmove"] != null ? korisnikPodatak["daLiJeVratioSveIznajmljeneFilmove"].ToString() : string.Empty;
                korisnik.brojIznajmljenihFilmova = korisnikPodatak["brojIznajmljenihFilmova"] != null ? korisnikPodatak["brojIznajmljenihFilmova"].ToString() : string.Empty;
                korisnik.omiljeniZanr = korisnikPodatak["omiljeniZanr"] != null ? korisnikPodatak["omiljeniZanr"].ToString() : string.Empty;
                korisnik.idDoniranogFilma = korisnikPodatak["idDoniranogFilma"] != null ? korisnikPodatak["idDoniranogFilma"].ToString() : string.Empty;

                korisnici.Add(korisnik);
            }

            return korisnici;
        }

        public static void AddKorisnik(string korisnikId, string administrator, string ime, string prezime, string brojtelefona, string adresa, string daLiJeIznajmioFilm, string daLiJeVratioSveIznajmljeneFilmove, string brojIznajmljenihFilmova, string omiljeniZanr, string idDoniranogFilma)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikPodatak = session.Execute("insert into \"Korisnik\"(korisnikId, administrator,ime,prezime,brojtelefona,adresa,daLiJeIznajmioFilm, daLiJeVratioSveIznajmljeneFilmove,brojIznajmljenihFilmova,omiljeniZanr,idDoniranogFilma) values ('" + korisnikId + "', '" + administrator + "','" + ime + "','" + prezime + "','" + brojtelefona + "','" + adresa + "','" + daLiJeIznajmioFilm + "', '" + daLiJeVratioSveIznajmljeneFilmove + "','" + brojIznajmljenihFilmova + "','" + omiljeniZanr + "','" + idDoniranogFilma + "')");


        }

        public static void DeleteKorisnik(string korisnikId, string idDoniranogFilma)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikPodatak = session.Execute("delete from \"Korisnik\" where \"korisnikId\"='" + korisnikId + "' and \"idDoniranogFilma\"='" + idDoniranogFilma + "'");


        }



        #endregion

    }
}