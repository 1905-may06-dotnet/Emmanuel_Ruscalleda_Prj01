using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBoxWebApp.Models
{
    public class NewUserCheckModel
    {
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Email should be at most 50 characters")]
        [Required(ErrorMessage = "Email is mandatory")]
        public string Email1 { get; set; }

        [DisplayName("Re-enter Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Email should be at most 50 characters")]
        [Required(ErrorMessage = "Email is mandatory")]
        public string Email2 { get; set; }
    }
}
