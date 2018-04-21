using System.ComponentModel.DataAnnotations;
using $safeprojectname$.CustomAttributes;
using $safeprojectname$.Properties;

namespace $safeprojectname$.Models.User
{
    public class Login
    {
        [Required(ErrorMessageResourceType = typeof(Resource),ErrorMessageResourceName = "Login_Username_Required")]
        [MaxLength(30, ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Login_Username_MaxLength")]
        [DisplayNameLocalizable("Login_Username_Label", typeof(Resource))]
        public string Username { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Login_Password_Required")]
        [DisplayNameLocalizable("Login_Password_Label", typeof(Resource))]
        public string Password { get; set; }

        [DisplayNameLocalizable("Login_KeepLoggedIn_Label", typeof(Resource))]
        public bool KeepLoggedIn { get; set; }

    }
}