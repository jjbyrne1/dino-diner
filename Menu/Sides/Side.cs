﻿/*  Side.cs
*   Author: Nathan Bean
*   Modified by: Jason Byrne
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a abstract class that includes propterties for setting the Price,
    /// Calories, Ingredients, and Size for all classes inheriting from this one.
    /// </summary>
    public abstract class Side : IMenuItem
    {
        /// <summary>
        /// Creates a protected size that allow only inherited members to modify
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// Creates a protected list ingredients that allow only inherited classes to modify.
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public virtual uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public virtual Size Size { get; set; }
    }
}
