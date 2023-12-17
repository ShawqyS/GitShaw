using SchoolTech.Models;
using System.ComponentModel.DataAnnotations;

namespace SchoolTech.ViewModels
{
    public class VakUpdateViewModel
    {
        [Key]
        public int VakId { get; set; }

        [Required]
        public string Naam { get; set; }
    }
}
