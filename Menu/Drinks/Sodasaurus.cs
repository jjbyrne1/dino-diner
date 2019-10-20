/*  SodasaurusTest.cs
 *  Author: Jason Byrne
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
    public class Sodasaurus : Drink
    {
        //private Size size = Size.Small;
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Gets flavor or sets flavor to the new flavor
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { 
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Creates an new instance of the Sodasaurus drink and starts with 
        /// the default price and calories for size small
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
        }

        /// <summary>
        /// Overrides the ingredients property from Drink and checks what ingredients
        /// are included in the beverage and puts them in a list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors" , "Cane Sugar" };
            }
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item, its size, and
        /// its flavor
        /// </summary>
        /// <returns> name of the item with its flavor and size </returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " " + "Sodasaurus";
        }

        /// <summary>
        /// Property that gets the menu item's name
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Property that gets an array of all the special instructions for the
        /// specific drink
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
