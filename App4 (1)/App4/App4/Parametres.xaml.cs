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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Parametres : Page
    {
        private List<Nourriture> Nourritures;
        private Nourriture Produit;
        private List<Comment> Comments;
        public Parametres()
        {
            this.InitializeComponent();
            //Nourritures = NourritureManagers.GetNourriture();
            Comments = CommentaireManagers.GetComments("62");
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

        private void Grid_ItemClick(object sender, ItemClickEventArgs e)
        {
            Produit = (Nourriture)e.ClickedItem;
            ProduitName.Text = Produit.Name.ToString();
            ProduitPrix.Text = Produit.Prix.ToString();
            ProduitQuantite.Text = Produit.Quantite.ToString();
            ImageProduit1.Source = new BitmapImage(new Uri("ms-appx:///" + Produit.ImageNourriture));
            ImageProduit2.Source = new BitmapImage(new Uri("ms-appx:///" + Produit.ImageNourriture2));
            ImageProduit3.Source = new BitmapImage(new Uri("ms-appx:///" + Produit.ImageNourriture3));
            DetailPannel.Visibility = Visibility.Visible;
          
        }

        private void AnnulerClick(object sender, RoutedEventArgs e)
        {
            DetailPannel.Visibility = Visibility.Collapsed;
        }
    }
}
