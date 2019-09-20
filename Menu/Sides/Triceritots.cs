/*  Triceritots.cs
 *  Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Class that inherits from Side, stores the ingredients, and updates the 
    /// price and calories depending on the Size of the side.
    /// </summary>
    public class Triceritots : Side
    {
        // Backing variable
        private Size size;

        /// <summary>
        /// Overrides the Size property from Side, gets the size, and sets the price
        /// and calories based on the size.
        /// </summary>
        public override Size Size {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 362;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Creates an new instance of the Triceritots size and starts with 
        /// the default price and calories for small with all base ingredients.
        /// </summary>
        public Triceritots()
        {
            Price = .99;
            Calories = 352;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }
    }
}
