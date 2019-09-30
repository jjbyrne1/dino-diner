/*  PterodactylWings.cs
 *  Author: Jason Byrne
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Entree and stores the price, calories, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class PterodactylWings : Entree
    {

        /// <summary>
        /// Creates an new instance of the PterodactylWings Entree and stores its price
        /// and calorie count.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        /// <summary>
        /// Overrides the Ingredients property from Entree and checks what ingredients are included 
        /// in the meal then puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken" , "Wing Sauce" };
            }
        }
    }
}
