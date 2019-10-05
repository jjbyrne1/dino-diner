/* Water.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
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
        /// Overrides the ToString method to retrun the name of the item and its size
        /// </summary>
        /// <returns> name of the item with size </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append(" Water");
            return sb.ToString();
        }

        /// <summary>
        /// Overrides the ingredients property from Drink and checks what ingredients
        /// are included in the beverage and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water"};
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
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
