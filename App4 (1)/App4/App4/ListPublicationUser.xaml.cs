using App4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class ListPublicationUser : Page
    {
        public List<Publication> Artisanats = new List<Publication>();

        public ListPublicationUser()
        {
            this.InitializeComponent();
            Artisanats = PublicationManager.getAllProduct(MainPage.userConnected.id + "");
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

      

      

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            Debug.WriteLine("deleted");

            Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/deleteProductByID.php?id=6");
            string data = datatask.Result;
        }
    }
}
