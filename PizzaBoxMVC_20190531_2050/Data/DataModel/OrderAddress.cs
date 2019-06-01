using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class OrderAddress
    {
        public int OrderId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string Instructions { get; set; }

        public virtual OrderSummary Order { get; set; }
    }
}
