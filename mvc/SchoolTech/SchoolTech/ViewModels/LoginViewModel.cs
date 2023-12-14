using System.ComponentModel.DataAnnotations;

namespace SchoolTech.ViewModels
{
		public class LoginViewModel
		{
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Wachtwoord { get; set; }
        }
}
