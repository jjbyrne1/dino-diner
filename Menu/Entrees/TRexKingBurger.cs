/*  TRexKingBurger.cs
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
    public class TRexKingBurger
    {
        //backdrop properties
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;

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
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
        {
            get {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" , "Steakburger Pattie" , "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
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
        /// Removes the lettuce from the ingredients list for this instance
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// Removes the tomatoes from the ingredients list for this instance
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// Removes the onions from the ingredients list for this instance
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
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

        /// <summary>
        /// Removes the mayo from the ingredients list for this instance
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }

    }
}
