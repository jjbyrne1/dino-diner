/* IOrderItem.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the special list
        /// </summary>
        string[] Special { get; }        
    }
}
