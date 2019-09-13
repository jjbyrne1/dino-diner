/*  SteakosaurusBurger.cs
*   Author: Jason Byrne
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        /// <summary>
        /// Keeps track of if the bun is included on the entre
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Keeps track of if pickles are included on the entre
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Keeps track of if ketchup is included on the entre
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Keeps track of if mustard is included on the entre
        /// </summary>
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
