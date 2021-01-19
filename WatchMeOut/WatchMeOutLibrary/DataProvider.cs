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

            Row korisnikPodatak = session.Execute("select * from \"Korisnik\" where \"korisnikId\"='" + korisnikId + "'").FirstOrDefault();

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

                return korisnik;
            }

            return null;
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

            RowSet korisnikPodatak = session.Execute("insert into \"Korisnik\"(\"korisnikId\", administrator,ime,prezime,brojtelefona,adresa,\"daLiJeIznajmioFilm\", \"daLiJeVratioSveIznajmljeneFilmove\",\"brojIznajmljenihFilmova\",\"omiljeniZanr\",\"idDoniranogFilma\") values" + "('" + korisnikId + "', '" + administrator + "','" + ime + "','" + prezime + "','" + brojtelefona + "','" + adresa + "','" + daLiJeIznajmioFilm + "', '" + daLiJeVratioSveIznajmljeneFilmove + "','" + brojIznajmljenihFilmova + "','" + omiljeniZanr + "','" + idDoniranogFilma + "')");


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

        #region TrenutnoIznajmljeni
        public static TrenutnoIznajmljeni GetTrenutnoIznajmljeni(string korisnik, string vraceno)
        {
            ISession session = SessionManager.GetSession();
            TrenutnoIznajmljeni trenutnoIznajmljeni = new TrenutnoIznajmljeni();

            if (session == null)
                return null;

            Row trenutnoIznajmljeniPodatak = session.Execute("select * from \"TrenutnoIznajmljeni\" where korisnik='" + korisnik + "' and vraceno='" + vraceno + "'").FirstOrDefault();

            if (trenutnoIznajmljeniPodatak != null)
            {

                trenutnoIznajmljeni.korisnik = trenutnoIznajmljeniPodatak["korisnik"] != null ? trenutnoIznajmljeniPodatak["korisnik"].ToString() : string.Empty;
                trenutnoIznajmljeni.film = trenutnoIznajmljeniPodatak["film"] != null ? trenutnoIznajmljeniPodatak["film"].ToString() : string.Empty;
                trenutnoIznajmljeni.od = trenutnoIznajmljeniPodatak["od"] != null ? trenutnoIznajmljeniPodatak["od"].ToString() : string.Empty;
                trenutnoIznajmljeni.Do = trenutnoIznajmljeniPodatak["Do"] != null ? trenutnoIznajmljeniPodatak["Do"].ToString() : string.Empty;
                trenutnoIznajmljeni.vraceno = trenutnoIznajmljeniPodatak["vraceno"] != null ? trenutnoIznajmljeniPodatak["vraceno"].ToString() : string.Empty;

                return trenutnoIznajmljeni;
            }

            return null;
        }

        public static List<TrenutnoIznajmljeni> GetTrenutnoIznajmljeni()
        {
            ISession session = SessionManager.GetSession();
            List<TrenutnoIznajmljeni> trenutnoIznajmljeni = new List<TrenutnoIznajmljeni>();

            if (session == null)
                return null;

            var trenutnoIznajmljeniPodaci = session.Execute("select * from \"TrenutnoIznajmljeni\"");

            foreach (var trenutnoIznajmljeniPodatak in trenutnoIznajmljeniPodaci)
            {

                TrenutnoIznajmljeni podatak = new TrenutnoIznajmljeni();
                podatak.korisnik = trenutnoIznajmljeniPodatak["korisnik"] != null ? trenutnoIznajmljeniPodatak["korisnik"].ToString() : string.Empty;
                podatak.film = trenutnoIznajmljeniPodatak["film"] != null ? trenutnoIznajmljeniPodatak["film"].ToString() : string.Empty;
                podatak.od = trenutnoIznajmljeniPodatak["od"] != null ? trenutnoIznajmljeniPodatak["od"].ToString() : string.Empty;
                podatak.Do = trenutnoIznajmljeniPodatak["Do"] != null ? trenutnoIznajmljeniPodatak["Do"].ToString() : string.Empty;
                podatak.vraceno = trenutnoIznajmljeniPodatak["vraceno"] != null ? trenutnoIznajmljeniPodatak["vraceno"].ToString() : string.Empty;

                trenutnoIznajmljeni.Add(podatak);
            }

            return trenutnoIznajmljeni;
        }

        public static void AddTrenutnoIznajmljeni(string korisnik, string film, string od, string Do, string vraceno)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet podatak = session.Execute("insert into \"TrenutnoIznajmljeni\"(korisnik,film,od,\"Do\", vraceno) values" 
                + "('" + korisnik + "', '" + film + "','" + od + "','" + Do + "','" + vraceno + "')");


        }

        public static void DeleteTrenutnoIznajmljeni(string korisnik, string vraceno)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet podatak = session.Execute("delete from \"TrenutnoIznajmljeni\" where korisnik = '" + korisnik + "' and vraceno = '" + vraceno + "'");


        }

        #endregion

        #region IznajmljivanjePoFilmu

        public static IznajmljivanjePoFilmu GetIznajmljivanjePoFilmu(string nazivFilma, string iznajmljen)
        {
            ISession session = SessionManager.GetSession();
            IznajmljivanjePoFilmu iznajmljivanjePoFilmu = new IznajmljivanjePoFilmu();

            if (session == null)
                return null;

            Row podatak = session.Execute("select * from \"IznajmljivanjePoFilmu\" where \"nazivFilma\"='" + nazivFilma + "' and iznajmljen='" + iznajmljen + "'").FirstOrDefault();

            if (podatak != null)
            {

                iznajmljivanjePoFilmu.nazivFilma = podatak["nazivFilma"] != null ? podatak["nazivFilma"].ToString() : string.Empty;
                iznajmljivanjePoFilmu.iznajmljen = podatak["iznajmljen"] != null ? podatak["iznajmljen"].ToString() : string.Empty;

                return iznajmljivanjePoFilmu;
            }

            return null;
        }

        public static List<IznajmljivanjePoFilmu> GetIznajmljivanjePoFilmu()
        {
            ISession session = SessionManager.GetSession();
            List<IznajmljivanjePoFilmu> iznajmljivanjePoFilmu = new List<IznajmljivanjePoFilmu>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"IznajmljivanjePoFilmu\"");

            foreach (var iznajmljivanjePodatak in podaci)
            {

                IznajmljivanjePoFilmu podatak = new IznajmljivanjePoFilmu();
                podatak.nazivFilma = iznajmljivanjePodatak["nazivFilma"] != null ? iznajmljivanjePodatak["nazivFilma"].ToString() : string.Empty;
                podatak.iznajmljen = iznajmljivanjePodatak["iznajmljen"] != null ? iznajmljivanjePodatak["iznajmljen"].ToString() : string.Empty;

                iznajmljivanjePoFilmu.Add(podatak);
            }

            return iznajmljivanjePoFilmu;
        }

        public static void AddIznajmljivanjePoFilmu(string nazivFilma, string iznajmljen)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet podatak = session.Execute("insert into \"IznajmljivanjePoFilmu\"(\"nazivFilma\", iznajmljen) values"
                + "('" + nazivFilma + "','" + iznajmljen + "')");


        }

        public static void DeleteIznajmljivanjePoFilmu(string nazivFilma, string iznajmljen)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet podatak = session.Execute("delete from \"IznajmljivanjePoFilmu\" where \"nazivFilma\" = '" + nazivFilma + "' and iznajmljen = '" + iznajmljen + "'");


        }

        #endregion

    }
}