using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App4.Models
{
    public class Publication
    {
        public int id { get; set; }
        public String Owner { get; set; }
        public String OwnerTel { get; set; }
        public String Name { get; set; }
        public String Lieu { get; set; }

        public String Quantite { get; set; }

        public int Prix { get; set; }

        public String Date { get; set; }
        public Uri ImagePublication { get; set; }

        public Uri ImagePublication2 { get; set; }

        public Uri ImagePublication3 { get; set; }
        public Uri OwnerImg { get; set; }
        public int idowner { get; set; }
        public string ProductImage1 { get; set; }
    }
    public class PublicationManager
    {
        public static List<Publication> nourlist = new List<Publication>();
        public static async void LoadContentsWithCategory(String idOwner)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
               
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getAllProduct.php?idOwner=" + idOwner);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                    nourlist = new List<Publication>();
                    for (int i = 0; i < o.Count; i++)
                    {
                        //coucou
                        int fk_id = (int)o[i]["id"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                        string datauser = datataskuser.Result;
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        int price = (int)o[i]["price"];
                        int idproduct = (int)o[i]["owner"];
                        Uri img1 = new Uri("" + o[i]["ProductImage1"]);
                        //Uri img2 = new Uri("http://" + o[i]["image"]);
                        // Uri img3 = new Uri("http://" + o[i]["image"]);

                        Uri imgOwn = new Uri("" + u[0]["ImagePath"]);

                        nourlist.Add(new Publication { Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "", idowner = idproduct, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImagePublication = img1, id = fk_id });
                    
                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }

        public static List<Publication> getAllProduct(String id)
        {
            LoadContentsWithCategory(id);
            return nourlist;
        }
    }
}
