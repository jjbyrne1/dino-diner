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
        //Backing Variable
        private bool lemon = false;

        /// <summary>
        /// Gets or sets the lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }

            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Creates an new instance of the Water drink and starts with 
        /// the default price and calories for size small
        /// </summary>
        public Water()
        {
            Price = 0.1;
            Calories = 0;
        }

        /// <summary>
        /// Overrides the ingredients property from Drink and checks what ingredients
        /// are included in the beverage and puts them in a list
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

        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Adds Lemon to beverage
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item and its size
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
        /// Gets the name of the item
        /// </summary>
        public override string Name { get { return "Water"; } }

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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
