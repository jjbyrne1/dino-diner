/*  Side.cs
*   Author: Nathan Bean
*   Modified by: Jason Byrne
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates a abstract class that includes propterties for setting the Price,
    /// Calories, Ingredients, and Size for all classes inheriting from this one.
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
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

        /// <summary>
        /// Gets the item desctiption
        /// </summary>
        /// <returns></returns>
        public virtual string Description { get; }

        /// <summary>
        /// Simply returns the name of the item
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the Special Specifications
        /// </summary>
        /// <returns></returns>
        public virtual string[] Special { get; }

        /// <summary>
        /// Property Changed Event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event handler for NotifyOfPropertyChanged
        /// </summary>
        /// <param name="propertyName"> name of property that changed </param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
