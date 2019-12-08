/*  Entree.cs
 *  Author: Jason Byrne
 */
using System.Collections.Generic;
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
        /// Gets the name of the item
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the Special Specifications
        /// </summary>
        /// <returns></returns>
        public virtual string[] Special { get;}

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
