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
    public class User
    {
        public int id { get; set; }
        public String username { get; set; }
        public String email { get; set; }
        public String nom { get; set; }
        public String prenom { get; set; }
        public int tel { get; set; }
        public String adresse { get; set; }
        public String password { get; set; }
        public string description { get; set; }
        public Uri image { get; set; }
    }
        
        public class UserManagers
        {
            public static List<User> userList = new List<User>();
            public static User user;
           // public static User user;
            public static async Task<User> getEmail(String emailUser)
            {
                HttpClient httpClient = new HttpClient();
                
                JArray u;
                
                try
                {

                    
                    
                       // int fk_id = (int)o[i]["fk_user"];
                        Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/PIMTLS/getUserByEmail.php?email=" + emailUser);
                        string datauser = datataskuser.Result;
                    if (datauser.Equals(""))
                        user = null;
                  
                    
                    else {   u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                    //   int price = (int)o[i]["price"];
                    int tel = (int)u[0]["tel"];
                    int id = (int)u[0]["id"];
                    Debug.WriteLine(u[0]["email"]);

                    Uri img1 = new Uri("" + u[0]["ImagePath"]);


                    user = new User { id =id, username = u[0]["username"] + "", email = u[0]["email"] + "", nom = u[0]["nom"] + "", description = u[0]["description"] + "", prenom = u[0]["prenom"] + "", tel = tel, adresse = u[0]["adresse"] + "", password = u[0]["password"] + "", image = img1 };
                    Debug.WriteLine(user.nom);
                    }
                }
                catch (HttpRequestException hre)
                {
                    // You might want to actually handle the exception
                    // instead of silently swallowing it.
                }
                
                return user;

            }


            public static async Task<User> LoadContentsWithCategory(String userName)
            {
                HttpClient httpClient = new HttpClient();

                JArray u;

                try
                {



                    // int fk_id = (int)o[i]["fk_user"];
                    Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/PIMTLS/getUserByUserName.php?username=" + userName);
                    string datauser = datataskuser.Result;
                    if (datauser.Equals(""))
                        user = null;


                    else {
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        //   int price = (int)o[i]["price"];
                        int tel = (int)u[0]["tel"];
                        int id = (int)u[0]["id"];
                        Debug.WriteLine(u[0]["email"]);

                    Uri img1 = new Uri("" + u[0]["ImagePath"]);

                    user = new User { id = id, username = u[0]["username"] + "", email = u[0]["email"] + "", description = u[0]["description"] + "", nom = u[0]["nom"] + "", prenom = u[0]["prenom"] + "", tel = tel, adresse = u[0]["adresse"] + "", password = u[0]["password"] + "", image = img1 };
                        Debug.WriteLine(user.nom);
                    }
                }
                catch (HttpRequestException hre)
                {
                    // You might want to actually handle the exception
                    // instead of silently swallowing it.
                }

                return user;

            }
            public static async Task<User> LoadContentsWithid(int idUser)
            {
                HttpClient httpClient = new HttpClient();

                JArray u;

                try
                {



                    // int fk_id = (int)o[i]["fk_user"];
                    Task<string> datataskuser = httpClient.GetStringAsync("http://localhost/PIMTLS/getUserById.php?id=" + idUser);
                    string datauser = datataskuser.Result;
                    if (datauser.Equals(""))
                        user = null;


                    else {
                        u = JArray.Parse(datauser);
                        Debug.WriteLine("****" + u[0]["prenom"]);
                        //   int price = (int)o[i]["price"];
                        int tel = (int)u[0]["tel"];
                        int id = (int)u[0]["id"];
                        Debug.WriteLine(u[0]["email"]);
                    Uri img1 = new Uri("" + u[0]["ImagePath"]);


                    user = new User { id = id, username = u[0]["username"] + "", email = u[0]["email"] + "", nom = u[0]["nom"] + "", prenom = u[0]["prenom"] + "", description = u[0]["description"] + "", tel = tel, adresse = u[0]["adresse"] + "", password = u[0]["password"] + "", image = img1 };
                        Debug.WriteLine(user.nom);
                    }
                }
                catch (HttpRequestException hre)
                {
                    // You might want to actually handle the exception
                    // instead of silently swallowing it.
                }

                return user;

            }
            public static User GetUserBy(String userNamee)
            {
                LoadContentsWithCategory(userNamee);
                return user;
            }
            public static User GetUserById(int id)
            {
                LoadContentsWithid(id);
                return user;
            }


        }
    
}
