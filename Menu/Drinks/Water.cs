using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// Gets or sets the lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        public Water()
        {
            Price = 0.1;
            Calories = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
