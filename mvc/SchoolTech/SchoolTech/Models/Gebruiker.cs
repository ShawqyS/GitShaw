using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Gebruiker : IdentityUser
    {
        /*
        // Identity heeft id een string gemaakt?
		[Key]
		public int GebruikerId { get; set; }
		*/

        [Required]
        [PersonalData]
        public string Naam { get; set; }

        [Required]
        [PersonalData]
        public String Voornaam { get; set; }

        public string VolledigeNaam => $"{Voornaam} {Naam}";

        [Required]
        [PersonalData]
        public string Initialen { get; set; }

        [Required]
        public string Gebruikersnaam { get; set; }

        [Required(ErrorMessage = "Wachtwoord is required")]
        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required]
        public bool Verwijderd { get; set; }

        public List<Begeleiding> BegeleidStudiebezoeken { get; set; }

        public List<GebruikerRol> GebruikerRollen { get; set; }

        public System.Collections.Generic.List<Afwezigheid> Afwezigheden { get; set; }

        public System.Collections.Generic.List<Navorming> AangevraagdeNavormingen { get; set; }

        public System.Collections.Generic.List<GebruikerNavorming> GebruikerNavormingen { get; set; }

        public List<Studiebezoek> AangevraagdeStudiebezoeken { get; set; }
    }
}