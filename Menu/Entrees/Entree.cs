/*  Entree.cs
 *  Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// List of ingredients for the entree
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets the item desctiption
        /// </summary>
        /// <returns></returns>
        public virtual string Description { get;}

        /// <summary>
        /// Gets the Special Specifications
        /// </summary>
        /// <returns></returns>
        public virtual string[] Special { get;}

        /// <summary>
        /// An event handler for PropertyChanged events for the fields or properties
        /// description, special, or price
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
