using App4.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListImmobilier : Page
    {
        public List<Immobilier> Immobiliers = new List<Immobilier>();
        public List<Immobilier> Maisons;
        public List<Immobilier> Entrepots;
        public List<Immobilier> Terrains;
        public ListImmobilier()
        {
            this.InitializeComponent();
            Immobiliers = ImmobilierManager.GetImmobilier();
            Maisons = ImmobilierManager.GetMaison();
            Entrepots = ImmobilierManager.GetEntrepot();
            Terrains = ImmobilierManager.GetTerrain();
        }
        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;


        }
    }
}
