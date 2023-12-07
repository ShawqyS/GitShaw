using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Foto
    {
        [Key]
        public int FotoId { get; set; }

        public int FotoAlbumId { get; set; }

        [Required]
        public string NaamFoto { get; set; }

        [Required]
        public string Thumbnail { get; set; }

        public FotoAlbum FotoAlbum { get; set; }
    }
}