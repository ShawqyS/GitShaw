using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class FotoAlbum
    {
        [Key]
        public int FotoAlbumId { get; set; }

        public int StudiebezoekId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        public List<Foto>? Fotos { get; set; }

        public Studiebezoek Studiebezoek { get; set; }
    }
}