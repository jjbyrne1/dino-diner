/*  VelociWrap.cs
 *  Author: Jason Byrne
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class that inherits from Entree and stores the price, calories, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class VelociWrap : Entree
    {
        //Backing Variables
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        /// <summary>
        /// Creates an new instance of the VelociWrap Entree and stores its price
        /// and calorie count.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Overrides the ingredients property from Entree and checks what ingredients
        /// are included in the meal and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Removes the cesar dressing from the ingredients list for this instance.
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Removes the lettuce from the ingredients list for this instance.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes the cheese from the ingredients list for this instance.
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
