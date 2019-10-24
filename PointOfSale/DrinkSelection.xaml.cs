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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        private Size size;
        private Drink drink;
        public bool flavor = false;
        private bool lemon = false;
        private bool ice = true;

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

            SodasaurusButton.IsEnabled = false;
            TyrannoteaButton.IsEnabled = true;
            JurassicJavaButton.IsEnabled = true;
            WaterButton.IsEnabled = true;

            //Resets Size Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;
            ice = true;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;
            lemon = false;
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

            SodasaurusButton.IsEnabled = true;
            TyrannoteaButton.IsEnabled = false;
            JurassicJavaButton.IsEnabled = true;
            WaterButton.IsEnabled = true;

            //Resets Size Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;
            ice = true;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;
            lemon = false;
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

            SodasaurusButton.IsEnabled = true;
            TyrannoteaButton.IsEnabled = true;
            JurassicJavaButton.IsEnabled = false;
            WaterButton.IsEnabled = true;

            //Resets Size Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;
            ice = true;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;
            lemon = false;
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

            SodasaurusButton.IsEnabled = true;
            TyrannoteaButton.IsEnabled = true;
            JurassicJavaButton.IsEnabled = true;
            WaterButton.IsEnabled = false;

            //Resets Size Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;
            ice = true;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;
            lemon = false;
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

        /// <summary>
        /// Event handler for when the Lemon button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void AddLemon(object sender, RoutedEventArgs args)
        {
            if (LemonText.Text.CompareTo("Add Lemon") == 0)
            {
                LemonText.Text = "Hold Lemon";
                AddLemonButton.Background = Brushes.White;
                lemon = true;
            }
            else
            {
                LemonText.Text = "Add Lemon";
                AddLemonButton.Background = Brushes.Yellow;
                lemon = false;
            }
        }

        /// <summary>
        /// Event handler for when the Sweet/Decaf/Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void HoldIce(object sender, RoutedEventArgs args)
        {
            
            if (IceText.Text.CompareTo("Hold Ice") == 0)
            {
                IceText.Text = "Add Ice";
                HoldIceButton.Background = Brushes.SkyBlue;
                ice = false;
            }
            else
            {
                IceText.Text = "Hold Ice";
                HoldIceButton.Background = Brushes.LightBlue;
                ice = true;
            }
        }

        /// <summary>
        /// Event handler for when Small Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSmall(object sender, RoutedEventArgs args)
        {
            size = Size.Small;
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// Event handler for when the Medium Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMedium(object sender, RoutedEventArgs args)
        {
            size = Size.Medium;
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// Event handler for when the Large size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectLarge(object sender, RoutedEventArgs args)
        {
            size = Size.Large;
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}
