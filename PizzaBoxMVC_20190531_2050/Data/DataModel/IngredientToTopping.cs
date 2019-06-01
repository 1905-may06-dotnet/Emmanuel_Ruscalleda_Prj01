using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class IngredientToTopping
    {
        public IngredientToTopping()
        {
            LocationInventory = new HashSet<LocationInventory>();
        }

        public string IngredientId { get; set; }
        public string ToppingId { get; set; }

        public virtual PizzaTopping Topping { get; set; }
        public virtual ICollection<LocationInventory> LocationInventory { get; set; }
    }
}
