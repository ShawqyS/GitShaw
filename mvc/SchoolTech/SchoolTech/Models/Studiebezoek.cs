using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SchoolTech.Models
{
    public class Studiebezoek
    {
        [Key]
        public int StudiebezoekId { get; set; }

        public string GebruikerId { get; set; }

        public Vak Vak { get; set; }

        [Required]
        public System.DateTime datum { get; set; }

        [Required]
        public System.DateTime startUur { get; set; }

        [Required]
        public System.DateTime eindUur { get; set; }

        [Required]
        public string Reden { get; set; }

        public int? AantalStudenten { get; set; }

        [Required]
        public float KostprijsStudiebezoek { get; set; }

        public bool? VervoerBus { get; set; }

        public bool? VervoerTram { get; set; }

        public bool? VervoerTrein { get; set; }

        public bool? VervoerTeVoet { get; set; }

        public bool? VervoerAuto { get; set; }

        public bool? VervoerFiets { get; set; }

        public float? KostprijsVervoer { get; set; }

        public string? AfwezigeStudenten { get; set; }

        public string? Opmerkingen { get; set; }

        public bool? IsGoedgekeurdCo { get; set; }

        public bool? IsGoedgekeurdDir { get; set; }

        public bool? IsAfgewezen { get; set; }

        public string? OpmerkingAfgewezen { get; set; }

        public bool? IsAfgewerkt { get; set; }

        public List<KlasStudiebezoek> KlasStudiebezoeken { get; set; }

        public List<Bijlage> Bijlagen { get; set; }

        public List<FotoAlbum> FotoAlbums { get; set; }

        public List<Begeleiding> Begeleiders { get; set; }

        public int VakId { get; set; }

        public Gebruiker Aanvrager { get; set; }
    }
}