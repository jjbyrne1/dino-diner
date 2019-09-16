/*  SteakosaurusBurger.cs
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
    public class SteakosaurusBurger
    {
        //backdrop properties
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

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
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
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
        /// Removes the pickles from the ingredients list for this instance
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Removes the ketchup from the ingredients list for this instance
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Removes the mustard from the ingredients list for this instance
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
