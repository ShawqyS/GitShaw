using SchoolTech.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolTech.ViewModels
{
    public class NavormingCreateViewModel
    {
        //Gebruiker
        public int GebruikerId { get; set; }

        [Required]
        public System.DateTime Datum { get; set; }

        [Required]
        public System.DateTime StartUur { get; set; }

        [Required]
        public System.DateTime EindUur { get; set; }

        [Required]
        public string Reden { get; set; }

        [Required]
        public float Kostprijs { get; set; }

        public bool? IsGoedgekeurdDir { get; set; }

        public bool? isAfgewezen { get; set; }

        public string? OpmerkingAfgewezen { get; set; }

        public bool? IsAfgewerkt { get; set; }

        // Aanvrager

        // Gebruikernavorming
        public IEnumerable<GebruikerNavorming>? gebruikerNavormingen { get; set; }

        // Alle gebruikers voor select in view
        public IEnumerable<Gebruiker>? Gebruikers { get; set; }
    }
}