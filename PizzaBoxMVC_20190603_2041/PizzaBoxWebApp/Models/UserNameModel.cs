using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBoxWebApp.Models
{
    public class UserNameModel
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is mandatory")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@"[a-zA-Z0-9+_.-]+@[a-zA-Z]+.+[a-zA-Z]", ErrorMessage = "Format: username@domain1.domain2")]
        public string Email { get; set; }


        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name cannot be blank")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "First Name should be between 3 and 20 characters")]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name cannot be blank")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name should be between 3 and 20 characters")]
        public string LastName { get; set; }


        [Display(Name = "Phone", Prompt = "###-###-####")]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Format: ###-###-####")]
        public string Phone { get; set; }
    }
}
