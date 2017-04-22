using App4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Web;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class MapPage : Page
    {
        private List<Comment> Comments;
        public MapPage()
        {
            Comments = CommentaireManagers.GetComments("62");
            this.InitializeComponent();
            // Map.ZoomLevel = 14;
            var callbackUri = WebAuthenticationBroker.GetCurrentApplicationCallbackUri();
            Debug.WriteLine(callbackUri);

            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = 47.620, Longitude = -122.349 };
            Geopoint snPoint = new Geopoint(snPosition);
            MapIcon mapIcon1 = new MapIcon();
            mapIcon1.Location = snPoint;
            mapIcon1.NormalizedAnchorPoint = new Point(3.0, 3.0);
            mapIcon1.Title = "Space Needle";
            mapIcon1.ZIndex = 0;

            // Add the MapIcon to the map.
            Map.MapElements.Add(mapIcon1);

            // Center the map over the POI.
            Map.Center = snPoint;
            Map.ZoomLevel = 14;
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
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ShareListBoxItem.IsSelected) { ResultTextBlock.Text = "Share"; }
            else if (FavoritesListBoxItem.IsSelected) { ResultTextBlock.Text = "Favorites"; }
        }
    }
}
