using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class PlesiosaurusPattie : Entree
    {
        //Backing Variables
        private bool mayo;
        private bool bun;
        private List<string> ingredients;

        public override List<string> Ingredients
        {
            get { return new List<string>(ingredients); }
        }

        public PlesiosaurusPattie()
        {
            mayo = true;
            bun = true;
            Price = 5.50;
            Calories = 487;
            ingredients = new List<string>();
            ingredients.Add("Fish Patty");
            ingredients.Add("Whole Weat Bun");
            ingredients.Add("Mayonnaise");
        }

        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        public void HoldMayo()
        {
            ingredients.Remove("Mayonnaise");
        }

    }
}
