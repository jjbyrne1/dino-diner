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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Cherry Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectCherryFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length-1] is Sodasaurus s)
                {
                     s.Flavor = SodasaurusFlavor.Cherry;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for when the Chocolate Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectChocolateFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Chocolate;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for when the Cola Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectColaFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Cola;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for when the Lime Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectLimeFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Lime;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for when the Orange Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectOrangeFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Orange;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for when the Root Beer Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectRootBeerFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.RootBeer;
                }
            }
            NavigationService.GoBack();
        }

        /// <summary>
        /// Event handler for when the Vanilla Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectVanillaFlavor(object sender, RoutedEventArgs args)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (order.Items[order.Items.Length - 1] is Sodasaurus s)
                {
                    s.Flavor = SodasaurusFlavor.Vanilla;
                }
            }
            NavigationService.GoBack();
        }
    }
}
