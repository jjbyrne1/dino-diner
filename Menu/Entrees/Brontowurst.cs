/*  Brontowurst.cs
*   Author: Jason Byrne
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Entree and stores the price, calories, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class Brontowurst : Entree, IOrderItem
    {
        //Backing Variables
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        /// <summary>
        /// Creates an new instance of the Brontowurst Entree and stores its price
        /// and calorie count.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// Overrides the ingredients property from Entree and checks what ingredients
        /// are included in the meal and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
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
        /// Removes the bun from the ingredients list for this instance.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the peppers from the ingredients list for this instance.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the onions from the ingredients list for this instance.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item
        /// </summary>
        /// <returns> name of the item </returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Property that gets the menu item's name
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Property that gets an array of all the special instructions for the
        /// specific entree
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!peppers) special.Add("Hold Peppers");
                if (!onions) special.Add("Hold Onions");
                return special.ToArray();
            }
        }
    }
}
