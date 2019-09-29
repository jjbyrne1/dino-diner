/*  SodasaurusTest.cs
 *  Author: Jason Byrne
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
    public class Sodasaurus : Drink
    {
        //private Size size = Size.Small;
        private SodasaurusFlavor flavor;

        /// <summary>
        /// Gets flavor or sets flavor to the new flavor
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Creates an new instance of the Sodasaurus drink and starts with 
        /// the default price and calories for size small with all base ingredients.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
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
                switch(size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        //size = Size.Small;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                       // size = Size.Medium;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                       // size = Size.Large;
                        break;
                }
            }
        }
    }
}
