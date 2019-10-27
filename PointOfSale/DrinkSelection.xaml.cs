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
        //BAcking Variables
        private Drink drink;
        private bool flavor = false;

        /// <summary>
        /// Constructor for default drinkselection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for drinkselection when a drink has been reselected
        /// </summary>
        /// <param name="drink"> selected drink </param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            if (drink is Drink d)
            {
                if (d is Sodasaurus s)
                {
                    //Enables Buttons
                    SmallButton.IsEnabled = true;
                    MediumButton.IsEnabled = true;
                    LargeButton.IsEnabled = true;

                    //Displays appropriate special buttons
                    SweetDecafFlavorButton.Visibility = Visibility.Visible;
                    AddLemonButton.Visibility = Visibility.Hidden;
                    HoldIceButton.Visibility = Visibility.Visible;

                    //Sets Flavor/Decaf/Sweet Button's Text
                    SweetDecafFlavorText.Text = "Select Flavor";
                    SweetDecafFlavorButton.Foreground = Brushes.Black;
                    this.flavor = true;
                }
                else if (d is Tyrannotea t)
                {
                    //Enables Buttons
                    SmallButton.IsEnabled = true;
                    MediumButton.IsEnabled = true;
                    LargeButton.IsEnabled = true;

                    //Displays appropriate special buttons
                    SweetDecafFlavorButton.Visibility = Visibility.Visible;
                    AddLemonButton.Visibility = Visibility.Visible;
                    HoldIceButton.Visibility = Visibility.Visible;

                    //Updates sweet
                    if (t.Sweet == true)
                    {
                        SweetDecafFlavorText.Text = "Hold Sweet";
                        SweetDecafFlavorButton.Background = Brushes.Tan;
                    }
                    else
                    {
                        SweetDecafFlavorText.Text = "Add Sweet";
                        SweetDecafFlavorButton.Background = Brushes.White;
                    }

                    //Updates lemon
                    if (t.Lemon == true)
                    {
                        LemonText.Text = "Hold Lemon";
                        AddLemonButton.Background = Brushes.White;
                    }
                    else
                    {
                        LemonText.Text = "Add Lemon";
                        AddLemonButton.Background = Brushes.Yellow;
                    }
                }
                else if (d is JurassicJava jj)
                {
                    //Enables Buttons
                    SmallButton.IsEnabled = true;
                    MediumButton.IsEnabled = true;
                    LargeButton.IsEnabled = true;

                    //Displays appropriate special buttons
                    SweetDecafFlavorButton.Visibility = Visibility.Visible;
                    AddLemonButton.Visibility = Visibility.Hidden;
                    HoldIceButton.Visibility = Visibility.Visible;

                    //Updates decaf
                    if (jj.Decaf == true)
                    {
                        SweetDecafFlavorText.Text = "Hold Decaf";
                        SweetDecafFlavorButton.Background = Brushes.Brown;
                        SweetDecafFlavorButton.Foreground = Brushes.White;
                    }
                    else
                    {
                        SweetDecafFlavorText.Text = "Add Decaf";
                        SweetDecafFlavorButton.Background = Brushes.White;
                        SweetDecafFlavorButton.Foreground = Brushes.Black;

                    }
                }
                else if (d is Water w)
                {
                    //Enables Buttons
                    SmallButton.IsEnabled = true;
                    MediumButton.IsEnabled = true;
                    LargeButton.IsEnabled = true;

                    //Displays appropriate special buttons
                    SweetDecafFlavorButton.Visibility = Visibility.Hidden;
                    AddLemonButton.Visibility = Visibility.Visible;
                    HoldIceButton.Visibility = Visibility.Visible;

                    //Updates lemon
                    if (w.Lemon == true)
                    {
                        LemonText.Text = "Hold Lemon";
                        AddLemonButton.Background = Brushes.White;
                    }
                    else
                    {
                        LemonText.Text = "Add Lemon";
                        AddLemonButton.Background = Brushes.Yellow;
                    }
                }
                //Updates ice
                if (d.Ice == false)
                {
                    IceText.Text = "Add Ice";
                    HoldIceButton.Background = Brushes.White;
                }
                else
                {
                    IceText.Text = "Hold Ice";
                    HoldIceButton.Background = Brushes.LightBlue;
                }
            }
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        private void SelectDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Event handler for when the Sodasurus Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        private void SelectSodasurusDrink(object sender, RoutedEventArgs args)
        {
            flavor = true;

            //Enables Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Displays appropriate special buttons
            SweetDecafFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Visible;

            //Sets Flavor/Decaf/Sweet Button's Text
            SweetDecafFlavorText.Text = "Select Flavor";

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;

            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                order.Add(drink);
            }
        }

        /// <summary>
        /// Event handler for when the Tyrannotea Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        private void SelectTyrannoteaDrink(object sender, RoutedEventArgs args)
        {
            flavor = false;

            //Enables Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Displays appropriate special buttons
            SweetDecafFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;

            //Sets Flavor/Decaf/Sweet Button's Text
            SweetDecafFlavorText.Text = "Add Sweet";
            SweetDecafFlavorButton.Background = Brushes.White;

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;

            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                order.Add(drink);
            }
        }

        /// <summary>
        /// Event handler for when the Jurassic Java Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        private void SelectJurassicJavaDrink(object sender, RoutedEventArgs args)
        {
            flavor = false;

            //Enables Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Displays appropriate special buttons
            SweetDecafFlavorButton.Visibility = Visibility.Visible;
            AddLemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Visible;

            //Sets Flavor/Decaf/Sweet Button's Text
            SweetDecafFlavorText.Text = "Add Decaf";
            SweetDecafFlavorButton.Background = Brushes.White;

            //Resets Ice Button
            IceText.Text = "Add Ice";
            HoldIceButton.Background = Brushes.White;

            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                order.Add(drink);
            }
        }

        /// <summary>
        /// Event handler for when the Water Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        public void SelectWaterDrink(object sender, RoutedEventArgs args)
        {
            flavor = false;

            //Enables Buttons
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;

            //Displays appropriate special buttons
            SweetDecafFlavorButton.Visibility = Visibility.Hidden;
            AddLemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;

            //Resets Ice Button
            IceText.Text = "Hold Ice";
            HoldIceButton.Background = Brushes.LightBlue;

            //Resets Lemon Button
            LemonText.Text = "Add Lemon";
            AddLemonButton.Background = Brushes.Yellow;

            if (DataContext is Order order)
            {
                drink = new Water();
                order.Add(drink);
            }
        }

        /// <summary>
        /// Event handler for when the Sweet/Decaf/Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        public void SelectSweetDecafFlavor(object sender, RoutedEventArgs args)
        {
            if (flavor)
            {
                NavigationService.Navigate(new FlavorSelection());
            }
            else if (drink is Tyrannotea t)
            {
                if (SweetDecafFlavorText.Text == "Add Sweet")
                {
                    SweetDecafFlavorText.Text = "Hold Sweet";
                    t.AddSweet();
                    SweetDecafFlavorButton.Background = Brushes.Tan;
                }
                else
                {
                    SweetDecafFlavorText.Text = "Add Sweet";
                    t.RemoveSweet();
                    SweetDecafFlavorButton.Background = Brushes.White;
                }
            }
            else if (drink is JurassicJava jj)
            {
                if (SweetDecafFlavorText.Text == "Add Decaf")
                {
                    SweetDecafFlavorText.Text = "Hold Decaf";
                    jj.Decaf = true;
                    SweetDecafFlavorButton.Background = Brushes.Brown;
                    SweetDecafFlavorButton.Foreground = Brushes.White;
                }
                else
                {
                    SweetDecafFlavorText.Text = "Add Decaf";
                    jj.Decaf = false;
                    SweetDecafFlavorButton.Background = Brushes.White;
                    SweetDecafFlavorButton.Foreground = Brushes.Black;
                }
            }
        }

        /// <summary>
        /// Event handler for when the Lemon button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        public void AddLemon(object sender, RoutedEventArgs args)
        {
            if (LemonText.Text.CompareTo("Add Lemon") == 0)
            {
                LemonText.Text = "Hold Lemon";
                AddLemonButton.Background = Brushes.White;
                //lemon = true;
                if (drink is Tyrannotea t) t.AddLemon();
                else if (drink is Water w) w.AddLemon();
            }
            else
            {
                LemonText.Text = "Add Lemon";
                AddLemonButton.Background = Brushes.Yellow;
                //lemon = false;
                if (drink is Tyrannotea t) t.Lemon = false;
                else if (drink is Water w) w.Lemon = false;
            }
        }

        /// <summary>
        /// Event handler for when the Sweet/Decaf/Flavor button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        public void HoldIce(object sender, RoutedEventArgs args)
        {
            
            if (IceText.Text.CompareTo("Hold Ice") == 0)
            {
                IceText.Text = "Add Ice";
                HoldIceButton.Background = Brushes.White;
                //ice = false;
                if (drink is Drink d) d.HoldIce();
            }
            else
            {
                IceText.Text = "Hold Ice";
                HoldIceButton.Background = Brushes.LightBlue;
                //ice = true;
                if (drink is Drink d) d.AddIce();
            }
        }

        /// <summary>
        /// Event handler for when Small Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        public void SelectSmall(object sender, RoutedEventArgs args)
        {
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
        public void SelectMedium(object sender, RoutedEventArgs args)
        {
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
        public void SelectLarge(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}
