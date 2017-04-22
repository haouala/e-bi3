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
using PivotCS;
using App4.Models;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public  sealed partial class MainPage : Page
    {
        public List<User> Users;
        public User user = new User();
        public static User userConnected;

        public MainPage()
        {
            
            this.InitializeComponent();
        }

    private void button_Click(object sender, RoutedEventArgs e)
        {


            userConnected = UserManagers.GetUserBy(textBox.Text);



            if (userConnected.username.Equals(textBox.Text) & userConnected.password.Equals(textBox_Copy.Password))
            {
                Frame.Navigate(typeof(Panorama));
               // userConnected = user;
            }
            else
            {
                Debug.WriteLine("nulll user");
            }

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            
            Frame.Navigate(typeof(App4.Panorama));
        }

        private void textBlockSignIn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.InscriptionPage));
        }
    }
}
