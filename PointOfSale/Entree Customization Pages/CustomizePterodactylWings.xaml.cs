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
        private PterodactylWings pw;
        private bool isCombo;

        /// <summary>
        /// Constructor for CustomizePterodactylWings for entree
        /// </summary>
        /// <param name="pw"> the Pterodactyl Wings entree </param>
        public CustomizePterodactylWings(PterodactylWings pw)
        {
            InitializeComponent();
            this.pw = pw;
            isCombo = false;
        }

        /// <summary>
        /// Constructor for CustomizePterodactylWings for combo
        /// </summary>
        /// <param name="combo"> the combo </param>
        public CustomizePterodactylWings(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Event handler for SelectDone
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> event arguments </param>
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
