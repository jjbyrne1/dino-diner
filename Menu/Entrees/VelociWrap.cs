/*  VelociWrap.cs
*   Author: Jason Byrne
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Function that creates an entre and stores the price, calories, number of nuggets, and updates ingredients
    /// depending on the customers requests.
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// Keeps track of if cesar dressing is included on the entre
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Keeps track of if lettuce is included on the entre
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Keeps track of if cheese is included on the entre
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// Keeps track of the price of the entre
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Keeps track of the calories of the entre
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Creates an instance of the entre and stores its price and calorie count
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
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
        /// Removes the cesar dressing from the ingredients list for this instance
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// Removes the lettuce from the ingredients list for this instance
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes the cheese from the ingredients list for this instance
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
