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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public bool flavor = false;
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Sodasurus Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSodasurusDrink(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Visible;
            flavor = true;
        }

        /// <summary>
        /// Event handler for when the Tyrannotea Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectTyrannoteaDrink(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;
            flavor = false;
        }

        /// <summary>
        /// Event handler for when the Jurassic Java Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectJurassicJavaDrink(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Visible;
            flavor = false;
        }

        /// <summary>
        /// Event handler for when the Water Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectWaterDrink(object sender, RoutedEventArgs args)
        {
            SweetDecafFlavorButton.Visibility = Visibility.Hidden;
            AddLemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;
            flavor = false;
        }

        /// <summary>
        /// Event handler for when the Sweet/Decaf/Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSweetDecafFlavor(object sender, RoutedEventArgs args)
        {
            if (flavor)
            {
                NavigationService.Navigate(new FlavorSelection());
            }
            
        }
    }
}
