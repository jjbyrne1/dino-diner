/* Tyrannotea.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// 
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
        /// 
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingredients.Add("Water");
            ingredients.Add("Tea");
            if (Lemon)
            {
                ingredients.Add("Lemon");
            }
            if (Sweet)
            {
                Calories *= 2;
                ingredients.Add("Cane Suger");
            }
        }

        /// <summary>
        /// 
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

    }
}
