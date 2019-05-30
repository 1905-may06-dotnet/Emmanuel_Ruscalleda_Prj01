using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class PizzaTopping
    {
        public PizzaTopping()
        {
            IngredientToTopping = new HashSet<IngredientToTopping>();
            OrderTopping = new HashSet<OrderTopping>();
        }

        public string ToppingId { get; set; }
        public float SalesPrice { get; set; }

        public virtual ICollection<IngredientToTopping> IngredientToTopping { get; set; }
        public virtual ICollection<OrderTopping> OrderTopping { get; set; }
    }
}
