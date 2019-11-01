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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;
        public ComboSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Brontowurst Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectBrontowurstCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            
        }

        /// <summary>
        /// Event handler for when the Dino-Nuggets Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            //NavigationService.Navigate(new CustomizeCombo(new DinoNuggets()));
        }

        /// <summary>
        /// Event handler for when the Steakosaurus Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSteakosaurusCombo(object sender, RoutedEventArgs args)
        {
           // NavigationService.Navigate(new CustomizeCombo(new SteakosaurusBurger()));
        }

        /// <summary>
        /// Event handler for when the T-Rex King Burger Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            //NavigationService.Navigate(new CustomizeCombo(new TRexKingBurger()));
        }

        /// <summary>
        /// Event handler for when the Prehistoric PB&J Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            //NavigationService.Navigate(new CustomizeCombo(new PrehistoricPBJ()));
        }

        /// <summary>
        /// Event handler for when the Pterodactyl Wings Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            //NavigationService.Navigate(new CustomizeCombo(new PterodactylWings()));
        }

        /// <summary>
        /// Event handler for when the Velici-Wrap Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectVeliciWrapCombo(object sender, RoutedEventArgs args)
        {
            //NavigationService.Navigate(new CustomizeCombo(new VelociWrap()));
        }
    }
}
