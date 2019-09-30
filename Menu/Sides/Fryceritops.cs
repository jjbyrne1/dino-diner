/*  Fryceritops.cs
 *  Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Side, stores the ingredients, and updates the 
    /// price and calories depending on the Size of the side.
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// Overrides the Size property from Side, gets the size, and sets the price
        /// and calories based on the size.
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// Creates an new instance of the Fyceritops side and starts with 
        /// the default price and calories for size small with all base ingredients.
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            ingredients.Add("Potato");
            ingredients.Add("Salt");
            ingredients.Add("Vegetable Oil");
        }
    }
}
