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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RecherchePage : Page
    {
        private List<Comment> Comments;
        public static string lien="";
        public static string region = "AllTunisia";

        // public  Uri uri = new Uri("ms-appx:///Assets/Manouba.png");
        public RecherchePage()
        {
            this.InitializeComponent();
            Comments = CommentaireManagers.GetComments("62");
           
    }

        private void TunisClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            lien = "ms-appx:///Assets/Tunis.png";
            Map.Source= new BitmapImage(new Uri(lien));
            region = "tunis";

        }

    

        private void ArianaClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            lien = "ms-appx:///Assets/Ariana.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "ariana";
        }

        private void BenArousClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            Map.Source = new BitmapImage(new Uri("ms-appx:///Assets/BenArous.png"));
            region = "benarous";
        }

        private void NabeulClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            Map.Source = new BitmapImage(new Uri("ms-appx:///Assets/Nabeul.png"));
            region = "nabeul";
        }

        private void SousseClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            Map.Source = new BitmapImage(new Uri("ms-appx:///Assets/Sousse.png"));
            region = "sousse";
        }

        private void MestirClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            Map.Source = new BitmapImage(new Uri("ms-appx:///Assets/Mestir.png"));
            region = "mestir";
        }

        private void MahdiaClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            Map.Source = new BitmapImage(new Uri("ms-appx:///Assets/Mahdia.png"));
            region = "mahdia";
        }

        private void KefClick(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Collapsed;
            Map.Source = new BitmapImage(new Uri("ms-appx:///Assets/Kef.png"));
            region = "kef";
        }

      

        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }

        private void UserHeaderImg_Click(object sender, RoutedEventArgs e)
        {
            if (NotifPannel.Visibility == Visibility.Collapsed)
                NotifPannel.Visibility = Visibility.Visible;
            else NotifPannel.Visibility = Visibility.Collapsed;
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

        private void GouvernTapped(object sender, RoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Visible;
        }
       /* public List<Nourriture> getNourritureRecherche()
        {

            return null;
        }*/
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, string> newDictionary = new Dictionary<string, string>();
            newDictionary.Add("region", region);
            newDictionary.Add("priceMin",PrixMin.Text);
            newDictionary.Add("priceMax",PrixMax.Text);
            if (mypivot.SelectedIndex.ToString().Equals("0")) 
            newDictionary.Add("category", "Nourriture");
            if (mypivot.SelectedIndex.ToString().Equals("3"))
                newDictionary.Add("category", "Artisanat");
            if (mypivot.SelectedIndex.ToString().Equals("2"))
                newDictionary.Add("category", "Services");
            if (mypivot.SelectedIndex.ToString().Equals("1")) 
            newDictionary.Add("category", "Multimedia");
            newDictionary.Add("name", RechercheTxt.Text);
            //Debug.WriteLine(category + "   aaaaaa");
            Frame.Navigate(typeof(RechercheResultPage), newDictionary);
            CatPannel.Visibility = Visibility.Visible;
            //Frame.Navigate(typeof(RechercheResultPage), lien);
            Debug.WriteLine(mypivot.SelectedIndex);
            Debug.WriteLine(lien);
           
        }

        private void TunisTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Tunis.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "tunis";
          
        }

        private void ArianaTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Ariana.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "ariana";



        }

        private void ManoubaTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Manouba.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "manouba";
        }

        private void NabeulTapped(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Nabeul.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "nabeul";
        }

        private void SousseTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Sousse.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "sousse";
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Mestir.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "mestir";
        }

        private void MahdiaTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Mahdia.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "mahdia";
        }

        private void SfaxTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Sfax.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "sfax";
        }

        private void MednineTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Mednine.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "mednine";
        }

        private void tatTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Tatawin.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "tatawin";
        }

        private void BejaTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Beja.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "beja";
        }

        private void ZaghwenTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Zaghwen.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "zaghwen";
        }

        private void KebTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Gbeli.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "gbeli";
        }

        private void TozTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Tozeur.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "tozeur";
        }

        private void GabTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Gabes.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "gabes";
        }

        private void GafsaTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Gafsa.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "gafsa";
        }

        private void SidiTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/SidiBouzid.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "sidibouzid";
        }

        private void KarTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Karwen.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "karwen";
        }

        private void SilTapped(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Siliana.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "kef";
        }

        private void KefTapped(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Kef.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "kef";
        }

        private void GasTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Gasserine.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "gasserine";
        }

        private void JendTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Jendouba.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "jendouba";
        }

        private void bizTap(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/Bizerte.png";
            Map.Source = new BitmapImage(new Uri(lien));
            region = "bizerte";
        }

        private void AllTaped(object sender, TappedRoutedEventArgs e)
        {
            lien = "ms-appx:///Assets/AllTunisia.png";
            Map.Source = new BitmapImage(new Uri(lien));
        }

       
        private void MapTap(object sender, TappedRoutedEventArgs e)
        {
            CatPannel.Visibility = Visibility.Visible;
        }

        

        private void RechercheTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            RechercheTxt.Text = "";

        }

        private void PrixMin_GotFocus(object sender, RoutedEventArgs e)
        {
            PrixMin.Text = "";
        }

        private void PrixMax_GotFocus(object sender, RoutedEventArgs e)
        {
            PrixMax.Text = "";
        }
    }
}
