using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Vak
    {
        [Key]
        public int VakId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public bool Verwijderd { get; set; }

        public List<Studiebezoek> Studiebezoeken { get; set; }
    }
}