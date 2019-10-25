﻿/* Order.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that deals with price and items in an order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        // Backing Variable
        private double subtotalCost;
        private double salesTaxRate;

        /// <summary>
        /// PropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Represents the items added to the Order
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem[] Items { get { return items.ToArray(); } }

        /// <summary>
        /// Property that gets the Subtotal Cost of the order
        /// </summary>
        public double SubtotalCost { 
            get
            {
                subtotalCost = 0;
                {
                    foreach(IOrderItem item in Items)
                    {
                        subtotalCost += item.Price;
                    }
                }
                if (subtotalCost < 0)
                {
                    subtotalCost = 0;
                }
                return subtotalCost;
            }
        }

        /// <summary>
        /// Gets and protectedly sets the Sales Tax Rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return salesTaxRate; }
            set
            {
                if (value < 0) return;
                salesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// Property that gets the Sales Tax Cost of the order
        /// </summary>
        public double SalesTaxCost { get { return SalesTaxRate * SubtotalCost; } }

        /// <summary>
        /// Property that gets the Total Cost of the Order
        /// </summary>
        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }

        /// <summary>
        /// Constructor for Order
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }

        /// <summary>
        /// OnCollectionChanged event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
