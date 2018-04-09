using System.ComponentModel.DataAnnotations;
using System.Web.Security;

namespace $safeprojectname$.Models.User
{
    public class Login
    {
        [Required(ErrorMessage = "No username was provided.")]
        [MaxLength(30,ErrorMessage = "Username is to long.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "No password was provided.")]
        public string Password { get; set; }

        public bool KeepLoggedIn { get; set; }

    }
}