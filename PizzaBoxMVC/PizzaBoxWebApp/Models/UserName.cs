using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PizzaBoxWebApp.Models
{
    public class UserName
    {
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email is mandatory")]

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First Name cannot be blank")]
        [StringLength(20, ErrorMessage = "First name should be maximun 20characters")]

        public string LastName { get; set; }

        public string Phone { get; set; }
    }
}
