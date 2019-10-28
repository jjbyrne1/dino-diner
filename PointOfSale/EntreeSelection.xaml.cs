﻿using System;
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        //Backing Variable
        private Entree entree;

        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the Brontowurst Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectBrontowurstEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
                if (entree is Brontowurst bw)
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizeBrontowurst(bw));
                }
            }
        }

        /// <summary>
        /// Event handler for when the Dino-Nuggets Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectDinoNuggetsEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                if (entree is DinoNuggets dn)
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizeDinoNuggets(dn));
                }
            }
        }

        /// <summary>
        /// Event handler for when the Steakosaurus Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectSteakosaurusEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                if (entree is SteakosaurusBurger sb)
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizeSteakosaurusBurger(sb));
                }
            }
        }

        /// <summary>
        /// Event handler for when the T-Rex King Burger Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectTRexKingBurgerEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                if (entree is TRexKingBurger trex) 
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizeTRexKingBurger(trex));
                }
            }
        }

        /// <summary>
        /// Event handler for when the Prehistoric PB&J Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectPrehistoricPBJEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                if (entree is PrehistoricPBJ pbj)
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizePrehistoricPBJ(pbj));
                }
            }
        }

        /// <summary>
        /// Event handler for when the Pterodactyl Wings Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectPterodactylWingsEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                if (entree is PterodactylWings pw)
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizePterodactylWings(pw));
                }
            }
            
        }

        /// <summary>
        /// Event handler for when the Velici-Wrap Entree button is clicked
        /// </summary>
        /// <param name="sender"> the object clicked on </param>
        /// <param name="args"> event arguements </param>
        void SelectVeliciWrapEntree(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                if (entree is VelociWrap vw)
                {
                    NavigationService.Navigate(new Entree_Customization_Pages.CustomizeVelociWrap(vw));
                }
            }
        }
    }
}
