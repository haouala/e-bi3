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
using System.Net.Http;
using System.Diagnostics;
using Windows.UI.Popups;
using Windows.ApplicationModel.Email;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Welcome : Page
    {
        private List<Comment> Comments;
        private float CommentRate;
        private Comment mycom;
        public User producer ;
        public static int id;
        public Welcome()
        {
            this.InitializeComponent();
            Comments = CommentaireManagers.GetComments(ListNourriture.SelectedNourriture.idowner.ToString());
            // producer = User.UserManagers.GetUserById(48);
            //Debug.WriteLine(ListNourriture.SelectedNourriture.idowner);

           Debug.WriteLine( RaitingManager.getNbRaiteUser(MainPage.userConnected.id, id));
           /* var Pivot1Background = new ImageBrush();
            Pivot1Background.ImageSource = new BitmapImage(new Uri("" + ListArtisanat.SelectedArtisanat.ImageArtisanat));
            Pivot1.Background = Pivot1Background;*/
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
            var parameter = e.Parameter as string;
            if (parameter.Equals("Nourriture"))
            {
                id = ListNourriture.SelectedNourriture.idowner;
                Debug.WriteLine(id + "  eee");
                producer = UserManagers.GetUserById(id);
                Debug.WriteLine(producer.email);
                ProducerMail.Text = producer.email;
                ProducerPhone.Text = producer.tel.ToString();
                UserName.Text = producer.nom.ToString();
                UserDescription.Text = producer.description.ToString();
                ProducerTown.Text = producer.adresse.ToString();
            }
            if (parameter.Equals("Artisanat"))
            {
                id = ListArtisanat.SelectedArtisanat.idowner;
                Debug.WriteLine(id + "  eee");
                producer = UserManagers.GetUserById(id);
                Debug.WriteLine(producer.email);
                ProducerMail.Text = producer.email;
                ProducerPhone.Text = producer.tel.ToString();
                UserName.Text = producer.nom.ToString()+producer.prenom.ToString();
                UserDescription.Text = producer.description.ToString();
                ProducerTown.Text = producer.adresse.ToString();
            }
            if (parameter.Equals("Service"))
            {
                id = ListService.SelectedService.idowner;
                Debug.WriteLine(id + "  eee");
                producer = UserManagers.GetUserById(id);
                Debug.WriteLine(producer.email);
                ProducerMail.Text = producer.email;
                ProducerPhone.Text = producer.tel.ToString();
                UserName.Text = producer.nom.ToString();
                UserDescription.Text = producer.description.ToString();
                ProducerTown.Text = producer.adresse.ToString();
            }
            if (parameter.Equals("Multimedia"))
            {
                id = ListMultimedia.SelectedMultimedia.idowner;
                Debug.WriteLine(id + "  eee");
                producer = UserManagers.GetUserById(id);
                Debug.WriteLine(producer.email);
                ProducerMail.Text = producer.email;
                ProducerPhone.Text = producer.tel.ToString();
                UserName.Text = producer.nom.ToString();
                UserDescription.Text = producer.description.ToString();
                ProducerTown.Text = producer.adresse.ToString();
            }



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

        private void DDown5Tapped(object sender, TappedRoutedEventArgs e)
        {
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));

            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            CommentRate = -5;

        }

        private void Down4Tapped(object sender, TappedRoutedEventArgs e)
        {
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            CommentRate = -4;
        }

        private void Down3Tapped(object sender, TappedRoutedEventArgs e)
        {
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            CommentRate = -3;
        }

        private void Down2Tapped(object sender, TappedRoutedEventArgs e)
        {
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            CommentRate = -2;
        }

        private void Down1Tapped(object sender, TappedRoutedEventArgs e)
        {
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeFull.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            CommentRate = -1;
        }

        private void Up1Tapped(object sender, TappedRoutedEventArgs e)
        {
            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            CommentRate = 1;
        }

        private void Up2Tapped(object sender, TappedRoutedEventArgs e)
        {
            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            CommentRate = 2;
        }

        private void Up3Taped(object sender, TappedRoutedEventArgs e)
        {
            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            CommentRate = 3;
        }

        private void Up4Tapped(object sender, TappedRoutedEventArgs e)
        {
            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertVide.png"));

            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            CommentRate = 4;
        }

        private void Up5Tapped(object sender, TappedRoutedEventArgs e)
        {
            Up1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));
            Up5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleVertFull.png"));

            Down5.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down4.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down3.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down2.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));
            Down1.Source = new BitmapImage(new Uri("ms-appx:///Assets/CercleRougeVide.png"));

            CommentRate = 5;
        }

        private void CommentBtn_Click(object sender, RoutedEventArgs e)
        {
            CommentPannel.Visibility = Visibility.Visible;
        }

     

        private void Annuler_Click(object sender, RoutedEventArgs e)
        {
          

            

            CommentPannel.Visibility = Visibility.Collapsed;
        }

        private async void CommenterClick(object sender, RoutedEventArgs e)
        {

            // mycom = new Comment { Comentor = "Benkhelifa Myriam", ComentTxt = CommentBox.Text, ComentNote = CommentRate, CommentImg = "Assets/UserHraderImg.png", Thumb = "Assets/ThumbUp.png" };
            {
                String url = "http://localhost/PIMTLS/ajouterCommentaireUser.php";
                var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("descriptionUser",CommentBox.Text),
               // new KeyValuePair<string, string>("dateCommentUser","12/02/2016"),
                new KeyValuePair<string, string>("fk_idUser","62"),
                new KeyValuePair<string, string>("fkcommentuser",MainPage.userConnected.id.ToString())

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
                        var dialog = new MessageDialog("added succesfully ");
                        await dialog.ShowAsync();
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

        private void Homebtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PivotCS.Scenario1));
        }

        private void MapTapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MapPage));
        }

        private async void Rating_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.userConnected != null && !RaitingManager.getRaitingUser(MainPage.userConnected.id,id))
            {


                
                    String url = "http://localhost/PIMTLS/AjouterRaitingUser.php";
                    var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_raited",id.ToString()),
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


        private async void Rating1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.userConnected != null && !RaitingManager.getRaitingUser(MainPage.userConnected.id, id))
            {



                String url = "http://localhost/PIMTLS/AjouterRaitingUser.php";
                var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_raited",id.ToString()),
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

        private async void Rating2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.userConnected != null && !RaitingManager.getRaitingUser(MainPage.userConnected.id, id))
            {



                String url = "http://localhost/PIMTLS/AjouterRaitingUser.php";
                var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_raited",id.ToString()),
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

        private async void Rating3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.userConnected != null && !RaitingManager.getRaitingUser(MainPage.userConnected.id, id))
            {



                String url = "http://localhost/PIMTLS/AjouterRaitingUser.php";
                var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_raited",id.ToString()),
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

        private async void Rating4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MainPage.userConnected != null && !RaitingManager.getRaitingUser(MainPage.userConnected.id, id))
            {



                String url = "http://localhost/PIMTLS/AjouterRaitingUser.php";
                var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("id_raiter",MainPage.userConnected.id.ToString()),
                new KeyValuePair<string, string>("id_raited",id.ToString()),
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

        private void CallBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Windows.ApplicationModel.Calls.PhoneCallManager.ShowPhoneCallUI(producer.tel.ToString(), producer.nom.ToString());
        }

        private async void SendMailBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            EmailRecipient sendTo = new EmailRecipient()
            {
                Name = producer.nom,
                Address = producer.tel.ToString()
            };


            EmailMessage mail = new EmailMessage();
            mail.Subject = "eBi3  ";
            mail.Body = "";


            mail.To.Add(sendTo);

            await EmailManager.ShowComposeNewEmailAsync(mail);
        }
    }
}

