/* Drink.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Creates a Size enumerator with possible values Small, Medium, or Large.
    /// </summary>
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// 
        /// </summary>
        protected Size size = Size.Small;
        /// <summary>
        /// Creates a protected list ingredients that allow only inherited classes to modify.
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Get or sets the Price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the Calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size, default is small
        /// </summary>
        public virtual Size Size { get { return size; } set { size = value; } }

        /// <summary>
        /// Gets and sets if Ice is included, default is true
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Changes the Ice property to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
