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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        //Backing Variable
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor for CustomizePrehistoricPBJ
        /// </summary>
        /// <param name="pbj"> the prehistoric PBJ entree </param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            combo = new CretaceousCombo(pbj);
        }

        /// <summary>
        /// Event handler for Hold Peanut Butter
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
        }

        /// <summary>
        /// Event handler for Hold Peanut Butter
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldJelly(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
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
