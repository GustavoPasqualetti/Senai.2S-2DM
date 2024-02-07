using System.ComponentModel.DataAnnotations;

namespace WebAppInLock.CodeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email obrigatorio")]
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}
