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
    /// Interaction logic for CustomizePterodactylWings.xaml
    /// </summary>
    public partial class CustomizePterodactylWings : Page
    {
        //Backing variable
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for CustomizePterodactylWings
        /// </summary>
        /// <param name="pw"> the Pterodactyl Wings entree </param>
        public CustomizePterodactylWings(PterodactylWings pw)
        {
            InitializeComponent();
            combo = new CretaceousCombo(pw);
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
