using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Begeleiding
    {
        [Key]
        public int BegeleidingId { get; set; }

        public int StudiebezoekId { get; set; }

        public string GebruikerId { get; set; }

        public Studiebezoek Studiebezoek { get; set; }

        public Gebruiker Gebruiker { get; set; }
    }
}