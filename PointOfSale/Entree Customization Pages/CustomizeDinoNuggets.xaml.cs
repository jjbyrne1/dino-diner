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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        //Backing Variable
        private CretaceousCombo combo;
        private DinoNuggets dn;
        private bool isCombo;

        /// <summary>
        /// Custructor for Customize DinoNuggets for combo
        /// </summary>
        /// <param name="combo"> the combo </param>
        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            isCombo = true;
        }

        /// <summary>
        /// Custructor for Customize DinoNuggets for entree
        /// </summary>
        /// <param name="dn"> the dinonuggets entree </param>
        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
            isCombo = false;
        }

        /// <summary>
        /// Event handler for Add Nugget
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args">  event arguemnts </param>
        private void SelectAddNugget(object sender, RoutedEventArgs args)
        {
            if (isCombo)
            {
                if (combo.Entree is DinoNuggets dn) dn.AddNugget();
            }
            else this.dn.AddNugget();
        }

        /// <summary>
        /// Event handler for SelectDone
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> event arguments </param>
        private void SelectDone(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
