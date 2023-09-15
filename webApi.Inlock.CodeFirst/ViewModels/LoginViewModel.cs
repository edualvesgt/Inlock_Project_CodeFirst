using System.ComponentModel.DataAnnotations;

namespace webApi.Inlock.CodeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Obrihatorio")]
        public String? Email { get; set; }

        [Required(ErrorMessage = "Senha Obrihatorio")]
        public String? Senha { get; set; }
    }
}
