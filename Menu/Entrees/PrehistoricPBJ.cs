/*  PrehistoricPBJ.cs
 *  Author: Nathan Bean
 *  Modified by: Jason Byrne
 */

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class that inherits from Entree and stores the price, calories, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class PrehistoricPBJ : Entree
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
        }

        /// <summary>
        /// Removes the jelly from the ingredients list for this instance.
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
