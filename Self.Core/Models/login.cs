using System.ComponentModel.DataAnnotations;

namespace Self_ordaring_sys.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
    }
}
