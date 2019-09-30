/* Tyrannotea.cs
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
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// Gets or sets if sugar is added, default is false
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// Gets or sets if a lemon is added, defualt is false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Creates an new instance of the Tyrranotea drink and starts with 
        /// the default price and calories for size small with all base ingredients.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
        }

        /// <summary>
        /// Gets the size or sets the new size and adjusts the price
        /// and calories accordingly
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
        }

        /// <summary>
        /// Adds Lemon to beverage and adds it to the ingredients list
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

        /// <summary>
        /// Adds Sweet, adjusts the calories to account for
        /// the added Sweet, and adds it to the ingredients list
        /// </summary>
        public void AddSweet()
        {
            Sweet = true;
            Calories *= 2;
            ingredients.Add("Cane Sugar");
        }

        /// <summary>
        /// Removes sweet, adjusts the calories to account for
        /// the removal of Sweet, and removes it from the ingredients list
        /// </summary>
        public void RemoveSweet()
        {
            Sweet = false;
            Calories /= 2;
            ingredients.Remove("Cane Sugar");
        }
    }
}
