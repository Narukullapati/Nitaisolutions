using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nitaisolutions.Models
{
   
        [Table("Nitai.Users")]
        public class Userinfo
        {
            [Key]
            public int ID { get; set; }

        [Display(Name = "User")]
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }


        public string CreatedOn { get; set; }
            public int CreatedBy { get; set; }
            public string Modifiedon { get; set; }
            public int ModifiedBy { get; set; }
            public string Status { get; set; }

        }
   
}