﻿/*  PterodactylWings.cs
 *  Author: Jason Byrne
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Entree and stores the price, calories, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class PterodactylWings : Entree, INotifyPropertyChanged
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
        /// An event handler for PropertyChanged events for the fields or properties
        /// description, special, or price
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Overrides the ToString method to retrun the name of the item
        /// </summary>
        /// <returns> name of the item </returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
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
