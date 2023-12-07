using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SchoolTech.Models
{
    public class KlasStudiebezoek
    {
        [Key]
        public int KlasStudiebezoekId { get; set; }

        public Klas Klas { get; set; }

        public Studiebezoek Studiebezoek { get; set; }

        public int KlasId { get; set; }

        public int StudiebezoekId { get; set; }
    }
}