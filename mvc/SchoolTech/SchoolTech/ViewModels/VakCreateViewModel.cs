using SchoolTech.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolTech.ViewModels
{
    public class VakCreateViewModel
    {
        [Required]
        public string Naam { get; set; }

        [Required]
        public bool Verwijderd { get; set; }

        public List<Studiebezoek> ?Studiebezoeken { get; set; }

        //constructor
        public VakCreateViewModel()
        {
            Naam = "";
            Verwijderd = false;
        }
    }
}
