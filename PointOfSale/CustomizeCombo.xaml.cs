using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

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
            ChangeEntreeText();
            ChangeSideText();
            ChangeDrinkText();
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
            ChangeDrinkText();
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
        /// Event handler for when the Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectEntreeCustomization(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeBrontowurst(combo));
            else if (combo.Entree is DinoNuggets) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeDinoNuggets(combo));
            else if (combo.Entree is PrehistoricPBJ) NavigationService.Navigate(new Entree_Customization_Pages.CustomizePrehistoricPBJ(combo));
            else if (combo.Entree is PterodactylWings) NavigationService.Navigate(new Entree_Customization_Pages.CustomizePterodactylWings(combo));
            else if (combo.Entree is SteakosaurusBurger) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeSteakosaurusBurger(combo));
            else if (combo.Entree is TRexKingBurger) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeTRexKingBurger(combo));
            else if (combo.Entree is VelociWrap) NavigationService.Navigate(new Entree_Customization_Pages.CustomizeVelociWrap(combo));
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
        /// Helper function for changing the side buttons text and image
        /// </summary>
        private void ChangeSideText()
        {
            if (combo.Side is Fryceritops) 
            {
                SideText.Text = "Fryceritops";
                SideButton.FontSize = 25;
            }
            else if (combo.Side is Triceritots)
            {
                SideText.Text = "Triceritots";
                SideButton.FontSize = 25;
            }
            else if (combo.Side is MeteorMacAndCheese)
            {
                SideText.Text = "Meteor Mac And Cheese";
                SideButton.FontSize = 15;
                
            }
            else if (combo.Side is MezzorellaSticks)
            {
                SideText.Text = "Mezzorella Sticks";
                SideButton.FontSize = 25;

            }
        }

        /// <summary>
        /// Helper function for changing the drink buttons text
        /// </summary>
        private void ChangeDrinkText()
        {
            if (combo.Drink is Sodasaurus)
            {
                DrinkText.Text = "Sodasaurus";
            }
            else if (combo.Drink is Tyrannotea)
            {
                DrinkText.Text = "Tyrannotea";

            }
            else if (combo.Drink is JurassicJava)
            {
                DrinkText.Text = "Jurassic Java";

            }
            else if (combo.Drink is Water)
            {
                DrinkText.Text = "Water";
            }
        }

        /// <summary>
        /// Helper function for changing the drink buttons text
        /// </summary>
        private void ChangeEntreeText()
        {
            if (combo.Entree is Brontowurst bw)
            {
                EntreeText.Text = bw.Description;
                EntreeText.FontSize = 25;
            }
            else if (combo.Entree is DinoNuggets dn)
            {
                EntreeText.Text = dn.Description;
                EntreeText.FontSize = 25;
            }
            else if (combo.Entree is PrehistoricPBJ pbj)
            {
                EntreeText.Text = pbj.Description;
                EntreeText.FontSize = 25;
            }
            else if (combo.Entree is PterodactylWings pw)
            {
                EntreeText.Text = pw.Description;
                EntreeText.FontSize = 20;
            }
            else if (combo.Entree is SteakosaurusBurger sb)
            {
                EntreeText.Text = sb.Description;
                EntreeText.FontSize = 20;
            }
            else if (combo.Entree is TRexKingBurger trex)
            {
                EntreeText.Text = trex.Description;
                EntreeText.FontSize = 20;
            }
            else if (combo.Entree is VelociWrap vw)
            {
                EntreeText.Text = vw.Description;
                EntreeText.FontSize = 25;
            }
        }
    }
}
