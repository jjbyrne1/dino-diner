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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        //Backing Variable
        private CretaceousCombo combo;
        private Brontowurst bw;
        private bool isCombo;

        /// <summary>
        /// Constructor for CustomizeBrontowurst for entree
        /// </summary>
        /// <param name="bw"> the entree for the combo </param>
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
            isCombo = false;
        }

        /// <summary>
        /// Constructor for CustomizeBrontowurst for entree
        /// </summary>
        /// <param name="combo"></param>
        public CustomizeBrontowurst(CretaceousCombo combo)
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
            if (combo.Entree is Brontowurst bw) bw.HoldBun();
            else this.bw.HoldBun();
        }

        /// <summary>
        /// Event handler for Hold Peppers
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldPeppers(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst bw) bw.HoldPeppers();
            else this.bw.HoldPeppers();
        }

        /// <summary>
        /// Event handler for Hold Onions
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldOnion(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst bw) bw.HoldOnion();
            else this.bw.HoldOnion();
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
