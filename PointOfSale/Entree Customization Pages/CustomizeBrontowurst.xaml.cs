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
        private Brontowurst bw;
        public CustomizeBrontowurst(Brontowurst bw)
        {
            InitializeComponent();
            this.bw = bw;
        }

        /// <summary>
        /// Event handler for Hold Bun
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldBun(object sender, RoutedEventArgs args)
        {
            bw.HoldBun();
        }

        /// <summary>
        /// Event handler for Hold Peppers
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldPeppers(object sender, RoutedEventArgs args)
        {
            bw.HoldPeppers();
        }

        /// <summary>
        /// Event handler for Hold Onions
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldOnions(object sender, RoutedEventArgs args)
        {
            bw.HoldOnions();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(bw));
        }
    }
}
