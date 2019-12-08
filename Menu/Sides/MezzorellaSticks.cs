﻿/*  MezzorellaSticks.cs
 *  Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Side, stores the ingredients, and updates the 
    /// price and calories depending on the Size of the side.
    /// </summary>
    public class MezzorellaSticks : Side
    {

        /// <summary>
        /// Overrides the Size property from Side, gets the size, and sets the price
        /// and calories based on the size.
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
                switch(size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Creates an new instance of the MezzorellaSticks side and starts with 
        /// the default price and calories for size small with all base ingredients.
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
        }

        /// <summary>
        /// Overrides the ingredients property from Side and checks what ingredients
        /// are included in the side and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Cheese Product", "Breading", "Vegetable Oil" };
            }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item and its size
        /// </summary>
        /// <returns> name of the item with size </returns>
        public override string ToString()
        {
            return Size + " Mezzorella Sticks";
        }

        /// <summary>
        /// Simply returns the name of the item
        /// </summary>
        public override string Name { get { return "Mezzorella Sticks"; } }

        /// <summary>
        /// Property that gets the menu item's name
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// Property that gets an array of all the special instructions for the
        /// specific side
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
