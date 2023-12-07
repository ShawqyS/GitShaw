using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class GebruikerNavorming
    {
        [Key]
        public int GebruikerNavormingId { get; set; }

        public string GebruikerId { get; set; }

        public int NavormingId { get; set; }

        public Navorming Navorming { get; set; }

        public Gebruiker Gebruiker { get; set; }
    }
}