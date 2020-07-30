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
    public class PolicyController : Controller
    {
        public ActionResult Index()
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.GetAsync("api/Policy").Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var list = JsonConvert.DeserializeObject<List<PolicyM>>(resulstring);
                return View(list);
            }

            return View(new List<ClientM>());
        }

        [HttpGet]
        public ActionResult New()
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44350/");

            var requestTipoPoliza = clientHttp.GetAsync("api/TypePolicy").Result;

            var requestTipoRiesgo = clientHttp.GetAsync("/api/TypeRisk").Result;

            if (requestTipoRiesgo.IsSuccessStatusCode)
            {
                var resulstring = requestTipoRiesgo.Content.ReadAsStringAsync().Result;
                var listRisk = JsonConvert.DeserializeObject<List<TypeRiskM>>(resulstring);
                ViewBag.TypeRisk = listRisk;
            }

            if (requestTipoPoliza.IsSuccessStatusCode)
            {
                var resulstring = requestTipoPoliza.Content.ReadAsStringAsync().Result;
                var listPolicy = JsonConvert.DeserializeObject<List<TypePolicyM>>(resulstring);
                ViewBag.TypePolicy = listPolicy;
            }


            return View();
        }

        [HttpPost]
        public ActionResult New(PolicyM policy)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.PostAsync("api/Policy", policy, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<bool>(resulstring);
                if (result)
                {
                    return RedirectToAction("Index");
                }
                return View(policy);

            }

            return View(policy);
        }


        [HttpGet]
        public ActionResult Update(int id , string idTypePolicySelec, string idTypeRiskSelec)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.GetAsync("api/Policy?id=" + id).Result;

            var requestTypeRisk = clientHttp.GetAsync("/api/TypeRisk").Result;

            if (requestTypeRisk.IsSuccessStatusCode)
            {
                var resulstring = requestTypeRisk.Content.ReadAsStringAsync().Result;
                var listRisk = JsonConvert.DeserializeObject<List<TypeRiskM>>(resulstring);
                SelectList ListTypeRisk = new SelectList(listRisk, "IdRisk", "Name", Convert.ToInt32(idTypeRiskSelec));
                ViewBag.TipoRiesgo = ListTypeRisk;
            }

            var requestTipoPoliza = clientHttp.GetAsync("api/TypePolicy").Result;


            if (requestTipoPoliza.IsSuccessStatusCode)
            {
                var resulstring = requestTipoPoliza.Content.ReadAsStringAsync().Result;
                var listPolicy = JsonConvert.DeserializeObject<List<TypePolicyM>>(resulstring);
                SelectList ListCategories = new SelectList(listPolicy, "IdType", "Name", Convert.ToInt32(idTypePolicySelec));
                ViewBag.TypePolicy = ListCategories;
                //ViewBag.IdTipoPolizS = idTipoPolizSelec;
            }

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<ClientM>(resulstring);
                return View(result);
            }


            return View();
        }

        [HttpPost]
        public ActionResult Update(PolicyM policy)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");
            var request = clientHttp.PutAsync("api/Policy", policy, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var resulstring = request.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<bool>(resulstring);


                if (result)
                {
                    return RedirectToAction("Index");
                }
                return View(policy);
            }
            return View(policy);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44324/");

            var request = clientHttp.DeleteAsync("api/Policy?id=" + id).Result;

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

            var request = clientHttp.GetAsync("api/Policy?id=" + id).Result;

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