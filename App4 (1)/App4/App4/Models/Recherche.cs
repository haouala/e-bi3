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
    public class Recherche
    {
        public static List<Nourriture> productlist = new List<Nourriture>();



        public static async void LoadContentsWithCategory(String name,string pricemin,string pricemax,string region,string category)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                string responseBodyAsText;
                string Website = "http://localhost/list.php";
                Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/recherche1.php?name=" + name + "&minprice=" + pricemin + "&maxprice=" + pricemax + "&place=" + region + "&category=" + category + "&sub_category=");
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

                    Uri img1 = new Uri("http://" + o[i]["ProductImage1"]);
                    Uri imgOwn = new Uri("" + u[0]["ImagePath"]);

                    productlist.Add(new Nourriture { Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "", Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageNourriture = img1 });

                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }
        public static List<Nourriture> getProduct(String name, string pricemin, string pricemax, string region, string category)
        {
            LoadContentsWithCategory(name,pricemin,pricemax,region,category);
            return productlist;
        }
    }
}
