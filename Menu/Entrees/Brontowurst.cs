/*  Brontowurst.cs
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
    public class Brontowurst
    {
        //backdrop properties
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

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
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
        {
            get {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// Removes the bun from the ingredients list for this instance
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Removes the peppers from the ingredients list for this instance
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// Removes the onions from the ingredients list for this instance
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
