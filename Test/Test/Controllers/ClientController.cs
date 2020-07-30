using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Mvc;
using Test.Model.Migration;

namespace Test.Controllers
{
    public class ClientController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.GetAsync("api/Client").Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var list = JsonConvert.DeserializeObject<List<ClientM>>(resulstring);
                return View(list);
            }

            return View(new List<ClientM>());
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(ClientM client)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.PostAsync("api/Client", client, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<bool>(resulstring);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                return View(client);

            }

            return View(client);
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.GetAsync("api/Client?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<ClientM>(resulstring);
                return View(result);
            }


            return View();
        }

        [HttpPost]
        public ActionResult Update(ClientM client)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");
            var request = clientHttp.PutAsync("api/Client", client, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<bool>(resulstring);


                if (result)
                {
                    return RedirectToAction("Index");
                }
                return View(client);
            }
            return View(client);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.DeleteAsync("api/Client?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<bool>(resulstring);
                if (result)
                {
                    return RedirectToAction("Index");
                }

            }

            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.GetAsync("api/Client?id=" + id).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<ClientM>(resulstring);
                return View(result);
            }

            return View();
        }
    }
}