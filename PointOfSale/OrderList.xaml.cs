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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// Constructor for OrderList
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// RemoveItem event handler
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// OnSelectionChanged event handler
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService.Navigate(new SideSelection(side));
            }
            else if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService.Navigate(new DrinkSelection(drink));
            }
            else if (OrderItems.SelectedItem is Entree entree)
            {
                if (entree is Brontowurst bw) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeBrontowurst(bw));
                else if (entree is DinoNuggets dn) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeDinoNuggets(dn));
                else if (entree is PrehistoricPBJ pbj) NavigationService.Navigate(new Entree_Customization_Pages.CustomizePrehistoricPBJ(pbj));
                else if (entree is PterodactylWings pw) NavigationService.Navigate(new Entree_Customization_Pages.CustomizePterodactylWings(pw));
                else if (entree is SteakosaurusBurger sb) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeSteakosaurusBurger(sb));
                else if (entree is TRexKingBurger trex) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeTRexKingBurger(trex));
                else if (entree is VelociWrap vw) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeVelociWrap(vw));
            }
            else if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                if (combo.Entree is Brontowurst) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeBrontowurst(combo));
                else if (combo.Entree is DinoNuggets) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeDinoNuggets(combo));
                else if (combo.Entree is PrehistoricPBJ) NavigationService.Navigate(new Entree_Customization_Pages.CustomizePrehistoricPBJ(combo));
                else if (combo.Entree is PterodactylWings) NavigationService.Navigate(new Entree_Customization_Pages.CustomizePterodactylWings(combo));
                else if (combo.Entree is SteakosaurusBurger) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeSteakosaurusBurger(combo));
                else if (combo.Entree is TRexKingBurger) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeTRexKingBurger(combo));
                else if (combo.Entree is VelociWrap) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeVelociWrap(combo));
            }
        }
    }
}
