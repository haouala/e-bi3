using App4.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Class1
    {
        public static List<Nourriture> nourlist;
        public static async void LoadContents()
        {
            
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            try
            {

              //  NourritureManagers.nourlist = new List<Nourriture>();
                
                string responseBodyAsText;

                // HttpResponseMessage response = httpClient.GetAsync("http://localhost/list.php").Result;

                //response = await client.PostAsync(url, new FormUrlEncodedContent(values));
                // response.EnsureSuccessStatusCode();
                //responseBodyAsText = response.Content.ReadAsStringAsync().Result;
                // responseLine = responseBodyAsText;
                string Website = "http://localhost/list.php";
                Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getProductList.php?category=Nourriture");
                string data = await datatask;
                o = JArray.Parse(data);
                // Debug.WriteLine("firstname:" + o[0]["firstname"]);
                for (int i = 0; i < o.Count; i++)
                {
                    Debug.WriteLine("firstname:" + o[i]["name"]);
                    //firstname.Text = o[i]["firstname"] + "";
                    int price = (int)o[i]["price"];
                    
                    //    nourlist.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "52.444.024", Name = o[i]["name"]+"", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Tozeur,Néfza", Quantite = o[i]["quantity"] + "", Prix =price, Date = o[i]["date"]+"", ImageNourriture = "Assets/Dattes.png" });
                //   NourritureManagers.nourlist.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "52.444.024", Name = "", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Tozeur,Néfza", Quantite = "", Prix = 4, Date = "", ImageNourriture = "Assets/Dattes.png" });

                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }
            
        }
    }
}
