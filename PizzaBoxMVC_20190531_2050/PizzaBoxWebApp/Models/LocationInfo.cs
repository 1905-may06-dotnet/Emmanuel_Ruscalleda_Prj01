using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace PizzaBoxWebApp.Models
{
    public class LocationInfo
    {
        [DisplayName("No.")]
        public int LocaitonId { get; set; }
        [DisplayName("")]
        public string Name { get; set; }
        [DisplayName("Address")]
        public string Address1 { get; set; }
        [DisplayName("")]
        public string Address2 { get; set; }
        [DisplayName("")]
        public string City { get; set; }
        [DisplayName("")]
        public string State { get; set; }
        [DisplayName("")]
        public string Zipcode { get; set; }
        [DisplayName("Phone")]
        public string Phone { get; set; }

    }
}
