/*  DinoNuggets.cs
 *  Author: Jason Byrne
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Function that creates an entre and stores the price, calories, number of nuggets,
    /// and updates ingredients depending on the customer's requests.
    /// </summary>
    public class DinoNuggets : Entree
    {
        //Backing Variables
        private uint nuggetCount = 6;

        /// <summary>
        /// Property that gets the number of nuggets
        /// </summary>
        public uint NuggetCount { get { return nuggetCount; } }

        /// <summary>
        /// Creates an new instance of the DinonNuggets Entree and stores its price and 
        /// calorie count.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
        }

        /// <summary>
        /// Overrides the ingredients property from Entree and checks what ingredients
        /// are included in the meal and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds another nugget to the ingredients list for this instance. Also updates the price
        /// and calorie amounts.
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount++;
            this.Calories += 59;
            this.Price += .25;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item
        /// </summary>
        /// <returns> name of the item </returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Property that gets the menu item's name
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Gets the name of the item
        /// </summary>
        public override string Name { get { return Description; } }

    /// <summary>
    /// Property that gets an array of all the special instructions for the
    /// specific entree
    /// </summary>
    public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggetCount > 6) special.Add(nuggetCount - 6 + " Extra Nuggets");
                return special.ToArray();
            }
        }

    }
}
