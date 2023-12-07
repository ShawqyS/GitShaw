using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Afwezigheid
    {
        [Key]
        public int AfwezigheidId { get; set; }

        public string GebruikerId { get; set; }

        [Required]
        public System.DateTime StartDatum { get; set; }

        [Required]
        public System.DateTime EindDatum { get; set; }

        public Gebruiker Gebruiker { get; set; }
    }
}