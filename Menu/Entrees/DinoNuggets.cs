using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint numOfNuggets = 6;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public DinoNuggets()
        {
            this.Price = 4.25 + .25*(numOfNuggets-6);
            this.Calories = 59 * numOfNuggets;
        }

        public List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Chicken Nugget" };
            }
        }

        public void AddNugget()
        {
            this.numOfNuggets++;
        }
    }
}
