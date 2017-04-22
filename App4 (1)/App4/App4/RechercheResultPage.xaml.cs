using App4.Models;
using Newtonsoft.Json.Linq;
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
    public sealed partial class RechercheResultPage : Page
    {
        public static List<Nourriture> productlist = new List<Nourriture>();
        public List<Nourriture> Nourritures = new List<Nourriture>();
        public static string region;
        public static int pricemin;
        public static int pricemax;
        public static string category;
        public static string name;

        public RechercheResultPage()
        {
            this.InitializeComponent();
           // Nourritures = NourritureManagers.getNourritureByRegion("khaznadar");

        }



        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary = e.Parameter as Dictionary<string, string>;
            region = myDictionary["region"].ToString();
             name = myDictionary["name"].ToString();

            string priceMin = myDictionary["priceMin"].ToString();
            string priceMax = myDictionary["priceMax"].ToString();
           category = myDictionary["category"].ToString();
           /* if (!priceMin.Equals("") || !priceMax.Equals(""))
            {
                pricemin = Int32.Parse(priceMin);
                pricemax = Int32.Parse(priceMax);
            }*/
            Nourritures = Recherche.getProduct(name, priceMin, priceMax, region, category);
          


           /* if (lien.Equals("ms-appx:///Assets/Tunis.png"))
            {
                // Nourritures = NourritureManagers.getNourritureByRegion("khaznadar");
                Nourritures = NourritureManagers.getNourritureByPrice(priceMin, priceMax);
            }
            else if (lien.Equals("ms-appx:///Assets/Ariana.png"))
            {
                Nourritures = NourritureManagers.getNourritureByRegion("hidra el Kef");

            }*/
        }





        /*************************************************************************/


        /*public static async void LoadContentsWithCategory(String category)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                 string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/recherche1.php?name="+name+"&minprice="+pricemin+"&maxprice="+pricemax+"&place="+region+"&category="+category+"&sub_category=");
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                   // productlist = new List<Nourriture>();
                    for (int i = 0; i < o.Count; i++)
                    {
                        int fk_id = (int)o[i]["id"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                        string datauser = datataskuser.Result;
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        int price = (int)o[i]["price"];


                        productlist.Add(new Nourriture { Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "", Name = o[i]["name"] + "", OwnerImg = "Assets/UserHraderImg.png", Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageNourriture = "Assets/Dattes.png" });
                    
                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }
            

        }*/



        /*****************************************************************************/
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Ontapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(App4.ListNourriture), "Nourriture");
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
            Frame.Navigate(typeof(App4.Parametres));
        }



        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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


    }
}
