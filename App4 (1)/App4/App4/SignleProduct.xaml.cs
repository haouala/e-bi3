using App4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class SignleProduct : Page
    {
        private List<Comment> Comments;
        public static string param;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var parameter = e.Parameter as string;
            param = parameter;
            Debug.WriteLine(param);



            Debug.WriteLine(param + "+++++++++++");
            if(parameter.Equals("Nourriture"))
            { 

            ProductName.Text = ListNourriture.SelectedNourriture.Name;

            var Pivot1Background = new ImageBrush();
            Pivot1Background.ImageSource = new BitmapImage(new Uri("" + ListNourriture.SelectedNourriture.ImageNourriture));
            Pivot1.Background = Pivot1Background;

            var Pivot2Background = new ImageBrush();
            Pivot2Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListNourriture.SelectedNourriture.ImageNourriture2));
            Pivot2.Background = Pivot2Background;

            var Pivot3Background = new ImageBrush();
            Pivot3Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListNourriture.SelectedNourriture.ImageNourriture3));
            Pivot3.Background = Pivot3Background;

            OwnerImage.Source = new BitmapImage(new Uri("" + ListNourriture.SelectedNourriture.OwnerImg));
            OwnerName.Text = ListNourriture.SelectedNourriture.Owner;
            OwnerNumber.Text = ListNourriture.SelectedNourriture.OwnerTel;
            ProductPrice.Text = ListNourriture.SelectedNourriture.Prix.ToString() + " dt";
            ProductQuantite.Text = ListNourriture.SelectedNourriture.Quantite;

            Comments = CommentaireManagers.GetComments("62");
            }
            if (parameter.Equals("Artisanat")) {
                ProductName.Text = ListArtisanat.SelectedArtisanat.Name;

                var Pivot1Background = new ImageBrush();
                Pivot1Background.ImageSource = new BitmapImage(new Uri("" + ListArtisanat.SelectedArtisanat.ImageArtisanat));
                Pivot1.Background = Pivot1Background;

                var Pivot2Background = new ImageBrush();
                Pivot2Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListArtisanat.SelectedArtisanat.ImageArtisanat2));
                Pivot2.Background = Pivot2Background;

                var Pivot3Background = new ImageBrush();
                Pivot3Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListArtisanat.SelectedArtisanat.ImageArtisanat3));
                Pivot3.Background = Pivot3Background;

                OwnerImage.Source = new BitmapImage(new Uri("" + ListArtisanat.SelectedArtisanat.OwnerImg));
                OwnerName.Text = ListArtisanat.SelectedArtisanat.Owner;
                OwnerNumber.Text = ListArtisanat.SelectedArtisanat.OwnerTel;
               
                ProductPrice.Text = ListArtisanat.SelectedArtisanat.Prix.ToString() + " dt";
                ProductQuantite.Text = ListArtisanat.SelectedArtisanat.Quantite;

                Comments = CommentaireManagers.GetComments("62");
            }

            if (parameter.Equals("Service"))
            {
                ProductName.Text = ListService.SelectedService.Name;

                var Pivot1Background = new ImageBrush();
                Pivot1Background.ImageSource = new BitmapImage(new Uri("" + ListService.SelectedService.ImageService));
                Pivot1.Background = Pivot1Background;

                var Pivot2Background = new ImageBrush();
                Pivot2Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListService.SelectedService.ImageService2));
                Pivot2.Background = Pivot2Background;

                var Pivot3Background = new ImageBrush();
                Pivot3Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListService.SelectedService.ImageService3));
                Pivot3.Background = Pivot3Background;

                OwnerImage.Source = new BitmapImage(new Uri("" + ListService.SelectedService.OwnerImg));
                OwnerName.Text = ListService.SelectedService.Owner;
                OwnerNumber.Text = ListService.SelectedService.OwnerTel;
                ProductPrice.Text = ListService.SelectedService.Prix.ToString() + " dt";
                ProductQuantite.Text = ListService.SelectedService.Quantite;

                Comments = CommentaireManagers.GetComments("62");
            }


            if (parameter.Equals("Multimedia"))
            {
                ProductName.Text = ListMultimedia.SelectedMultimedia.Name;

                var Pivot1Background = new ImageBrush();
                Pivot1Background.ImageSource = new BitmapImage(new Uri("" + ListMultimedia.SelectedMultimedia.ImageMultimedia));
                Pivot1.Background = Pivot1Background;

                var Pivot2Background = new ImageBrush();
                Pivot2Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListMultimedia.SelectedMultimedia.ImageMultimedia2));
                Pivot2.Background = Pivot2Background;

                var Pivot3Background = new ImageBrush();
                Pivot3Background.ImageSource = new BitmapImage(new Uri("ms-appx:///" + ListMultimedia.SelectedMultimedia.ImageMultimedia3));
                Pivot3.Background = Pivot3Background;

                OwnerImage.Source = new BitmapImage(new Uri("" + ListMultimedia.SelectedMultimedia.OwnerImg));
                OwnerName.Text = ListMultimedia.SelectedMultimedia.Owner;
                OwnerNumber.Text = ListMultimedia.SelectedMultimedia.OwnerTel;
                ProductPrice.Text = ListMultimedia.SelectedMultimedia.Prix.ToString() + " dt";
                ProductQuantite.Text = ListMultimedia.SelectedMultimedia.Quantite;

                Comments = CommentaireManagers.GetComments("62");
            }
        }
        public SignleProduct()
        {
            this.InitializeComponent();
          

           




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

        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }

        private void Pivot2Leave(object sender, DragEventArgs e)
        {
            
            Circle2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleFull.png"));
            Circle1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVide.png"));
            Circle3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVide.png"));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Welcome),param);
        }

        private async void Rating_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            Debug.WriteLine("raite1");
            if (MainPage.userConnected != null && !RaitingManager.getRaitingProduct(MainPage.userConnected.id,ListNourriture.SelectedNourriture.id))
            {

                if (param.Equals("Nourriture"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListNourriture.SelectedNourriture.id.ToString()),
                new KeyValuePair<string, string>("nombre","1")


            };
               

            HttpClient client = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage();

            

            try
            {
                response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                //   Comments = CommentaireManagers.GetComments("62");
                if (response.IsSuccessStatusCode)
                {
                    

                    Debug.WriteLine(response.StatusCode.ToString());
                  //  var dialog = new MessageDialog("added succesfully ");
                   // await dialog.ShowAsync();
                }
                else
                {
                    // problems handling here
                    string msg = response.IsSuccessStatusCode.ToString();

                    throw new Exception(msg);
                }

            }
            catch (Exception exc)
            {
                // .. and understanding the error here
                Debug.WriteLine(exc.ToString());
            }
            }

                if (param.Equals("Artisanat"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListArtisanat.SelectedArtisanat.id.ToString()),
                new KeyValuePair<string, string>("nombre","1")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Service"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListService.SelectedService.id.ToString()),
                new KeyValuePair<string, string>("nombre","1")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Multimedia"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","1")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                 if (param.Equals("Multimedia"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","1")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
            }

        }

        private async void Rating1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("raite2");
            if (MainPage.userConnected != null && !RaitingManager.getRaitingProduct(MainPage.userConnected.id, ListNourriture.SelectedNourriture.id))
            {

                if (param.Equals("Nourriture"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListNourriture.SelectedNourriture.id.ToString()),
                new KeyValuePair<string, string>("nombre","2")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }

                if (param.Equals("Artisanat"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListArtisanat.SelectedArtisanat.id.ToString()),
                new KeyValuePair<string, string>("nombre","2")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Service"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListService.SelectedService.id.ToString()),
                new KeyValuePair<string, string>("nombre","2")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Multimedia"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","2")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Immobilier"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","2")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
            }
        }

        private async void Rating3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("raite3");

            if (MainPage.userConnected != null && !RaitingManager.getRaitingProduct(MainPage.userConnected.id, ListNourriture.SelectedNourriture.id))
            {

                if (param.Equals("Nourriture"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListNourriture.SelectedNourriture.id.ToString()),
                new KeyValuePair<string, string>("nombre","3")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }

                if (param.Equals("Artisanat"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListArtisanat.SelectedArtisanat.id.ToString()),
                new KeyValuePair<string, string>("nombre","3")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Service"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListService.SelectedService.id.ToString()),
                new KeyValuePair<string, string>("nombre","3")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Multimedia"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","3")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Immobilier"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","3")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
            }
        }

        private async void Rating2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("raite4");

            if (MainPage.userConnected != null && !RaitingManager.getRaitingProduct(MainPage.userConnected.id, ListNourriture.SelectedNourriture.id))
            {

                if (param.Equals("Nourriture"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListNourriture.SelectedNourriture.id.ToString()),
                new KeyValuePair<string, string>("nombre","4")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }

                if (param.Equals("Artisanat"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListArtisanat.SelectedArtisanat.id.ToString()),
                new KeyValuePair<string, string>("nombre","4")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Service"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListService.SelectedService.id.ToString()),
                new KeyValuePair<string, string>("nombre","4")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Multimedia"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","4")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Immobilier"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","4")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
            }
        }

        private async void Rating4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("raite5");
            Debug.WriteLine(ListNourriture.SelectedNourriture.id.ToString());
            Debug.WriteLine(MainPage.userConnected.id.ToString());
            if (MainPage.userConnected != null && !RaitingManager.getRaitingProduct(MainPage.userConnected.id, ListNourriture.SelectedNourriture.id))
            {

                if (param.Equals("Nourriture"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListNourriture.SelectedNourriture.id.ToString()),
                new KeyValuePair<string, string>("nombre","5")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }

                if (param.Equals("Artisanat"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListArtisanat.SelectedArtisanat.id.ToString()),
                new KeyValuePair<string, string>("nombre","5")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Service"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListService.SelectedService.id.ToString()),
                new KeyValuePair<string, string>("nombre","5")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Multimedia"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","5")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
                if (param.Equals("Immobilier"))
                {
                    String url = "http://localhost/PIMTLS/AjouterRaiting.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_product",ListMultimedia.SelectedMultimedia.id.ToString()),
                new KeyValuePair<string, string>("nombre","5")


            };


                    HttpClient client = new HttpClient();

                    HttpResponseMessage response = new HttpResponseMessage();



                    try
                    {
                        response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                        //   Comments = CommentaireManagers.GetComments("62");
                        if (response.IsSuccessStatusCode)
                        {


                            Debug.WriteLine(response.StatusCode.ToString());
                            //  var dialog = new MessageDialog("added succesfully ");
                            // await dialog.ShowAsync();
                        }
                        else
                        {
                            // problems handling here
                            string msg = response.IsSuccessStatusCode.ToString();

                            throw new Exception(msg);
                        }

                    }
                    catch (Exception exc)
                    {
                        // .. and understanding the error here
                        Debug.WriteLine(exc.ToString());
                    }
                }
            }
        }
    }
}
