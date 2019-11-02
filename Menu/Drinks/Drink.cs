/* Drink.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that stores the Price, Calories, Size, Ingredients list, and Ice property
    /// for all drinks
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Creates a protected size that allow only inherited members to modify
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// Creates a protected list ingredients that allow only inherited classes to modify
        /// </summary>
        protected List<string> ingredients = new List<string>();

        /// <summary>
        /// Get or sets the Price
        /// </summary>
        public virtual double Price { get; protected set; }

        /// <summary>
        /// Gets or sets the Calories
        /// </summary>
        public virtual uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size, default is small
        /// </summary>
        public virtual Size Size { get { return size; } set { size = value; } }

        /// <summary>
        /// Gets and sets if Ice is included, default is true
        /// </summary>
        public virtual bool Ice { get; protected set; } = true;

        /// <summary>
        /// Changes the Ice property to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Changes the Ice property to true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }

    /// <summary>
    /// Gets the item desctiption
    /// </summary>
    /// <returns></returns>
    public virtual string Description { get; }

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
