﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App4.Models
{
    public class Service
    {
        public int id { get; set; }
        public String Owner { get; set; }
        public String OwnerTel { get; set; }
        public String Name { get; set; }
        public String Lieu { get; set; }

        public String Quantite { get; set; }

        public int Prix { get; set; }

        public String Date { get; set; }
        public Uri ImageService { get; set; }

        public Uri ImageService2 { get; set; }

        public Uri ImageService3 { get; set; }
        public Uri OwnerImg { get; set; }
        public int idowner { get; set; }

    }

    public class ServiceManager
    {
        public static List<Service> artisanatlist = new List<Service>();
        public static List<Service> subCategoryList = new List<Service>();


        public static async void LoadContentsWithCategory(String category)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                if (category.Equals("Services"))
                {
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getProductList.php?category=" + category);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                    artisanatlist = new List<Service>();
                    for (int i = 0; i < o.Count; i++)
                    {
                        int fk_id = (int)o[i]["id"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                        string datauser = datataskuser.Result;
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        int price = (int)o[i]["price"];

                        int fkowner = (int)o[i]["owner"];
                        Uri img1 = new Uri("" + o[i]["ProductImage1"]);
                        Uri imgOwn = new Uri("" + u[0]["ImagePath"]);

                        artisanatlist.Add(new Service {id=fk_id, Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "",idowner=fkowner, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageService = img1 });
                    }
                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }

        /******************ajout dans une liste selon le sous categorie*********************/
        public static async void LoadContentsWithSubCategory(String subcategory, String category)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {

                string responseBodyAsText;
                string Website = "http://localhost/list.php";
                Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getSubCategoryProductList.php?sub_category=" + subcategory + "& category=" + category);
                string data = datatask.Result;
                o = JArray.Parse(data);
                subCategoryList = new List<Service>();
                for (int i = 0; i < o.Count; i++)
                {
                    int fk_id = (int)o[i]["id"];
                    Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/pimtls/getUserFromProduct.php?id=" + fk_id);
                    string datauser = datataskuser.Result;
                    u = JArray.Parse(datauser);
                    Debug.WriteLine("****" + u[0]["prenom"]);
                    int price = (int)o[i]["price"];
                    int fkowner = (int)o[i]["owner"];

                    Uri img1 = new Uri("" + o[i]["ProductImage1"]);
                    Uri imgOwn = new Uri("" + u[0]["ImagePath"]);

                    subCategoryList.Add(new Service {id=fk_id, Owner = u[0]["prenom"] + " " + u[0]["nom"], OwnerTel = u[0]["tel"] + "",idowner=fkowner, Name = o[i]["name"] + "", OwnerImg = imgOwn, Lieu = u[0]["adresse"] + "", Quantite = o[i]["quantity"] + "", Prix = price, Date = o[i]["date"] + "", ImageService = img1 });
                }

            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }

        public static List<Service> GetArtisanat()
        {
            LoadContentsWithCategory("Services");
            return artisanatlist;
        }
        public static List<Service> GetMenage()
        {
            var FruitList = new List<Artisanat>();
            LoadContentsWithSubCategory("Menage", "Services");
            /* FruitList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Pastéques", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Pasteque.jpg" });
             FruitList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Cerises", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Cerise.jpg" });
             FruitList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Péches", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Peche.jpg" });
             FruitList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Pommes", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Pomme.jpg" });
 */

            return subCategoryList;
        }
        public static List<Service> GetReparation()
        {
            var FruitList = new List<Artisanat>();
            LoadContentsWithSubCategory("Reparation", "Service");
            /* FruitList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Pastéques", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Pasteque.jpg" });
             FruitList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Cerises", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Cerise.jpg" });
             FruitList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Péches", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Peche.jpg" });
             FruitList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Pommes", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Pomme.jpg" });
 */

            return subCategoryList;
        }
        public static List<Service> GetBabySitting()
        {
            var FruitList = new List<Artisanat>();
            LoadContentsWithSubCategory("BabySitting", "Services");
            /* FruitList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Pastéques", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Pasteque.jpg" });
             FruitList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Cerises", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Cerise.jpg" });
             FruitList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Péches", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Peche.jpg" });
             FruitList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Pommes", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Pomme.jpg" });
 */

            return subCategoryList;
        }
        public static List<Service> GetEducation()
        {
            var FruitList = new List<Artisanat>();
            LoadContentsWithSubCategory("Education", "Services");
            /* FruitList.Add(new Nourriture { Owner = "Mazouni Anas", OwnerTel = "98.227.237", Name = "Pastéques", OwnerImg = "Assets/Anas.png", Lieu = "SidiBouzid,Tok", Quantite = "200", Prix = 1, Date = "02/02/2016", ImageNourriture = "Assets/Pasteque.jpg" });
             FruitList.Add(new Nourriture { Owner = "Sta Mohamed", OwnerTel = "21.225.987", Name = "Cerises", OwnerImg = "Assets/Sta.png", Lieu = "Nabeul,Kélibia", Quantite = "120", Prix = 2, Date = "19/11/2016", ImageNourriture = "Assets/Cerise.jpg" });
             FruitList.Add(new Nourriture { Owner = "Bouzwer Amar", OwnerTel = "98.922.123", Name = "Péches", OwnerImg = "Assets/Amar.png", Lieu = "Beja,Matteur", Quantite = "80", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Peche.jpg" });
             FruitList.Add(new Nourriture { Owner = "Benkhelifa Myriam", OwnerTel = "98.922.123", Name = "Pommes", OwnerImg = "Assets/UserHraderImg.png", Lieu = "Kef,Tajerouine", Quantite = "200", Prix = 5, Date = "15/12/2016", ImageNourriture = "Assets/Pomme.jpg" });
 */

            return subCategoryList;
        }




    }
}
