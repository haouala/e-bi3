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
   public  class Nourriture
    {
        public int id { get; set; }
        public String Owner { get; set; }
        public String OwnerTel { get; set; }
        public String Name { get; set; }
        public String Lieu { get; set; }

        public String Quantite { get; set; }

        public int Prix { get; set; }

        public String Date { get; set; }
        public Uri ImageNourriture { get; set; }

        public Uri ImageNourriture2 { get; set; }

        public Uri ImageNourriture3 { get; set; }
        public Uri OwnerImg { get; set; }
        public int idowner { get; set; }
        public string ProductImage1 { get; set; }


    }

    public class NourritureManagers
    {
        public static List<Nourriture> nourlist = new List<Nourriture>();
        public static List<Nourriture> subCategoryList = new List<Nourriture>();


        public static async void LoadContentsWithCategory(String category)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;
            
            try
            {
                if (category.Equals("Nourriture"))
                {
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getProductList.php?category="+category);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                    nourlist = new List<Nourriture>();
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

                        nourlist.Add(new Nourriture { Owner = u[0]["prenom"]+" "+ u[0]["nom"], OwnerTel = u[0]["tel"]+"",idowner=idproduct, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"]+"", ImageNourriture = img1,id=fk_id });
                    }
                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }
           
        }





        public static async void LoadContentsSearchByAddress(String adress)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/recherche/findProductByRegion.php?adresse=" + adress);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                    nourlist = new List<Nourriture>();
                    for (int i = 0; i < o.Count; i++)
                    {
                        int fk_id = (int)o[i]["owner"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                        string datauser = datataskuser.Result;
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        int price = (int)o[i]["price"];
                    Uri img1 = new Uri( o[i]["ProductImage1"]+"");
                    int idproduct = (int)o[i]["owner"];
                    Uri imgOwn = new Uri("" + u[0]["ImagePath"]);


                    nourlist.Add(new Nourriture {id=fk_id, Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "", idowner = idproduct, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageNourriture = img1 });
                    }
                
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }

        public static async void LoadContentsSearchByPrice(string priceMin,string priceMax)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/recherche/findProductByPriceMinMax.php?min=" + priceMin+"&max="+priceMax);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                    nourlist = new List<Nourriture>();
                    for (int i = 0; i < o.Count; i++)
                    {
                        int fk_id = (int)o[i]["id"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                        string datauser = datataskuser.Result;
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        int price = (int)o[i]["price"];
                    int idproduct = (int)o[i]["owner"];

                    Uri img1 = new Uri("" + o[i]["ProductImage1"]);
                    Uri imgOwn = new Uri("" + u[0]["ImagePath"]);

                    nourlist.Add(new Nourriture {id=fk_id, Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "",idowner=idproduct, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageNourriture = img1 });
                    }
                
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }
        /******************ajout dans une liste selon le sous categorie*********************/
        public static async void LoadContentsWithSubCategory(String subcategory,String category)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getSubCategoryProductList.php?sub_category=" + subcategory+"& category="+category);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                subCategoryList = new List<Nourriture>();
                for (int i = 0; i < o.Count; i++)
                    {
                        int fk_id = (int)o[i]["id"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                        string datauser = datataskuser.Result;
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        int price = (int)o[i]["price"];
                    int idproduct = (int)o[i]["owner"];
                    Uri img1 = new Uri("" + o[i]["ProductImage1"]);
                    Uri imgOwn = new Uri("" + u[0]["ImagePath"]);

                    subCategoryList.Add(new Nourriture {id=fk_id, Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "",idowner=idproduct, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageNourriture = img1 });
                    }
                
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }
        public static List<Nourriture> getNourritureByRegion(String adress)
        {
            LoadContentsSearchByAddress(adress);           
                return nourlist;
        }

        public static List<Nourriture> getNourritureByPrice(string priceMin,string priceMax)
        {
            LoadContentsSearchByPrice(priceMin,priceMax);
            return nourlist;
        }


        public static List<Nourriture> GetNourriture()
        {
            LoadContentsWithCategory("Nourriture");
            return  nourlist;
        }

        public static List<Nourriture> GetLegumes()
        {
            var LegumesList = new List<Nourriture>();
            LoadContentsWithSubCategory("Legumes", "Nourriture");
           /* LegumesList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Poivrons Verts", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Tomates.png" });
            LegumesList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Tomates Cap", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Poivrons.png" });
            LegumesList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Laitue Vert", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Laitue.png" });
            LegumesList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Miel d'orange", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Miel.jpg" });
        
    */
            return subCategoryList;
        }

        public static List<Nourriture> GetFruit()
        {
            var FruitList = new List<Nourriture>();
            LoadContentsWithSubCategory("Fruit", "Nourriture");
           /* FruitList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Pastéques", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Pasteque.jpg" });
            FruitList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Cerises", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Cerise.jpg" });
            FruitList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Péches", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Peche.jpg" });
            FruitList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Pommes", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Pomme.jpg" });
*/

            return subCategoryList;
        }

        public static List<Nourriture> GetEpice()
        {
            var EpiceList = new List<Nourriture>();
            LoadContentsWithSubCategory("Epice", "Nourriture");
            /*EpiceList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Diff.Epices", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Epice1.jpg" });
            EpiceList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Vanilles", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Epice2.jpg" });
            EpiceList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Tebél", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Epice3.jpg" });
            EpiceList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Curcumin", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Epice4.jpg" });
            */

            return subCategoryList;
        }
    }
}
