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

namespace PointOfSale
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        //Backing Variable
        private CretaceousCombo combo;
        private DinoDiner.Menu.Size comboSize = DinoDiner.Menu.Size.Small;

        /// <summary>
        /// Constructor for the CustomizeCombo
        /// </summary>
        /// <param name="combo"> the updated combo </param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            EnableSizeButtons();
            ChangeSideText();
        }

        /// <summary>
        /// Constructor for the CustomizeCombo
        /// </summary>
        /// <param name="combo"> the updated combo </param>
        public CustomizeCombo(CretaceousCombo combo, DinoDiner.Menu.Size size)
        {
            InitializeComponent();
            this.combo = combo;
            comboSize = size;
            EnableSizeButtons();
            ChangeSideText();
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
        /// Event handler for when the Side button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection(combo, comboSize));
        }

        /// <summary>
        /// Event handler for when the Drink button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectDrink(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new DrinkSelection(combo, comboSize));
        }

        /// <summary>
        /// Event handler for when Small Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSmall(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Small;
            comboSize = combo.Size;
        }

        /// <summary>
        /// Event handler for when the Medium Size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectMedium(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Medium;
            comboSize = combo.Size;
        }

        /// <summary>
        /// Event handler for when the Large size button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectLarge(object sender, RoutedEventArgs args)
        {
            combo.Size = DinoDiner.Menu.Size.Large;
            comboSize = combo.Size;
        }

        /// <summary>
        /// Helper function for changeing the side buttons text
        /// </summary>
        private void ChangeSideText()
        {
            if(combo.Side is Fryceritops) 
            {
                SideName.Text = "Fryceritops";
                
            }
            else if (combo.Side is Triceritots)
            {
                SideName.Text = "Triceritots";
                
            }
            else if (combo.Side is MeteorMacAndCheese)
            {
                SideName.Text = "Meteor Mac And Cheese";
                
            }
            else if (combo.Side is MezzorellaSticks)
            {
                SideName.Text = "Mezzorella Sticks";
                
            }
        }
    }
}
