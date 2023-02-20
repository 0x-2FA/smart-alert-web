using System.ComponentModel.DataAnnotations;

namespace smart_alert_web.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "Please enter your email!")]
        public string? email { get; set; }
        [Required(ErrorMessage = "Please enter your password!")]
        [DataType(DataType.Password)]
        public string? password { get; set; }
    }
}
