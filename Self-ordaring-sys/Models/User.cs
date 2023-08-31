using System.ComponentModel.DataAnnotations;

namespace Self_ordaring_sys.Models
{
    public class User 
    {

        [Required(ErrorMessage = "Please Enter Your Full Name"),MinLength(10)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please Enter Your Full Name"), MinLength(10)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; } 

        [Required(ErrorMessage = "Please Enter Your Address"), MinLength(11)]
        public string Phone { get; set; }
        
    }
}
