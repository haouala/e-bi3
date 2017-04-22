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
    public class Raiting
    {
        public int id { get; set; }
        public int id_raiter { get; set; }
        public int id_raited { get; set; }
        public int id_product { get; set; }
        public int nombre { get; set; }

    }

    public class RaitingManager
    {
        public static List<Raiting> raitingList = new List<Raiting>();


        public static async void LoadRaitingUser(int idraiter,int idraited)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {
                
                    string responseBodyAsText;
                    string Website = "http://localhost/list.php";
                    Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getRaitingUser.php?idraiter=" + idraiter+"&idraited="+idraited);
                    string data = datatask.Result;
                    o = JArray.Parse(data);
                raitingList = new List<Raiting>();
                    for (int i = 0; i < o.Count; i++)
                    {
                        int price = (int)o[i]["nombre"];
                        int idproduct = (int)o[i]["id_product"];
                        int idd = (int)o[i]["id"];



                    raitingList.Add(new Raiting {  id = idd, id_raiter =idraiter, id_raited =idraited, id_product = idproduct, nombre = price});
                    
                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }

        public static async void LoadRaitingProduct(int idraiter, int idproduct)
        {
            HttpClient httpClient = new HttpClient();
            String responseLine;
            JArray o;
            JArray u;

            try
            {

                string responseBodyAsText;
                string Website = "http://localhost/list.php";
                Task<string> datatask = httpClient.GetStringAsync("http://localhost/PIMTLS/getRaitingProduct.php?idraiter=" + idraiter + "&idproduct=" + idproduct);
                string data = datatask.Result;
                o = JArray.Parse(data);
                raitingList = new List<Raiting>();
                for (int i = 0; i < o.Count; i++)
                {
                    int price = (int)o[i]["nombre"];

                   // int idraited = (int)o[i]["id_raited"];
                    int idd = (int)o[i]["id"];

                    Debug.WriteLine(idd);

                    raitingList.Add(new Raiting { id = idd, id_raiter = idraiter,  id_product = idproduct, nombre = price });

                }
            }
            catch (HttpRequestException hre)
            {
                // You might want to actually handle the exception
                // instead of silently swallowing it.
            }

        }


        public static Boolean getRaitingUser(int idraiter, int idraited)
        {
            LoadRaitingUser(idraiter, idraited);
            if (raitingList.Count!=0)
                return true;
            else return false;
        }
        public static Boolean getRaitingProduct(int idraiter, int product)
        {
            LoadRaitingProduct(idraiter, product);
            if (raitingList.Count!=0)
            {
                Debug.WriteLine(raitingList.ToString());
                return true;
            }
            else return false;
        }
        public static int getNbRaiteUser(int idraiter, int idraited)
        {
            LoadRaitingUser(idraiter, idraited);
            int i;
            int somme = 0;
            for ( i = 0; i < raitingList.Count; i++) {
                somme = raitingList[i].nombre + somme;
                
            }
            //float resultat = (somme / raitingList.Count);
            return (somme / (raitingList.Count+1));
                //(int) Math.Truncate(resultat);
        }

    }
}
