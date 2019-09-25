/*  SodasaurusTest.cs
 *  Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        //private Size size = Size.Small;
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }

        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
        }

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
                        Price = 1.50;
                        Calories = 112;
                        //size = Size.Small;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                       // size = Size.Medium;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                       // size = Size.Large;
                        break;
                }
            }
        }
    }
}
