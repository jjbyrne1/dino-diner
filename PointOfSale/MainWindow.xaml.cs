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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            OrderInterface.NavigationService = OrderUI.NavigationService;
        }

        /// <summary>
        /// Passes data content to page
        /// </summary>
        private void PassDataContentToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// Event handler for OnLoadCompleted
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> teh event args </param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// Event handler for OnDataContextChanged
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> teh event args </param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// Event handler for SelectReturnToCategorySelection
        /// </summary>
        /// <param name="sender"> the object </param>
        /// <param name="args"> teh event args </param>
        public void SelectReturnToCategorySelection(object sender, RoutedEventArgs args)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
