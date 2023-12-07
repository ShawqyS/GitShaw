using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Bijlage
    {
        [Key]
        public int BijlageId { get; set; }

        public int StudiebezoekId { get; set; }

        public Studiebezoek Studiebezoek { get; set; }

        [Required]
        public string BestandsNaam { get; set; }
    }
}