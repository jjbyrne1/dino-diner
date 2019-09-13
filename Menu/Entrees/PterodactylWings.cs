/*  PterodactylWings.cs
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
    public class PterodactylWings
    {
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
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken" , "Wing Sauce" };
            }
        }
    }
}
