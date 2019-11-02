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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        //Backing variable
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for CustomizeTRexKingBurger
        /// </summary>
        /// <param name="trex"> the T-Rex King Burger entree </param>
        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            combo = new CretaceousCombo(trex);
        }

        /// <summary>
        /// Event handler for Hold Bun
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldBun(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldBun();
            }
        }

        /// <summary>
        /// Event handler for Hold Lettuce
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldLettuce();
            }
        }

        /// <summary>
        /// Event handler for Hold Tomato
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldTomato(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldTomato();
            }
        }

        /// <summary>
        /// Event handler for Hold Onion
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldOnion(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldOnion();
            }
        }

        /// <summary>
        /// Event handler for Hold Pickle
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldPickle(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldPickle();
            }
        }

        /// <summary>
        /// Event handler for Hold Ketchup
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldKetchup(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldKetchup();
            }
        }

        /// <summary>
        /// Event handler for Hold Mustard
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldMustard(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldMustard();
            }
        }

        /// <summary>
        /// Event handler for Hold Mayo
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldMayo(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is TRexKingBurger trex)
            {
                trex.HoldMayo();
            }
        }

        /// <summary>
        /// Event handler for SelectDone
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> event arguments </param>
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(combo));
        }
    }
}
