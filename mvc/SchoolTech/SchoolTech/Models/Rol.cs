using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class Rol
    {
        [Key]
        public int RolId { get; set; }

        [Required]
        public string Naam { get; set; }

        public List<GebruikerRol> GebruikerRollen { get; set; }
    }
}