using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale.Entree_Customization_Pages
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        //Backing variable
        private CretaceousCombo combo;
        private SteakosaurusBurger sb;
        private bool isCombo;

        /// <summary>
        /// Constructor for CustomizeSteakosaurusBurger
        /// </summary>
        /// <param name="sb"> the Steakosaurus Burger entree </param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
            isCombo = false;
        }

        /// <summary>
        /// Constructor for CustomizeSteakosaurusBurger
        /// </summary>
        /// <param name="combo"> the Steakosaurus Burger combo </param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Event handler for Hold Bun
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldBun(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldBun();
            }
            else this.sb.HoldBun();
        }

        /// <summary>
        /// Event handler for Hold Pickle
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldPickle(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldPickle();
            }
            else this.sb.HoldPickle();
        }

        /// <summary>
        /// Event handler for Hold Ketchup
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldKetchup();
            }
            else this.sb.HoldKetchup();
        }

        /// <summary>
        /// Event handler for Hold Mustard
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldMustard(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is SteakosaurusBurger sb) sb.HoldMustard();
            }
            else this.sb.HoldMustard();
        }

        /// <summary>
        /// Event handler for SelectDone
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> event arguments </param>
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if(isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
