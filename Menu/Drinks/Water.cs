/* Water.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class that inherits from Drink and stores the price, calories, sizes, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets or sets the lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Creates an new instance of the Water drink and starts with 
        /// the default price and calories for size small with all base ingredients.
        /// </summary>
        public Water()
        {
            Price = 0.1;
            Calories = 0;
            Ingredients.Add("Water");
        }

        /// <summary>
        /// Adds Lemon to beverage and adds it to the ingredients list
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            Ingredients.Add("Lemon");
        }

    }
}
