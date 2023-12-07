using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Navorming
    {
        [Key]
        public int NavormingId { get; set; }

        public string GebruikerId { get; set; }

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

        public Gebruiker Aanvrager { get; set; }

        public System.Collections.Generic.List<GebruikerNavorming> GebruikerNavormingen { get; set; }
    }
}