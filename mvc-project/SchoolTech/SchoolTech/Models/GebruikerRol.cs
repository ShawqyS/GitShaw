using System.ComponentModel.DataAnnotations;

namespace SchoolTech.Models
{
    public class GebruikerRol
    {
        [Key]
        public int GebruikerRolId { get; set; }

        public string GebruikerId { get; set; }

        public int RolId { get; set; }

        public Rol Rol { get; set; }

        public Gebruiker Gebruiker { get; set; }
    }
}