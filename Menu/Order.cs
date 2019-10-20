using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that deals with price and items in an order
    /// </summary>
    public class Order
    {
        // Backing Variable
        private double subtotalCost;
        private ObservableCollection<IOrderItem> items;

        /// <summary>
        /// Represents the items added to the Order
        /// </summary>
        public ObservableCollection<IOrderItem> Items {
            get { return items; }
            set { items = value; }
        }

        /// <summary>
        /// Property that gets the Subtotal Cost of the order
        /// </summary>
        public double SubtotalCost { 
            get
            {
                foreach(IOrderItem order in Items)
                {
                    subtotalCost += order.Price;
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
        public double SalesTaxRate { get; protected set; } = 3.0;

        /// <summary>
        /// Propterty that gets the Sales Tax Cost of the order
        /// </summary>
        public double SalesTaxCost { get { return SalesTaxRate * SubtotalCost; } }

        /// <summary>
        /// Property that gets the Total Cost of the Order
        /// </summary>
        public double TotalCost { get { return SubtotalCost + SalesTaxCost; } }
    }
}
