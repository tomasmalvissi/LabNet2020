using Lab.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CharactersController : Controller
    {
        // GET: Characters
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var characters = new List<Character>();
            string url = "https://www.officeapi.dev/api/characters/";
            string id = "5e93b4a43af44260882e33b"; 
            for (int i = 0; i < 10; i++)
            {
                var json = await httpClient.GetStringAsync(url + "id" + "i");
                var character = JsonConvert.DeserializeObject<Character>(json);
                characters.Add(character);
            }
            return View(characters);
        }

        //public async Task<ActionResult> Index()
        //{
        //    List<Character> chars = new List<Character>();
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://officeapi.dev/api/characters/random");
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        var response = await client.GetAsync("5e93b4f03af44260882e33b1");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var rta = await response.Content.ReadAsStreamAsync(chars);
        //            return View(rta);
        //        }                
        //    }
        //    return View();
        //}

    }
}