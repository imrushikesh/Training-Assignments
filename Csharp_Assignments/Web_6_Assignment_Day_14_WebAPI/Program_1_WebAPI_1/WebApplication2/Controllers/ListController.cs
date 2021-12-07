using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Formatting;


namespace WebApplication2.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44393/api/Demo");
                var result = Client.GetAsync("Demo");
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof(List<string>));
                    data.Wait();
                    List<string> s = data.Result as List<string>;
                    List<SelectListItem> itemList = new List<SelectListItem>();
                    foreach(string st in s)
                    {
                        itemList.Add(new SelectListItem() { Text = st, Value = st });
                    }
                    ViewData["response"] = itemList;
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