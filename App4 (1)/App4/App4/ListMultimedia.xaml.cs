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
    public sealed partial class ListMultimedia : Page
    {
        public List<Multimedia> Multimedias = new List<Multimedia>();
        public List<Multimedia> Informatiques;
        public List<Multimedia> Telephones;
        public List<Multimedia> TVs;
        public List<Multimedia> Sons;
        public static Multimedia SelectedMultimedia;
        public ListMultimedia()
        {
            this.InitializeComponent();
            Multimedias = MultimediaManager.GetMultimedia();
            Informatiques = MultimediaManager.GetInformatique();
            Telephones = MultimediaManager.GetTelephone();
            TVs = MultimediaManager.GetTV();
            Sons = MultimediaManager.GetSon();
        }

        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;


        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            Debug.WriteLine(parameter);
            if (parameter.Equals("Multimedia"))
            {
                InformatiqueList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Visible;
                TelephoneList.Visibility = Visibility.Collapsed;
                TVList.Visibility = Visibility.Collapsed;
                SonList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("Informatique"))
            {
                InformatiqueList.Visibility = Visibility.Visible;
                Alllist2.Visibility = Visibility.Collapsed;
                TelephoneList.Visibility = Visibility.Collapsed;
                TVList.Visibility = Visibility.Collapsed;
                SonList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("Telephone"))
            {
                InformatiqueList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                TelephoneList.Visibility = Visibility.Visible;
                TVList.Visibility = Visibility.Collapsed;
                SonList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("TV"))
            {
                InformatiqueList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                TelephoneList.Visibility = Visibility.Collapsed;
                TVList.Visibility = Visibility.Visible;
                SonList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("Son"))
            {
                InformatiqueList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                TelephoneList.Visibility = Visibility.Collapsed;
                TVList.Visibility = Visibility.Collapsed;
                SonList.Visibility = Visibility.Visible;

            }
        }
        private void Alllist_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedMultimedia = (Multimedia)e.ClickedItem;
            Debug.WriteLine(SelectedMultimedia.Name);

            Frame.Navigate(typeof(App4.SignleProduct), "Multimedia");
        }
    }
}
