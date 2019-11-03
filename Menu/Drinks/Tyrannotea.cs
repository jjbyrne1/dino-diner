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
        //Backing Variables
        private bool sweet = false;
        private bool lemon = false;

        /// <summary>
        /// Gets or sets if sugar is added
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }

            set
            {
                sweet = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Gets or sets if a lemon is added
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }

            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Creates an new instance of the Tyrranotea drink and starts with 
        /// the default price and calories for size small
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
        }

        /// <summary>
        /// Overrides the ingredients property from Drink and checks what ingredients
        /// are included in the beverage and puts them in a list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Sweet) ingredients.Add("Cane Sugar");
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
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
        /// Adds Sweet, adjusts the calories to account for
        /// the added Sweet
        /// </summary>
        public void AddSweet()
        {
            Sweet = true;
            Calories *= 2;
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// Removes sweet, adjusts the calories to account for
        /// the removal of Sweet
        /// </summary>
        public void RemoveSweet()
        {
            Sweet = false;
            Calories /= 2;
            NotifyOfPropertyChanged("Description");
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item, its size, and
        /// its specified additions
        /// </summary>
        /// <returns> name of the item with specified additions </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            if (Sweet)
            {
                sb.Append(" Sweet");
            }
            else sb.Append(" Unsweet");
            sb.Append(" Tyrannotea");
            return sb.ToString();
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
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
