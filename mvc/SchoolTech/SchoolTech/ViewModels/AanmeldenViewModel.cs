using System.ComponentModel.DataAnnotations;

namespace SchoolTech.ViewModels
{
	public class AanmeldenViewModel
	{
		public class LoginViewModel
		{
			[Required(ErrorMessage = "Voer een gebruikersnaam in.")]
			public string Gebruikersnaam { get; set; }

			[Required(ErrorMessage = "Voer een passwoord in.")]
			[DataType(DataType.Password)]
			public string Passwoord { get; set; }
		}

	}
}
