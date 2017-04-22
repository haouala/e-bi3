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
    public sealed partial class InscriptionPage : Page
    {

        //
        public string image;
        public string imageName;
        StorageFile file;
        private Stream stream = new MemoryStream();
        //


        public InscriptionPage()
        {
            this.InitializeComponent();
        }

        private async void btnSignIn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            HttpClient client2 = new HttpClient();
            client2.BaseAddress = new Uri("http://localhost/PIMTLS/hayfaUser.php");
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


            String url = "http://localhost/PIMTLS/InscriptionUser.php";
                var values = new List<KeyValuePair<String, String>>
            {
                new KeyValuePair<string, string>("nom",NomTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("prenom",PrenomTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("tel",TelTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("adresse",AdresseTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("password",PasswordTxtBox.Password.ToString()),
                new KeyValuePair<string, string>("description",DescriptionTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("mail",MailTxtBox.Text.ToString()),
                new KeyValuePair<string, string>("pseudo",PseudoTxtBox.Text.ToString()),
                  new KeyValuePair<string, string>("ImagePath","localhost/PIMTLS/Image/"+img.Text)
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
