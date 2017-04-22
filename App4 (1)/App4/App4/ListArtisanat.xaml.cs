using App4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public sealed partial class ListArtisanat : Page
    {

        public List<Artisanat> Artisanats = new List<Artisanat>();
        public List<Artisanat> Tappisseries;
        public List<Artisanat> Poteries;
        public List<Artisanat> Broderies;
        public List<Artisanat> Peintures;
        public static Artisanat SelectedArtisanat;

        public ListArtisanat()
        {
            this.InitializeComponent();
            Artisanats = ArtisanatMangaer.GetArtisanat();
            Poteries = ArtisanatMangaer.GetPoterie();
            Broderies = ArtisanatMangaer.GetBroderie();
            Peintures = ArtisanatMangaer.GetPeinture();
            Tappisseries = ArtisanatMangaer.GetTappisserie();


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            Debug.WriteLine(parameter);
            if (parameter.Equals("Artisanat"))
            {
                TappisserieList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Visible;
                BroderieList.Visibility = Visibility.Collapsed;
                PoterieList.Visibility = Visibility.Collapsed;
            }
           
           else if (parameter.Equals("Tappisserie"))
            {
                TappisserieList.Visibility = Visibility.Visible;
                Alllist2.Visibility = Visibility.Collapsed;
                BroderieList.Visibility = Visibility.Collapsed;
                PoterieList.Visibility = Visibility.Collapsed;
            }
            else if(parameter.Equals("Broderie"))
            {
                TappisserieList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                BroderieList.Visibility = Visibility.Visible;
                PoterieList.Visibility = Visibility.Collapsed;
            }
            else if(parameter.Equals("Poterie"))
            {
                TappisserieList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                BroderieList.Visibility = Visibility.Collapsed;
                PoterieList.Visibility = Visibility.Visible;
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;


        }
        private void UserHeaderImg_Click(object sender, RoutedEventArgs e)
        {
            if (NotifPannel.Visibility == Visibility.Collapsed)
                NotifPannel.Visibility = Visibility.Visible;
            else NotifPannel.Visibility = Visibility.Collapsed;
        }
        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }
        private void Alllist_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedArtisanat = (Artisanat)e.ClickedItem;
            Debug.WriteLine(SelectedArtisanat.Name);

            Frame.Navigate(typeof(App4.SignleProduct),"Artisanat");
        }
    }
}
