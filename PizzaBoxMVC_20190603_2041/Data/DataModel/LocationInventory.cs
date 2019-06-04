using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class LocationInventory
    {
        public int LocationId { get; set; }
        public string IngredientId { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }
        public int CurrentLevel { get; set; }
        public int Incoming { get; set; }
        public string Eta { get; set; }

        public virtual IngredientToTopping Ingredient { get; set; }
        public virtual LocationInfo Location { get; set; }
    }
}
