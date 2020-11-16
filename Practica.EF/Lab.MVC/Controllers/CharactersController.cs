using Lab.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        //public async Task<ActionResult> Index()
        //{
        //    var JSON = new WebClient().DownloadString("https://officeapi.dev/api/characters/5e93b4f03af44260882e33b1");
        //    var chars = JsonConvert.DeserializeObject<Character>(JSON);

        //    return View(chars);
        //}
        public async Task<ActionResult> Index()
        {
            List<Character> chars = new List<Character>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://officeapi.dev/api/characters/random");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync("5e93b4f03af44260882e33b1");

                if (response.IsSuccessStatusCode)
                {
                    var rta = await response.Content.ReadAsStreamAsync(chars);
                    return View(rta);
                }                
            }
            return View();
        }

    }
}