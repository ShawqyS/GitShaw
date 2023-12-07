using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SchoolTech.Models
{
    public class Klas
    {
        [Key]
        public int KlasId { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public bool Verwijderd { get; set; }

        public List<KlasStudiebezoek> KlasStudiebezoeken { get; set; }
    }
}