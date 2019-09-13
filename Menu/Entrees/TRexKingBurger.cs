/*  TRexKingBurger.cs
*   Author: Jason Byrne
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        /// <summary>
        /// Keeps track of if teh bun is included on the entre
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Keeps track of if lettuce is included on the entre
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Keeps track of if tomatoes are included on the entre
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Keeps track of if onions are included on the entre
        /// </summary>
        private bool onion = true;

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
        /// Keeps track of if mayo is included on the entre
        /// </summary>
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
