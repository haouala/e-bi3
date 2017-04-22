//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using App4.Models;
using SDKTemplate;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PivotCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1 : Page
    {
        private MainPage rootPage;
        public List<SampleDataModel> NewItems = null;
        public List<SampleDataModel> FlaggedItems = null;
        public List<SampleDataModel> AllItems = null;
        private List<NourritureCategorie> listOfNourriture = new List<NourritureCategorie>();
        private List<CategorieArtisanat> listOfArtisanat = new List<CategorieArtisanat>();
        private List<CategorieService> listOfService = new List<CategorieService>();
        private List<CategorieMultimedia> listOfMultimedia = new List<CategorieMultimedia>();
        private List<Comment> Comments;
        public String category;

        public Scenario1()
        {
            this.InitializeComponent();

            NewItems = SampleDataModel.GetSampleData().Where(x => x.IsNew).ToList();
            FlaggedItems = SampleDataModel.GetSampleData().Where(x => x.IsFlagged).ToList();
            AllItems = SampleDataModel.GetSampleData().ToList();
            Comments = CommentaireManagers.GetComments("62");





            listOfNourriture.Add(new NourritureCategorie { Name = "Legume",Description= "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte." ,Image = "Assets/CategorieLegumes.png" });
            listOfNourriture.Add(new NourritureCategorie { Name = "Blé et Orage", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieBle.png" });
            listOfNourriture.Add(new NourritureCategorie { Name = "Viande", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieViande.png" });
            listOfNourriture.Add(new NourritureCategorie { Name = "Oeuf", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieOeuf.png" });




            listOfArtisanat.Add(new CategorieArtisanat { Name = "Tappisserie", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieTappisserie.png" });
            listOfArtisanat.Add(new CategorieArtisanat { Name = "Poterie", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategoriePoterie.png" });
            listOfArtisanat.Add(new CategorieArtisanat { Name = "Broderie", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieBroderie.png" });
            listOfArtisanat.Add(new CategorieArtisanat { Name = "Peinture", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategoriePeinture.png" });


            listOfService.Add(new CategorieService { Name = "Menage", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieMenage.png" });
            listOfService.Add(new CategorieService { Name = "Réparation", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieReparation.png" });
            listOfService.Add(new CategorieService { Name = "Baby Sitting", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieBabySitting.jpg" });
            listOfService.Add(new CategorieService { Name = "Education", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieEducation.png" });

            listOfMultimedia.Add(new CategorieMultimedia { Name = "Informatique", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieInformatique.png" });
            listOfMultimedia.Add(new CategorieMultimedia { Name = "Téléphones", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieTelephone.png" });
            listOfMultimedia.Add(new CategorieMultimedia { Name = "TV", Description = "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/Categorietv.png" });
            listOfMultimedia.Add(new CategorieMultimedia { Name = "Son",Description= "Lorem Ipsum est un générateur de faux textes aléatoires. Vous choisissez le nombre de paragraphes, de mots ou de listes. Vous obtenez alors un texte aléatoire que vous pourrez ensuite utiliser librement dans vos maquettes Le texte généré est du pseudo latin et peut donner limpression dêtre du vrai texte.", Image = "Assets/CategorieSon.png" });

            NourritureList.ItemsSource = listOfNourriture;
            ArtisanatList.ItemsSource = listOfArtisanat;
            ServiceList.ItemsSource = listOfService;
            MultimediaList.ItemsSource = listOfMultimedia;

            this.DataContext = this;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //rootPage = MainPage.Current;
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SampleDataModel SelectedItem = null;

            if (e.AddedItems.Count >= 1)
            {
                SelectedItem = e.AddedItems[0] as SampleDataModel;
                (sender as ListView).SelectedItem = null;
                ShowItem(SelectedItem);
            }

        }
        async private void ShowItem(SampleDataModel model)
        {
            var MyDialog = new ContentDialog();

            if (model != null)
            {
                var MyImage = new Image();
                MyImage.Source = new BitmapImage(new Uri(model.ImagePath));
                MyImage.HorizontalAlignment = HorizontalAlignment.Stretch;
                MyImage.VerticalAlignment = VerticalAlignment.Stretch;
                MyImage.Stretch = Windows.UI.Xaml.Media.Stretch.UniformToFill;
                MyDialog.Title = String.Format("You have selected {0}", model.ToString());
                MyDialog.Content = MyImage;
            }
            else
            {
                MyDialog.Title = "No item found";

            }

            MyDialog.PrimaryButtonText = "OK";
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () => await MyDialog.ShowAsync());
        }
        private void Scenario2_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            //this.Frame.Navigate(typeof(Scenario2));
        }
        private void Scenario3_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
           // this.Frame.Navigate(typeof(Scenario3));
        }

      

        private void NourritureList_ItemClick(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            /*   string name = ((NourritureCategorie)e.Item).Name;
               var test = this.Parent as Frame;

               Frame.Navigate(typeof(ListItemCategorie), name);*/
            // Debug.WriteLine(((NourritureCategorie)e.OriginalSource).Name);
            Debug.WriteLine("noulistitemclick");
        }

       
        private void NourritureList_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {


            if (NourritureList.SelectedIndex == 0)
            // NourritureList.Visibility = Visibility.Collapsed;
            {
                category = "Legume";
            
            }
            if (NourritureList.SelectedIndex == 1)
                category = "Epice";
            if (NourritureList.SelectedIndex == 2)
                category = "Fruit";
            if (NourritureList.SelectedIndex == 3)
                category = "Legume";
            Frame.Navigate(typeof(App4.ListNourriture), category);
           // List<Nourriture> nourritur = NourritureManagers.GetLegumes();
        }
        public void ArtisanatList_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            if (ArtisanatList.SelectedIndex == 0)
                category = "Tappisserie";
            if (ArtisanatList.SelectedIndex == 1)
                category = "Poterie";
            if (ArtisanatList.SelectedIndex == 2)
                category = "Broderie";
            if (ArtisanatList.SelectedIndex == 3)
                category = "Peinture";
            Frame.Navigate(typeof(App4.ListArtisanat), category);
          //  List<Artisanat> nourritur = ArtisanatMangaer.GetArtisanat();
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
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

        private   void Ontapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListNourriture),"Nourriture");
            //Debug.WriteLine("coucou");
            
        }

        private void ArtisanaTapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.SignleProduct));
        }

        private void SearchTapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.RecherchePage));
        }

        private void UpdateTap(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListPublicationUser));
        }

        private void ServiceList_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            if (ServiceList.SelectedIndex == 0)
                //Debug.WriteLine("111111");
                category = "Menage";
            if (ServiceList.SelectedIndex == 1)
                category = "Reparation";
            if (ServiceList.SelectedIndex == 2)
                category = "BabySitting";
            if (ServiceList.SelectedIndex == 3)
                category = "Education";
            Frame.Navigate(typeof(App4.ListService), category);
        }

        private void MultimediaList_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            if (MultimediaList.SelectedIndex == 0)
                category = "Informatique";
            if (MultimediaList.SelectedIndex == 1)
                category = "Telephone";
            if (MultimediaList.SelectedIndex == 2)
                category = "TV";
            if (MultimediaList.SelectedIndex == 3)
                category = "Son";
            Frame.Navigate(typeof(App4.ListMultimedia), category);
        }

        private void FavoritesListBoxItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListArtisanat), "Artisanat");
        }

        private void ServiceListBoxItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListService), "Service");
        }

        private void ImmobilierListBoxItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListImmobilier), "Immobilier");
        }

        private void MultimediaListBoxItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListMultimedia), "Multimedia");

        }

        private void VettementListBoxItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListVetement), "Vetement");


        }

        private void VehiculeListBoxItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.AjouterProduit));
        }
    }
}
