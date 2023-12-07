-- Inserts for Gebruikers (alleen nieuwe gebruikers toevoegen)

INSERT INTO Gebruiker (Id, Naam, Voornaam, Initialen, Gebruikersnaam, Wachtwoord, Email, Verwijderd, AccessFailedCount, EmailConfirmed, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnabled) VALUES
(1, 'Naam1', 'Voornaam1', 'Ini1', 'Gebruikersnaam1', 'Wachtwoord1', 'email1@example.com', 0, 0, 1, 1, 0, 0),
(2, 'Naam2', 'Voornaam2', 'Ini2', 'Gebruikersnaam2', 'Wachtwoord2', 'email2@example.com', 0, 0, 1, 1, 0, 0);

-- Inserts for Klas

INSERT INTO Klas (Naam, Verwijderd) VALUES
('Klas 1', 0),
('Klas 2', 0);

-- Inserts for Rol

INSERT INTO Rol (Naam) VALUES
('Administratief'),
('Directeur');

-- Inserts for Vak


INSERT INTO Vak (Naam , Verwijderd) VALUES
('Vak1', 0),
('Vak2', 0);


-- Inserts for Afwezigheid (zorg ervoor dat GebruikerId bestaat in Gebruikers)

INSERT INTO Afwezigheid (GebruikerId, StartDatum, EindDatum) VALUES
(1, '2001-01-01', '2001-01-02'),
(2, '2002-02-02', '2002-02-03');

-- Inserts for Navorming (zorg ervoor dat NaamAanvragerId bestaat in Gebruikers)

INSERT INTO Navorming (GebruikerId, Datum, StartUur, EindUur, Reden, Kostprijs) VALUES
(1, '2001-01-01', '01:00', '02:00', 'Reden1', 1.00),
(2, '2002-02-02', '02:00', '03:00', 'Reden2', 2.00);

-- Inserts for Studiebezoek (zorg ervoor dat NaamAanvragerId en VakId bestaan in respectievelijk Gebruikers en Vak)

INSERT INTO Studiebezoek (GebruikerId, VakId, datum, startUur, eindUur, Reden, AantalStudenten, KostprijsStudiebezoek) VALUES
(1, 1, '2001-01-01', '01:00', '02:00', 'Reden1', 1, 1.00),
(2, 2, '2002-02-02', '02:00', '03:00', 'Reden2', 2, 2.00);

INSERT INTO Begeleiding (StudiebezoekId, GebruikerId) VALUES
(1, 1),
(2, 2);

INSERT INTO Bijlage (StudiebezoekId, BestandsNaam) VALUES
(1, 'bestandsnaam1'),
(2, 'bestandsnaam2');

INSERT INTO FotoAlbum (StudiebezoekId, Naam, Datum) VALUES
(1, 'naam1', '2001-01-01'),
(2, 'naam2', '2002-02-02');

INSERT INTO Foto (FotoAlbumId, NaamFoto, Thumbnail) VALUES
(1, 'naam1', 'c:\thumbnail1.png'),
(2, 'naam2', 'c:\thumbnail2.png');

INSERT INTO GebruikerNavorming (GebruikerId, NavormingId) VALUES
(1, 1),
(2, 2);

INSERT INTO GebruikerRol (GebruikerId, RolId) VALUES
(1, 1),
(2, 2);

INSERT INTO KlasStudiebezoek (KlasId, StudiebezoekId) VALUES
(1, 1),
(2, 2);