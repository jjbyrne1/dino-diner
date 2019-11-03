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
        //Backing variables
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for ComboSelection
        /// </summary>
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
                Brontowurst bw = new Brontowurst();
                combo = new CretaceousCombo(bw);
                order.Add(combo);
                NavigationService.Navigate(new Entree_Customization_Pages.CustomizeBrontowurst(combo));
            }
        }

        /// <summary>
        /// Event handler for when the Dino-Nuggets Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectDinoNuggetsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                combo = new CretaceousCombo(dn);
                order.Add(combo);
                NavigationService.Navigate(new Entree_Customization_Pages.CustomizeDinoNuggets(combo));
            }
        }

        /// <summary>
        /// Event handler for when the Steakosaurus Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSteakosaurusCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                combo = new CretaceousCombo(sb);
                order.Add(combo);
                NavigationService.Navigate(new Entree_Customization_Pages.CustomizeSteakosaurusBurger(combo));
            }
        }

        /// <summary>
        /// Event handler for when the T-Rex King Burger Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectTRexKingBurgerCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger trex = new TRexKingBurger();
                combo = new CretaceousCombo(trex);
                order.Add(combo);
                NavigationService.Navigate(new Entree_Customization_Pages.CustomizeTRexKingBurger(combo));
            }
        }

        /// <summary>
        /// Event handler for when the Prehistoric PB&J Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectPrehistoricPBJCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                combo = new CretaceousCombo(pbj);
                order.Add(combo);
                NavigationService.Navigate(new Entree_Customization_Pages.CustomizePrehistoricPBJ(combo));
            }
        }

        /// <summary>
        /// Event handler for when the Pterodactyl Wings Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectPterodactylWingsCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PterodactylWings wings = new PterodactylWings();
                combo = new CretaceousCombo(wings);
                order.Add(combo);
                NavigationService.Navigate(new Entree_Customization_Pages.CustomizePterodactylWings(combo));
            }
        }

        /// <summary>
        /// Event handler for when the Velici-Wrap Combo button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectVeliciWrapCombo(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                VelociWrap wrap = new VelociWrap();
                combo = new CretaceousCombo(wrap);
                order.Add(combo);
                //NavigationService.Navigate(new Entree_Customization_Pages.CustomizeVelociWrap(combo));
            }
        }
    }
}
