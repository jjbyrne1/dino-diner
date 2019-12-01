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

        /// <summary>
        /// List of every menu item available
        /// </summary>
        public List<IMenuItem> All { get { return AvailableMenuItems; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public List<IMenuItem> Search(List<IMenuItem> items, string searchString)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem item in items)
            {
                if (item is Entree e)
                {
                    if (e.Description.Contains(searchString))
                    {
                        results.Add(e);
                    }
                }

                if (item is CretaceousCombo c)
                {
                    if (c.Description.Contains(searchString))
                    {
                        results.Add(c);
                    }
                }

                if (item is Drink d)
                {
                    if (d.Description.Contains(searchString))
                    {
                        results.Add(d);
                    }
                }

                if (item is Side s)
                {
                    if (s.Description.Contains(searchString))
                    {
                        results.Add(s);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMinPrice(List<IMenuItem> items, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (minPrice <= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="maxPrice"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByMaxPrice(List<IMenuItem> items, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (maxPrice >= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"> list of menu items </param>
        /// <param name="categories"> list of categories to search for </param>
        /// <returns> List of menu items in the specified search categories </returns>
        public List<IMenuItem> FilterByCategory(List<IMenuItem> items, List<string> categories)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                if (categories.Contains("combo"))
                {
                    if (item is CretaceousCombo c)
                    {
                        results.Add(c);
                    }
                }
                else if (categories.Contains("entree"))
                {
                    if(item is Entree e)
                    {
                        results.Add(e);
                    }
                }
                else if(categories.Contains("drink"))
                {
                    if (item is Drink d)
                    {
                        results.Add(d);
                    }
                }
                else if (categories.Contains("side"))
                {
                    if (item is Side s)
                    {
                        results.Add(s);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public List<IMenuItem> FilterByIngredients(List<IMenuItem> items, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in items)
            {
                foreach(string ingredient in ingredients)
                {
                    if(item.Ingredients.Contains(ingredient))
                    {
                        results.Add(item);
                        break;
                    }
                }
            }
            return results;
        }
    }
}
