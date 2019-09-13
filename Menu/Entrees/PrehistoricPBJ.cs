﻿/*  PrehistoricPBJ.cs
*   Author: Nathan Bean
*   Modified by: Jason Byrne
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// 
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// Keeps track of if peanut butter is on the entre
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Keeps track of if jelly is on the entre
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Keeps track of the price of the entre
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Keeps track of the calories of the entre
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Checks what ingredients are included in the meal and puts them in a list
        /// </summary>
        public List<string> Ingredients
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
        /// Creates an instance of the entre and stores its price and calorie count
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// Removes the peanut butter from the ingredients list for this instance
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        /// <summary>
        /// Removes the jelly from the ingredients list for this instance
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    }
}
