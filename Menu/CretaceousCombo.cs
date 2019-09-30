/* CretaceousCombo.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        //Backing Variables
        private Size size = Size.Small;
        private Drink drink;
        private Side side;

        /// <summary>
        /// Gets or sets the entree
        /// </summary>
        public Entree Entree { get; set; }
        
        /// <summary>
        /// Gets or sets the drink
        /// </summary>
        public Drink Drink
        {
            get { return drink; }
            set
            {
                drink = value;
                drink.Size = size;
            }
        }
        
        /// <summary>
        /// Gets or sets the side
        /// </summary>
        public Side Side {
            get { return side; }
            set {
                side = value;
                side.Size = size;
            }
        }

        /// <summary>
        /// Gets the total price of the combo which is the sum fo the entree, side,
        /// and drink with the discount of $0.25
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the total calories of the combo which is the sum of the entree, side,
        /// and drink
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets the size or sets the Drink size and Side size to the desired size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = size;
                Side.Size = size;
            }
        }

        /// <summary>
        /// Gets all the ingredients in the Entree, Side, and Drink and adds them
        /// into a single list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a new instance of CretaceousCombo with the desired entree, 
        /// default side, and default drink
        /// </summary>
        /// <param name="entree"> Entree chosen for the combo </param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }
    }
}
