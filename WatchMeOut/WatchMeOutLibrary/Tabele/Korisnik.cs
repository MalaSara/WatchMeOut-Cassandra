using System;
using System.Collections.Generic;
using System.Text;

namespace WatchMeOutLibrary.Tabele
{
    public class Korisnik
    {
        public string korisnikId { get; set; }
        public string administrator { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string brojtelefona { get; set; }
        public string adresa { get; set; }
        public string daLiJeIznajmioFilm { get; set; }
        public string daLiJeVratioSveIznajmljeneFilmove { get; set; }
        public string brojIznajmljenihFilmova { get; set; }
        public string omiljeniZanr { get; set; }
        public string idDoniranogFilma { get; set; }

    }
}
