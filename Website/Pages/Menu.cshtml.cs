using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu m = new Menu();

        public IEnumerable<IMenuItem> items;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public float? minimumPrice { get; set; }

        [BindProperty]
        public float? maximumPrice { get; set; }

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        public void OnGet()
        {
            items = m.All;
        }

        public void OnPost()
        {
            items = m.All;
            if (search != null)
            {
                items = items.Where(item => item.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
                //items = m.Search(items, search);
            }

            if (menuCategory.Count != 0)
            {
                List<IMenuItem> itemList = new List<IMenuItem>();
                if (menuCategory.Contains("Combo"))
                {
                    itemList.AddRange(items.OfType<CretaceousCombo>());
                }
                if (menuCategory.Contains("Entree"))
                {
                    itemList.AddRange(items.OfType<Entree>());
                }
                if (menuCategory.Contains("Drink"))
                {
                    itemList.AddRange(items.OfType<Drink>());
                }
                if (menuCategory.Contains("Side"))
                {
                    itemList.AddRange(items.OfType<Side>());
                }
                items = itemList;
                //items = m.FilterByCategory(items, menuCategory);
            }

            if (minimumPrice != null)
            {
                items = items.Where(item => item.Price >= minimumPrice);
                //items = m.FilterByMinPrice(items, (float)minimumPrice);
            }

            if (maximumPrice != null)
            {
                items = items.Where(item => item.Price >= maximumPrice);
                //items = m.FilterByMaxPrice(items, (float)maximumPrice);
            }

            if(ingredients.Count != 0) {
                foreach(string ingredient in ingredients)
                {
                    items = items.Where(item => !item.Ingredients.Contains(ingredient));
                }
                //items = m.FilterByIngredients(items, ingredients);
            }
        }
    }
}