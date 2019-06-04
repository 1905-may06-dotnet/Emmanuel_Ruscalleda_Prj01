using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PizzaBoxWebApp.Models
{
    public class NewUserInfoModel
    {
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, ErrorMessage = "Email should be at most 50 characters")]
        [Required(ErrorMessage = "Email is mandatory")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Password should be between 8 and 50 characters")]
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password1 { get; set; }

        [DisplayName("Re-enter Password")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Password should be between 8 and 50 characters")]
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password2 { get; set; }

        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "First Name should be at most 20 characters")]
        [Required(ErrorMessage = "First Name is mandatory")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "Last Name should be at most 20 characters")]
        [Required(ErrorMessage = "Last Name is mandatory")]
        public string LastName { get; set; }
        /*
        [DisplayName("Address 1")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Address 1 should be at most 50 characters")]
        [Required(ErrorMessage = "Address 1 is mandatory")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2", Prompt = "optional")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Address 2 should be at most 50 characters")]
        public string Address2 { get; set; }

        [DisplayName("City")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "City should be at most 20 characters")]
        [Required(ErrorMessage = "City is mandatory")]
        public string City { get; set; }

        [DisplayName("State")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "State should be at most 20 characters")]
        [Required(ErrorMessage = "State is mandatory")]
        public string State { get; set; }

        [Display(Name = "Zip code", Prompt = "#####")]
        [RegularExpression(@"\d{5}", ErrorMessage = "Format: #####")]
        [Required(ErrorMessage = "Zip code is mandatory")]
        public string Zipcode { get; set; }

        [Display(Name = "Address Details", Prompt = "optional")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "Address Details be at most 100 characters")]
        public string AddressDetails { get; set; }

        [Display(Name = "Phone", Prompt = "###-###-####")]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Format: ###-###-####")]
        public string Phone { get; set; }

        [Display(Name = "Credit Card Number", Prompt = "####-####-####-####")]
        [RegularExpression(@"\d{4}-\d{4}-\d{4}-\d{4}", ErrorMessage = "Format: ####-####-####-####")]
        [Required(ErrorMessage = "Credit Card Number is mandatory")]
        public string CreidtCardNumber { get; set; }

        [Display(Name = "CVV", Prompt = "###")]
        [RegularExpression(@"\d{3}", ErrorMessage = "Format: ###")]
        [Required(ErrorMessage = "CVV is mandatory")]
        public string CVV { get; set; }

        [Display(Name = "Valid Thru", Prompt = "yyyy-mm")]
        [RegularExpression(@"\d{4}-\d{2}", ErrorMessage = "Format: yyyy-mm")]
        [Required(ErrorMessage = "Valid Thru is mandatory")]
        public string ValidThru { get; set; }

        [DisplayName("First Name")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "First Name should be at most 20 characters")]
        [Required(ErrorMessage = "First Name is mandatory")]
        public string CardFirstName { get; set; }

        [DisplayName("Last Name")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "Last Name should be at most 20 characters")]
        [Required(ErrorMessage = "Last Name is mandatory")]
        public string CardLastName { get; set; }
        
        [DisplayName("Address 1")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Address 1 should be at most 50 characters")]
        [Required(ErrorMessage = "Address 1 is mandatory")]
        public string CardAddress1 { get; set; }

        [Display(Name = "Address 2", Prompt = "optional")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "Address 2 should be at most 50 characters")]
        public string CardAddress2 { get; set; }

        [DisplayName("City")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "City should be at most 20 characters")]
        [Required(ErrorMessage = "City is mandatory")]
        public string CardCity { get; set; }

        [DisplayName("State")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "State should be at most 20 characters")]
        [Required(ErrorMessage = "State is mandatory")]
        public string CardState { get; set; }

        [Display(Name = "Zip code", Prompt = "#####")]
        [RegularExpression(@"\d{5}", ErrorMessage = "Format: #####")]
        [Required(ErrorMessage = "Zip code is mandatory")]
        public string CardZipcode { get; set; }
        */

    }
}
