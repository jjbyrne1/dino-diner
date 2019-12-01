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
        public List<string> categories { get; set; } = new List<string>();

        [BindProperty]
        public float? minPrice { get; set; }

        [BindProperty]
        public float? maxPrice { get; set; }

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

            if (categories.Count != 0)
            {
                items = m.FilterByCategory(items, categories);
            }

            if (minPrice != null)
            {
                items = m.FilterByMinPrice(items, (float)minPrice);
            }

            if (maxPrice != null)
            {
                items = m.FilterByMaxPrice(items, (float)maxPrice);
            }
        }
    }
}