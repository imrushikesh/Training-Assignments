using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {
            using (var Client = new System.Net.Http.HttpClient())
            {
                Client.BaseAddress=new Uri("https://localhost:44393/api/Demo");
                var result = Client.GetAsync("Demo");
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsStringAsync();
                    data.Wait();
                    string s = data.Result.ToString();
                    ViewData["response"] = s;
                }
                else
                {
                    ViewData["response"] = "error";
                }
            }

            return View();
        }
    }
}