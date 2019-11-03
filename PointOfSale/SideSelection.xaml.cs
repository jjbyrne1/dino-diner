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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        //Backing variable
        private Side side;
        private CretaceousCombo combo;
        private bool isCombo = false;

        /// <summary>
        /// Default Constructor for SideSelection
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for SideSelection for side
        /// </summary>
        /// <param name="side"> the side </param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
            EnableSizeButtons();

            FryceritopsButton.IsEnabled = false;
            MeteorMacAndCheeseButton.IsEnabled = false;
            MezzorellaSticksButton.IsEnabled = false;
            TriceritotsButton.IsEnabled = false;
        }

        /// <summary>
        /// Constructor for SideSelection for combo
        /// </summary>
        /// <param name="combo"> the combo </param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Enables all the size buttons
        /// </summary>
        private void EnableSizeButtons()
        {
            SmallButton.IsEnabled = true;
            MediumButton.IsEnabled = true;
            LargeButton.IsEnabled = true;
        }

        /// <summary>
        /// Event handler for when the Fryceritops Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectFryceritopsSide(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.GoBack();
                }
                else
                {
                    order.Add(side);
                    EnableSizeButtons();
                }
            }
            
        }

        /// <summary>
        /// Event handler for when the Meteor Mac and Cheese Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMeteorMacAndCheeseSide(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    order.Add(side);
                    EnableSizeButtons();
                }
            }
        }

        /// <summary>
        /// Event handler for when the Mezzorella Sticks Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMezzorellaSticksSide(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    order.Add(side);
                    EnableSizeButtons();
                }
            }
        }

        /// <summary>
        /// Event handler for when the Triceritots Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectTriceritotsSide(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if (isCombo)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    order.Add(side);
                    EnableSizeButtons();
                }
            }
        }

        /// <summary>
        /// Event handler for when Small Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSmall(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Event handler for when the Medium Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMedium(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        /// <summary>
        /// Event handler for when the Large size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectLarge(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
