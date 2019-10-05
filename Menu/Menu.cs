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
                menuItems.Add(new Brontowurst());
                menuItems.Add(new DinoNuggets());
                menuItems.Add(new PrehistoricPBJ());
                menuItems.Add(new PterodactylWings());
                menuItems.Add(new SteakosaurusBurger());
                menuItems.Add(new TRexKingBurger());
                menuItems.Add(new VelociWrap());
                menuItems.Add(new Fryceritops());
                menuItems.Add(new MeteorMacAndCheese());
                menuItems.Add(new MezzorellaSticks());
                menuItems.Add(new Triceritots());
                menuItems.Add(new JurassicJava());
                menuItems.Add(new Sodasaurus());
                menuItems.Add(new Tyrannotea());
                menuItems.Add(new Water());
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
                if (AvailableMenuItems.Contains(new Brontowurst())) {
                    availableEntrees.Add(new Brontowurst());
                }
                if (AvailableMenuItems.Contains(new DinoNuggets()))
                {
                    availableEntrees.Add(new DinoNuggets());
                }
                if (AvailableMenuItems.Contains(new PrehistoricPBJ()))
                {
                    availableEntrees.Add(new PrehistoricPBJ());
                }
                if (AvailableMenuItems.Contains(new PterodactylWings()))
                {
                    availableEntrees.Add(new PterodactylWings());
                }
                if (AvailableMenuItems.Contains(new SteakosaurusBurger()))
                {
                    availableEntrees.Add(new SteakosaurusBurger());
                }
                if (AvailableMenuItems.Contains(new TRexKingBurger()))
                {
                    availableEntrees.Add(new TRexKingBurger());
                }
                if (AvailableMenuItems.Contains(new VelociWrap()))
                {
                    availableEntrees.Add(new VelociWrap());
                }
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
                if (AvailableMenuItems.Contains(new Fryceritops()))
                {
                    availableSides.Add(new Fryceritops());
                }
                if (AvailableMenuItems.Contains(new MeteorMacAndCheese()))
                {
                    availableSides.Add(new MeteorMacAndCheese());
                }
                if (AvailableMenuItems.Contains(new MezzorellaSticks()))
                {
                    availableSides.Add(new MezzorellaSticks());
                }
                if (AvailableMenuItems.Contains(new Triceritots()))
                {
                    availableSides.Add(new Triceritots());
                }
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
                if (AvailableMenuItems.Contains(new JurassicJava()))
                {
                    availableDrinks.Add(new JurassicJava());
                }
                if (AvailableMenuItems.Contains(new Sodasaurus()))
                {
                    availableDrinks.Add(new Sodasaurus());
                }
                if (AvailableMenuItems.Contains(new Tyrannotea()))
                {
                    availableDrinks.Add(new Tyrannotea());
                }
                if (AvailableMenuItems.Contains(new Water()))
                {
                    availableDrinks.Add(new Water());
                }
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
                foreach (Entree entree in AvailableEntrees)
                {
                    CretaceousCombo combo = new CretaceousCombo(entree);
                    foreach (Side side in AvailableSides)
                    {
                        foreach (Drink drink in AvailableDrinks)
                        {
                            combo.Side = side;
                            combo.Drink = drink;
                            availableCombos.Add(combo);
                        }
                    }
                }
                return availableCombos;
            }
        }

        /// <summary>
        /// Overrides the ToString method to retrun the name of the item
        /// </summary>
        /// <returns></returns>
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
