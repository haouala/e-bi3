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
using App4.Models;
using Windows.UI.Xaml.Media.Imaging;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListNourriture : Page
    {
        private List<Comment> Comments;
        public List<Nourriture> Nourritures=new List<Nourriture>();
        private List<Nourriture> Legumes;
        private List<Nourriture> Fruits;
        private List<Nourriture> Epices;
        public static Nourriture SelectedNourriture;



        public   ListNourriture()
        {
           
            this.InitializeComponent();

            Nourritures = NourritureManagers.GetNourriture();
            Legumes = NourritureManagers.GetLegumes();
            Fruits = NourritureManagers.GetFruit();
            Epices = NourritureManagers.GetEpice();
            Comments = CommentaireManagers.GetComments("62");

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

        private void UserHeaderImg_Click(object sender, RoutedEventArgs e)
        {
            if (NotifPannel.Visibility == Visibility.Collapsed)
                NotifPannel.Visibility = Visibility.Visible;
            else NotifPannel.Visibility = Visibility.Collapsed;
        }

       protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            if (parameter.Equals("Nourriture"))
            {
                LegumeList.Visibility = Visibility.Collapsed;
                Alllist.Visibility = Visibility.Visible;
                FruitList.Visibility = Visibility.Collapsed;
                EpiceList.Visibility = Visibility.Collapsed;
            }
            if (parameter.Equals("Legume"))
            {
                Debug.WriteLine(parameter+"//////*********");
                LegumeList.Visibility = Visibility.Visible;
                Alllist.Visibility = Visibility.Collapsed;
                FruitList.Visibility = Visibility.Collapsed;
                EpiceList.Visibility = Visibility.Collapsed;
            }
            if (parameter.Equals("Fruit"))
            {
                LegumeList.Visibility = Visibility.Collapsed;
                Alllist.Visibility = Visibility.Collapsed;
                FruitList.Visibility = Visibility.Visible;
                EpiceList.Visibility = Visibility.Collapsed;
            }
            if (parameter.Equals("Epice"))
            {
                LegumeList.Visibility = Visibility.Collapsed;
                Alllist.Visibility = Visibility.Collapsed;
                FruitList.Visibility = Visibility.Collapsed;
                EpiceList.Visibility = Visibility.Visible;
            }
        }



        private void FruitBtn_Click_1(object sender, RoutedEventArgs e)
        {
            var brushFruitCouleur = new ImageBrush();
            brushFruitCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruitCouleur.png"));
            FruitBtn.Background = brushFruitCouleur;

            var brushFishBlanc = new ImageBrush();
            brushFishBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Fish.png"));
            FishBtn.Background = brushFishBlanc;

            var brushVegetBlanc = new ImageBrush();
            brushVegetBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Veget.png"));
            VegetBtn.Background = brushVegetBlanc;

            var brushEpiceBlanc = new ImageBrush();
            brushEpiceBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Epice.png"));
            EpiceBtn.Background = brushEpiceBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushHoneyBlanc = new ImageBrush();
            brushHoneyBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Honey.png"));
            HoneyBtn.Background = brushHoneyBlanc;

            var brushEggBlanc = new ImageBrush();
            brushEggBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Eggs.png"));
            EggBtn.Background = brushEggBlanc;

            var brushPainsBlanc = new ImageBrush();
            brushPainsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Pain.png"));
            MangerBtn.Background = brushPainsBlanc;

            pivot1Titel.Text = "Fruits";
            InfoPanel.Visibility = Visibility.Visible;

            LegumeList.Visibility = Visibility.Collapsed;
            Alllist.Visibility = Visibility.Collapsed;
            FruitList.Visibility = Visibility.Visible;
            EpiceList.Visibility = Visibility.Collapsed;
        }

        private void FermerBtn_Click(object sender, RoutedEventArgs e)
        {
            InfoPanel.Visibility = Visibility.Collapsed;
        }

        public void VegetClick(object sender, RoutedEventArgs e)
        {
            var brushLegumeCouleur = new ImageBrush();
            brushLegumeCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/VegetCouleur.png"));
            VegetBtn.Background = brushLegumeCouleur;


            var brushFishBlanc = new ImageBrush();
            brushFishBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Fish.png"));
            FishBtn.Background = brushFishBlanc;

            var brushFruitBlanc = new ImageBrush();
            brushFruitBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruit.png"));
            FruitBtn.Background = brushFruitBlanc;

            var brushEpiceBlanc = new ImageBrush();
            brushEpiceBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Epice.png"));
            EpiceBtn.Background = brushEpiceBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushHoneyBlanc = new ImageBrush();
            brushHoneyBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Honey.png"));
            HoneyBtn.Background = brushHoneyBlanc;

            var brushEggBlanc = new ImageBrush();
            brushEggBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Eggs.png"));
            EggBtn.Background = brushEggBlanc;

            var brushPainsBlanc = new ImageBrush();
            brushPainsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Pain.png"));
            MangerBtn.Background = brushPainsBlanc;

            InfoPanel.Visibility = Visibility.Visible;
            pivot1Titel.Text = "Légumes";
         LegumeList.Visibility = Visibility.Visible;
            Alllist.Visibility = Visibility.Collapsed;
            FruitList.Visibility = Visibility.Collapsed;
            EpiceList.Visibility = Visibility.Collapsed;
        }
      

        private void EpiceCLick(object sender, RoutedEventArgs e)
        {
            var brushEpiceCouleur = new ImageBrush();
            brushEpiceCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/EpiceCouleur.png"));
            EpiceBtn.Background = brushEpiceCouleur;

            var brushFishBlanc = new ImageBrush();
            brushFishBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Fish.png"));
            FishBtn.Background = brushFishBlanc;

            var brushFruitBlanc = new ImageBrush();
            brushFruitBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruit.png"));
            FruitBtn.Background = brushFruitBlanc;

            var brushLegumeBlanc = new ImageBrush();
            brushLegumeBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Veget.png"));
            VegetBtn.Background = brushLegumeBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushHoneyBlanc = new ImageBrush();
            brushHoneyBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Honey.png"));
            HoneyBtn.Background = brushHoneyBlanc;

            var brushEggBlanc = new ImageBrush();
            brushEggBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Eggs.png"));
            EggBtn.Background = brushEggBlanc;

            var brushPainsBlanc = new ImageBrush();
            brushPainsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Pain.png"));
            MangerBtn.Background = brushPainsBlanc;

            pivot2Titel.Text = "Epices" ;
            InfoPanel.Visibility = Visibility.Visible;

            LegumeList.Visibility = Visibility.Collapsed;
            Alllist.Visibility = Visibility.Collapsed;
            FruitList.Visibility = Visibility.Collapsed;
            EpiceList.Visibility = Visibility.Visible;
        }

        private void HoneyClick(object sender, RoutedEventArgs e)
        {
            var brushHoneyCouleur = new ImageBrush();
            brushHoneyCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HoneyCouleur.png"));
            HoneyBtn.Background = brushHoneyCouleur;

            var brushFishBlanc = new ImageBrush();
            brushFishBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Fish.png"));
            FishBtn.Background = brushFishBlanc;

            var brushFruitBlanc = new ImageBrush();
            brushFruitBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruit.png"));
            FruitBtn.Background = brushFruitBlanc;

            var brushLegumeBlanc = new ImageBrush();
            brushLegumeBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Veget.png"));
            VegetBtn.Background = brushLegumeBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushEpiceBlanc = new ImageBrush();
            brushEpiceBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Epice.png"));
            EpiceBtn.Background = brushEpiceBlanc;

            var brushEggBlanc = new ImageBrush();
            brushEggBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Eggs.png"));
            EggBtn.Background = brushEggBlanc;

            var brushPainsBlanc = new ImageBrush();
            brushPainsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Pain.png"));
            MangerBtn.Background = brushPainsBlanc;

            pivot3Titel.Text = "Miel";
            InfoPanel.Visibility = Visibility.Visible;
        }

        private void EggClick(object sender, RoutedEventArgs e)
        {
            var brushEggsCouleur = new ImageBrush();
            brushEggsCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/EggsCouleur.png"));
            EggBtn.Background = brushEggsCouleur;

            var brushFishBlanc = new ImageBrush();
            brushFishBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Fish.png"));
            FishBtn.Background = brushFishBlanc;

            var brushFruitBlanc = new ImageBrush();
            brushFruitBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruit.png"));
            FruitBtn.Background = brushFruitBlanc;

            var brushLegumeBlanc = new ImageBrush();
            brushLegumeBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Veget.png"));
            VegetBtn.Background = brushLegumeBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushEpiceBlanc = new ImageBrush();
            brushEpiceBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Epice.png"));
            EpiceBtn.Background = brushEpiceBlanc;

            var brushHoneyBlanc = new ImageBrush();
            brushHoneyBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Honey.png"));
            HoneyBtn.Background = brushHoneyBlanc;

            var brushPainsBlanc = new ImageBrush();
            brushPainsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Pain.png"));
            MangerBtn.Background = brushPainsBlanc;

            pivot3Titel.Text = "Oeufs";
            InfoPanel.Visibility = Visibility.Visible;
        }

        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }

        private void MangerClick(object sender, RoutedEventArgs e)
        {
            var brushPainCouleur = new ImageBrush();
            brushPainCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/PainCouleur.png"));
            MangerBtn.Background = brushPainCouleur;

            var brushFishBlanc = new ImageBrush();
            brushFishBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Fish.png"));
            FishBtn.Background = brushFishBlanc;

            var brushFruitBlanc = new ImageBrush();
            brushFruitBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruit.png"));
            FruitBtn.Background = brushFruitBlanc;

            var brushLegumeBlanc = new ImageBrush();
            brushLegumeBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Veget.png"));
            VegetBtn.Background = brushLegumeBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushEpiceBlanc = new ImageBrush();
            brushEpiceBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Epice.png"));
            EpiceBtn.Background = brushEpiceBlanc;

            var brushHoneyBlanc = new ImageBrush();
            brushHoneyBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Honey.png"));
            HoneyBtn.Background = brushHoneyBlanc;

            var brushEggsBlanc = new ImageBrush();
            brushEggsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Eggs.png"));
            EggBtn.Background = brushEggsBlanc;


            pivot4Titel.Text = "A Manger";
            InfoPanel.Visibility = Visibility.Visible;
        }

        private void FishClick(object sender, RoutedEventArgs e)
        {
            var brushFishCouleur = new ImageBrush();
            brushFishCouleur.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/FishCouleur.png"));
            FishBtn.Background = brushFishCouleur;

            var brushFruitBlanc = new ImageBrush();
            brushFruitBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/fruit.png"));
            FruitBtn.Background = brushFruitBlanc;

            var brushLegumeBlanc = new ImageBrush();
            brushLegumeBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Veget.png"));
            VegetBtn.Background = brushLegumeBlanc;

            var brushBleBlanc = new ImageBrush();
            brushBleBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/ble.png"));
            BleBtn.Background = brushBleBlanc;

            var brushEpiceBlanc = new ImageBrush();
            brushEpiceBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Epice.png"));
            EpiceBtn.Background = brushEpiceBlanc;

            var brushHoneyBlanc = new ImageBrush();
            brushHoneyBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Honey.png"));
            HoneyBtn.Background = brushHoneyBlanc;

            var brushEggsBlanc = new ImageBrush();
            brushEggsBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Eggs.png"));
            EggBtn.Background = brushEggsBlanc;

            var brushPainBlanc = new ImageBrush();
            brushPainBlanc.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Pain.png"));
            MangerBtn.Background = brushPainBlanc;

            pivot4Titel.Text = "Poissons";
            InfoPanel.Visibility = Visibility.Visible;
        }

        private void EpiceList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Alllist_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectedNourriture = (Nourriture)e.ClickedItem;
            Debug.WriteLine(SelectedNourriture.idowner);

            Frame.Navigate(typeof(App4.SignleProduct),"Nourriture");
        }
    }
}
