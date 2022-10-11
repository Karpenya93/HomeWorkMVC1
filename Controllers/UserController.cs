using HomeWorkMVC1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HomeWorkMVC1.Controllers
{
    public class UserController : Controller
    {


        [HttpGet]
        public IActionResult InfoModel()
        {
            return View();
        }

        [HttpPost]
        public string ProceedRezult(string name, int age, string sex, string button)
        {
            UserInfo userInfo = new UserInfo()
            {
                Name = name,
                Age = age,
                Sex = sex
            };


            using (StreamWriter writer = new StreamWriter(@"D:\user.json", true))
            {
                string s = JsonConvert.SerializeObject(userInfo);
                writer.WriteLine(s);

            }


                return ("Thanks bro");

        }



        public IActionResult UserBase(string button)
        {
            List<UserInfo> users = new();
            string[] lines = System.IO.File.ReadAllLines(@"D:\user.json");
            foreach (string s in lines)
            {
                users.Add(JsonConvert.DeserializeObject<UserInfo>(s));
            }
            return View(users);
        }

    }
}

       
