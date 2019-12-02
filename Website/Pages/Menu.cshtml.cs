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

        public List<IMenuItem> items;

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
                items = m.Search(items, search);
            }

            if (menuCategory.Count != 0)
            {
                items = m.FilterByCategory(items, menuCategory);
            }

            if (minimumPrice != null)
            {
                items = m.FilterByMinPrice(items, (float)minimumPrice);
            }

            if (maximumPrice != null)
            {
                items = m.FilterByMaxPrice(items, (float)maximumPrice);
            }

            if(ingredients.Count != 0) {
                items = m.FilterByIngredients(items, ingredients);
            }
        }
    }
}