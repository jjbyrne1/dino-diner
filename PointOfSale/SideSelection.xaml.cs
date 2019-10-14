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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Size size;
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Fryceritops Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectFryceritopsSide(object sender, RoutedEventArgs args)
        {
            FryceritopsButton.IsEnabled = false;
            MeteorMacAndCheeseButton.IsEnabled = true;
            MezzorellaSticksButton.IsEnabled = true;
            TriceritotsButton.IsEnabled = true;

            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the Meteor Mac and Cheese Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMeteorMacAndCheeseSide(object sender, RoutedEventArgs args)
        {
            FryceritopsButton.IsEnabled = true;
            MeteorMacAndCheeseButton.IsEnabled = false;
            MezzorellaSticksButton.IsEnabled = true;
            TriceritotsButton.IsEnabled = true;

            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the Mezzorella Sticks Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMezzorellaSticksSide(object sender, RoutedEventArgs args)
        {
            FryceritopsButton.IsEnabled = true;
            MeteorMacAndCheeseButton.IsEnabled = true;
            MezzorellaSticksButton.IsEnabled = false;
            TriceritotsButton.IsEnabled = true;

            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the Triceritots Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectTriceritotsSide(object sender, RoutedEventArgs args)
        {
            FryceritopsButton.IsEnabled = true;
            MeteorMacAndCheeseButton.IsEnabled = true;
            MezzorellaSticksButton.IsEnabled = true;
            TriceritotsButton.IsEnabled = false;

            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when Small Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSmall(object sender, RoutedEventArgs args)
        {
            size = Size.Small;
            SmallButton.IsEnabled = false;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the Medium Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMedium(object sender, RoutedEventArgs args)
        {
            size = Size.Medium;
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = false;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the Large size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectLarge(object sender, RoutedEventArgs args)
        {
            size = Size.Large;
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = false;
        }
    }
}
