/* Menu.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class Menu
    {
        /// <summary>
        /// Returns a list containing one instance of every menu item
        /// currently offered by DinoDiner
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                menuItems.AddRange(AvailableEntrees);
                menuItems.AddRange(AvailableSides);
                menuItems.AddRange(AvailableDrinks);
                return menuItems;
            }
        }

        /// <summary>
        /// Returns a list of all available entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availableEntrees = new List<IMenuItem>();
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new PterodactylWings());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());
                return availableEntrees;
            }
        }

        /// <summary>
        /// Returns a list of all available sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availableSides = new List<IMenuItem>();
                availableSides.Add(new Fryceritops());
                availableSides.Add(new MeteorMacAndCheese());
                availableSides.Add(new MezzorellaSticks());
                availableSides.Add(new Triceritots());
                return availableSides;
            }
        }

        /// <summary>
        /// Returns a list of all available drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availableDrinks = new List<IMenuItem>();
                availableDrinks.Add(new JurassicJava());
                availableDrinks.Add(new Sodasaurus());
                availableDrinks.Add(new Tyrannotea());
                availableDrinks.Add(new Water());
                return availableDrinks;
            }
        }

        /// <summary>
        /// Returns a list of all available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>();
                availableCombos.Add(new CretaceousCombo(new Brontowurst()));
                availableCombos.Add(new CretaceousCombo(new DinoNuggets()));
                availableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availableCombos.Add(new CretaceousCombo(new PterodactylWings()));
                availableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                availableCombos.Add(new CretaceousCombo(new VelociWrap()));
                return availableCombos;
            }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the item
        /// </summary>
        /// <returns> string of menu items </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                sb.Append(menuItem + "\n");
            }
            return sb.ToString();
        }
    }
}
