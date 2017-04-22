using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
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
    public sealed partial class AjouterProduit : Page
    {

        //
        public string image;
        public string imageName;
        StorageFile file;
        private Stream stream = new MemoryStream();
        //
        public static string cat = "Nourriture";
        public AjouterProduit()
        {
            this.InitializeComponent();
          
        }

        private async void btnAjouterProduit_Tapped(object sender, TappedRoutedEventArgs e)
        {

            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri("http://localhost/PIMTLS/hayfa.php");
            MultipartFormDataContent form = new MultipartFormDataContent();
            HttpContent content = new StringContent("fileToUpload");
            form.Add(content, "fileToUpload");
            var stream = await file.OpenStreamForReadAsync();
            content = new StreamContent(stream);
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "fileToUpload",
                FileName = file.Name
            };
            form.Add(content);
            var response2 = await client2.PostAsync("hayfa.php", form);
            Debug.WriteLine(response2.Content.ReadAsStringAsync().Result);

            //////////////////////////////////////////////////////

            Debug.WriteLine(DateTime.Today.Date);
          //  int quantite = Int32.Parse(PrixTxtBox.Text);
            String url = "http://localhost/PIMTLS/AjouterProduit.php";
            if (cat.Equals("Nourriture"))
            {
                var values = new List<KeyValuePair<String, String>>
            {

                new KeyValuePair<string, string>("name",NomTxtBox.Text),
                new KeyValuePair<string, string>("quantity",QuantiteTxtBox.Text),
                new KeyValuePair<string, string>("price",PrixTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("category",cat),
                new KeyValuePair<string, string>("date",DateTime.Today.Date.ToString()),
                new KeyValuePair<string, string>("description",DescriptionTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("SubCategory",Nourriture.SelectionBoxItem.ToString()),
                new KeyValuePair<string, string>("owner","62"),
        new KeyValuePair<string, string>("ProductImage1","localhost/PIMTLS/Image/"+img.Text)
         
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


            if (cat.Equals("Multimedia"))
            {
                var values = new List<KeyValuePair<String, String>>
            {

                new KeyValuePair<string, string>("name",NomTxtBox.Text),
                new KeyValuePair<string, string>("quantity",QuantiteTxtBox.Text),
                new KeyValuePair<string, string>("price",PrixTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("category",cat),
                new KeyValuePair<string, string>("date",DateTime.Today.Date.ToString()),
                new KeyValuePair<string, string>("description",DescriptionTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("SubCategory",Mulitmedia.SelectionBoxItem.ToString()),
                new KeyValuePair<string, string>("owner","62"),
                        new KeyValuePair<string, string>("ProductImage1","localhost/PIMTLS/Image/"+img.Text)



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



            if (cat.Equals("Services"))
            {
                var values = new List<KeyValuePair<String, String>>
            {

                new KeyValuePair<string, string>("name",NomTxtBox.Text),
                new KeyValuePair<string, string>("quantity",QuantiteTxtBox.Text),
                new KeyValuePair<string, string>("price",PrixTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("category",cat),
                new KeyValuePair<string, string>("date",DateTime.Today.Date.ToString()),
                new KeyValuePair<string, string>("description",DescriptionTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("SubCategory",Services.SelectionBoxItem.ToString()),
                new KeyValuePair<string, string>("owner","62"),
                        new KeyValuePair<string, string>("ProductImage1","localhost/PIMTLS/Image/"+img.Text)



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



            if (cat.Equals("Artisanat"))
            {
                var values = new List<KeyValuePair<String, String>>
            {

                new KeyValuePair<string, string>("name",NomTxtBox.Text),
                new KeyValuePair<string, string>("quantity",QuantiteTxtBox.Text),
                new KeyValuePair<string, string>("price",PrixTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("category",cat),
                new KeyValuePair<string, string>("date",DateTime.Today.Date.ToString()),
                new KeyValuePair<string, string>("description",DescriptionTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("SubCategory",Artisanat.SelectionBoxItem.ToString()),
                new KeyValuePair<string, string>("owner","62"),
                        new KeyValuePair<string, string>("ProductImage1","localhost/PIMTLS/Image/"+img.Text)



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

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Category.SelectedIndex.ToString().Equals("0")){
                cat = "Nourriture";
                Nourriture.Visibility = Visibility.Visible;
                Artisanat.Visibility = Visibility.Collapsed;
                Services.Visibility = Visibility.Collapsed;
                Mulitmedia.Visibility = Visibility.Collapsed;
            }
            if (Category.SelectedIndex.ToString().Equals("1"))
            {
                cat = "Artisanat";
                Nourriture.Visibility = Visibility.Collapsed;
                Artisanat.Visibility = Visibility.Visible;
                Services.Visibility = Visibility.Collapsed;
                Mulitmedia.Visibility = Visibility.Collapsed;
            }
            if (Category.SelectedIndex.ToString().Equals("3"))
            {
                cat = "Multimedia";
                Nourriture.Visibility = Visibility.Collapsed;
                Artisanat.Visibility = Visibility.Collapsed;
                Services.Visibility = Visibility.Collapsed;
                Mulitmedia.Visibility = Visibility.Visible;
            }
            if (Category.SelectedIndex.ToString().Equals("2"))
            {
                cat = "Services";
                Nourriture.Visibility = Visibility.Collapsed;
                Artisanat.Visibility = Visibility.Collapsed;
                Services.Visibility = Visibility.Visible;
                Mulitmedia.Visibility = Visibility.Collapsed;
            }
        }

        private async void UploadImage_Click(object sender, RoutedEventArgs e)
        {

            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");

            file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                img.Text = file.Name;
               
                using (IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    await bitmapImage.SetSourceAsync(fileStream);
                    fileStream.AsStream().CopyTo(stream);
                    imageContainer.Source = bitmapImage;
                }
            }
        }
    }
}
