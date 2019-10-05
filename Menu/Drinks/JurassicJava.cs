using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class that inherits from Drink and stores the price, calories, sizes, and 
    /// updates ingredients depending on the customer's requests.
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// Gets or sets if there is space for cream, default is false
        /// </summary>
        public bool SpaceForCream { get; set; } = false;

        /// <summary>
        /// Gets or sets if there is decaf default is false
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Gets or sets if there is ice, overrides default to false
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Creates an new instance of the JurrasicJava drink and starts with 
        /// the default price and calories for size small with all base ingredients.
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
        }

        /// <summary>
        /// Overrides the ToString method to retrun the name of the item, its size, and
        /// its specified additions
        /// </summary>
        /// <returns> name of the item with specified additions </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            if (Decaf)
            {
                sb.Append( " Decaf");
            }
            sb.Append(" Jurassic Java");
            return sb.ToString();
        }

        /// <summary>
        /// Overrides the ingredients property from Drink and checks what ingredients
        /// are included in the beverage and puts them in a list.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" , "Coffee" };
                if (Decaf) ingredients.Add("Decaf");
                return ingredients;
            }
        }

        /// <summary>
        /// Gets the size or sets the new size and adjusts the price
        /// and calories accordingly
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }
        }

        /// <summary>
        /// Leaves space for cream in beverage
        /// </summary>
        public void LeaveSpaceForCream()
        {
            SpaceForCream = true;
        }

        /// <summary>
        /// Adds Ice to bevarage
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
