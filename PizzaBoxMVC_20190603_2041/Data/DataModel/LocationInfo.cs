using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class LocationInfo
    {
        public LocationInfo()
        {
            LocationInventory = new HashSet<LocationInventory>();
            OrderSummary = new HashSet<OrderSummary>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<LocationInventory> LocationInventory { get; set; }
        public virtual ICollection<OrderSummary> OrderSummary { get; set; }
    }
}
