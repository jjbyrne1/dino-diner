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
        private PrehistoricPBJ pbj;

        /// <summary>
        /// Constructor for CustomizePrehistoricPBJ
        /// </summary>
        /// <param name="pbj"> the prehistoric PBJ entree </param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Event handler for Hold Peanut Butter
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }

        /// <summary>
        /// Event handler for Hold Peanut Butter
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new CustomizeCombo(pbj));
        }
    }
}
