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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        //Backing variable
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for CustomizeVelociWrap
        /// </summary>
        /// <param name="trex"> the VelociWrap entree </param>
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            combo = new CretaceousCombo(vw);
        }

        /// <summary>
        /// Event handler for Hold Dressing
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldDressing(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is VelociWrap vw)
            {
                vw.HoldDressing();
            }
        }

        /// <summary>
        /// Event handler for Hold Lettuce
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldLettuce(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is VelociWrap vw)
            {
                vw.HoldLettuce();
            }
        }

        /// <summary>
        /// Event handler for Hold Cheese
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldCheese(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is VelociWrap vw)
            {
                vw.HoldCheese();
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
