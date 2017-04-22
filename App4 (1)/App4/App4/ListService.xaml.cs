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
    public sealed partial class ListService : Page
    {


        public List<Service> Services = new List<Service>();
        public List<Service> Menages;
        public List<Service> Reparations;
        public List<Service> BabySittings;
        public List<Service> Educations;
        public static Service SelectedService;


        public ListService()
        {
            this.InitializeComponent();
            Services = ServiceManager.GetArtisanat();
            Menages = ServiceManager.GetMenage();
            Reparations = ServiceManager.GetReparation();
            BabySittings = ServiceManager.GetBabySitting();
            Educations = ServiceManager.GetEducation();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            Debug.WriteLine(parameter);
            if (parameter.Equals("Service"))
            {
                ReparationList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Visible;
                BabySittingList.Visibility = Visibility.Collapsed;
                EducationList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("Reparation"))
            {
                ReparationList.Visibility = Visibility.Visible;
                Alllist2.Visibility = Visibility.Collapsed;
                BabySittingList.Visibility = Visibility.Collapsed;
                EducationList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("BabySitting"))
            {
                ReparationList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                BabySittingList.Visibility = Visibility.Visible;
                EducationList.Visibility = Visibility.Collapsed;

            }
            if (parameter.Equals("Education"))
            {
                ReparationList.Visibility = Visibility.Collapsed;
                Alllist2.Visibility = Visibility.Collapsed;
                BabySittingList.Visibility = Visibility.Collapsed;
                EducationList.Visibility = Visibility.Visible;

            }
        }

        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;


        }
        private void Alllist_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedService = (Service)e.ClickedItem;
            Debug.WriteLine(SelectedService.Name);

            Frame.Navigate(typeof(App4.SignleProduct), "Service");
        }
    }
}
