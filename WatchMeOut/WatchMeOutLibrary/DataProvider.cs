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

        public static Korisnik GetKorisnik(string korisnikId)
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            Row korisnikPodatak = session.Execute("select * from \"Korisnik\" where korisnikId='" + korisnikId + "'").FirstOrDefault();

            if (korisnikPodatak != null)
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

        public static void DeleteKorisnik(string korisnikId)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikPodatak = session.Execute("delete from \"Korisnik\" where \"korisnikId\"='" + korisnikId +  "'");


        }

        #endregion

        #region Film

        public static Film GetFilm(string idFilma)
        {
            ISession session = SessionManager.GetSession();
            Film film = new Film();

            if (session == null)
                return null;

            Row filmPodatak = session.Execute("select * from \"Film\" where \"filmId\" = '" + idFilma + "'").FirstOrDefault();

            if (filmPodatak != null)
            {
                film.filmId = filmPodatak["filmId"] != null ? filmPodatak["filmId"].ToString() : string.Empty;
                film.trajanjeFilma = filmPodatak["trajanjeFilma"] != null ? filmPodatak["trajanjeFilma"].ToString() : string.Empty; ;
                film.nazivFilma = filmPodatak["nazivFilma"] != null ? filmPodatak["nazivFilma"].ToString() : string.Empty;

                film.godina = filmPodatak["godina"] != null ? filmPodatak["godina"].ToString() : string.Empty;
                film.zanr = filmPodatak["zanr"] != null ? filmPodatak["zanr"].ToString() : string.Empty;

                film.jezik = filmPodatak["jezik"] != null ? filmPodatak["jezik"].ToString() : string.Empty;

                film.zemljaPorekla = filmPodatak["zemljaPorekla"] != null ? filmPodatak["zemljaPorekla"].ToString() : string.Empty;
                film.idKorisnikaKojiTrenutnoGleda = filmPodatak["idKorisnikaKojiTrenutnoGleda"] != null ? filmPodatak["idKorisnikaKojiTrenutnoGleda"].ToString() : string.Empty; ;
                film.brojIznajmljivanja = filmPodatak["brojIznajmljivanja"] != null ? filmPodatak["brojIznajmljivanja"].ToString() : string.Empty; ;

                film.glavniGlumci = filmPodatak["glavniGlumci"] != null ? filmPodatak["glavniGlumci"].ToString() : string.Empty;

                return film;
            }
            return null;
        }
        
        public static List<Film> GetFilmovi()
        {
            ISession session = SessionManager.GetSession();
            List<Film> filmovi = new List<Film>();

            if (session == null)
                return null;

            var filmoviPodaci = session.Execute("select * from \"Film\"");

            foreach (var filmPodatak in filmoviPodaci)
            {
                Film film = new Film();

                film.filmId = filmPodatak["filmId"] != null ? filmPodatak["filmId"].ToString() : string.Empty;
                film.trajanjeFilma = filmPodatak["trajanjeFilma"] != null ? filmPodatak["trajanjeFilma"].ToString() : string.Empty;;
                film.nazivFilma = filmPodatak["nazivFilma"] != null ? filmPodatak["nazivFilma"].ToString() : string.Empty;

                film.godina = filmPodatak["godina"] != null ? filmPodatak["godina"].ToString() : string.Empty;
                film.zanr = filmPodatak["zanr"] != null ? filmPodatak["zanr"].ToString() : string.Empty;

                film.jezik = filmPodatak["jezik"] != null ? filmPodatak["jezik"].ToString() : string.Empty;

                film.zemljaPorekla = filmPodatak["zemljaPorekla"] != null ? filmPodatak["zemljaPorekla"].ToString() : string.Empty;
                film.idKorisnikaKojiTrenutnoGleda = filmPodatak["idKorisnikaKojiTrenutnoGleda"] != null ? filmPodatak["idKorisnikaKojiTrenutnoGleda"].ToString() : string.Empty;;
                film.brojIznajmljivanja = filmPodatak["brojIznajmljivanja"] != null ? filmPodatak["brojIznajmljivanja"].ToString() : string.Empty;;

                film.glavniGlumci = filmPodatak["glavniGlumci"] != null ? filmPodatak["glavniGlumci"].ToString() : string.Empty;

                filmovi.Add(film);
            }

            return filmovi;
        }

        public static void AddFilm(string filmId, string trajanjeFilma, string nazivFilma, string zanr,
            string godina, string jezik, string zemljaPorekla, string idKorisnikaKojiTrenutnoGleda,
            string brojIznajmljivanja, string glavniGlumci)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet filmPodatak = session.Execute("insert into \"Film\"(\"filmId\", \"trajanjeFilma\", \"nazivFilma\", zanr, " +
                "godina, jezik, \"zemljaPorekla\", \"idKorisnikaKojiTrenutnoGleda\", \"brojIznajmljivanja\", \"glavniGlumci\") values " +
                "( '" + filmId + "','" + trajanjeFilma + "', '" + nazivFilma + "', '" + zanr + "', '" + godina +
                "', '" + jezik + "', '" + zemljaPorekla + "', '" + idKorisnikaKojiTrenutnoGleda + "', '" + brojIznajmljivanja +
                "', '" + glavniGlumci + "')");
        }
        
        public static void DeleteFilm(string filmId)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet filmPodatak = session.Execute("delete from \"Film\" where \"filmId\" = '" + filmId + "'");
        }

        #endregion

    }
}