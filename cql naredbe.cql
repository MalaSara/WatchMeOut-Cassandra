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

CREATE TABLE "Iznajmljivanje" (
	"IDkorisnika" text,
	"IDfilma" text,
	od text,
	"Do" text,
	produzi text,
	PRIMARY KEY ("IDkorisnika", "IDfilma")
)

CREATE TABLE "TrenutnoIznajmljeni" (
	korisnik text,
	film text,
	od text,
	"Do" text,
	vraceno text,
	PRIMARY KEY (korisnik, vraceno)
)

CREATE TABLE "IznajmljivanjePoFilmu" (
	"nazivFilma" text,
	iznajmljen text,
	PRIMARY KEY ("nazivFilma", iznajmljen)
)