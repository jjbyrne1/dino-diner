/*  DinoNuggets.cs
*   Author: Jason Byrne
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates an entre and stores the price, calories, and number of nuggets,
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// Keeps track of how many nuggets are included in the entre
        /// </summary>
        private uint nuggetCount = 6;

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
        public DinoNuggets()
        {
            this.Price = 4.25 + .25*(nuggetCount - 6);
            this.Calories = 59 * nuggetCount;
        }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
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
        /// Adds another nugget to the ingredients list for this instance
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount++;
        }
    }
}
