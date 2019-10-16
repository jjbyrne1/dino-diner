/*  DinoNuggets.cs
 *  Author: Jason Byrne
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Function that creates an entre and stores the price, calories, number of nuggets,
    /// and updates ingredients depending on the customer's requests.
    /// </summary>
    public class DinoNuggets : Entree, IOrderItem, INotifyPropertyChanged
    {
        //Backing Variables
        private uint nuggetCount = 6;

        /// <summary>
        /// An event handler for PropertyChanged events for the fields or properties
        /// description, special, or price
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Creates an new instance of the DinonNuggets Entree and stores its price and 
        /// calorie count.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggetCount;
        }

        /// <summary>
        /// Overrides the ToString method to retrun the name of the item
        /// </summary>
        /// <returns> name of the item </returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Overrides the ingredients property from Entree and checks what ingredients
        /// are included in the meal and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Adds another nugget to the ingredients list for this instance. Also updates the price
        /// and calorie amounts.
        /// </summary>
        public void AddNugget()
        {
            this.nuggetCount++;
            this.Calories += 59;
            this.Price += .25;
        }

        /// <summary>
        /// Property that gets the menu item's name
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Property that gets an array of all the special demands for the
        /// specific entree
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add("Added " + nuggetCount - 6 + " Nuggets");
                return special.ToArray();
            }
        }
    }
}
