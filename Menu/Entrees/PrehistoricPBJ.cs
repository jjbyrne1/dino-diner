/*  PrehistoricPBJ.cs
 *  Author: Nathan Bean
 *  Modified by: Jason Byrne
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Entree and stores the price, calories, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class PrehistoricPBJ : Entree, IOrderItem
    {
        //Backing Variables
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Overrides the ingredients property from Entree and checks what ingredients
        /// are included in the meal and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates an new instance of the PrehistoricPBJ Entree and stores its price and
        /// calorie count.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes the peanut butter from the ingredients list for this instance.
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Removes the jelly from the ingredients list for this instance.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item
        /// </summary>
        /// <returns> name of the item </returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Property that gets the menu item's name
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Property that gets an array of all the special instructions for the
        /// specific entree
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }

    }
}
