CREATE TABLE "Film"(
    "filmId" text,
    "trajanjeFilma" text,
    "nazivFilma" text,
    zanr text,
    godina text,
    jezik text,
    "zemljaPorekla" text,
    "idKorisnikaKojiTrenutnoGleda" text,
    "brojIznajmljivanja" text,
    "glavniGlumci" text,
    PRIMARY KEY ("filmId")
)

CREATE TABLE "Korisnik" (
    "korisnikId" text,
    administrator text,
    ime text,
    prezime text,
    brojtelefona text,
    adresa text,
    "daLiJeIznajmioFilm" text,
    "daLiJeVratioSveIznajmljeneFilmove" text,
    "brojIznajmljenihFilmova" text,
    "omiljeniZanr" text,
    "idDoniranogFilma" text,
    PRIMARY KEY("korisnikId")
)