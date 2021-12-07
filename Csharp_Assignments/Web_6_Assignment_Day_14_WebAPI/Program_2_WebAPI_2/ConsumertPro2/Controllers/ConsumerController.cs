using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Data.Entity;
using ConsumertPro2.Models;

namespace ConsumertPro2.Controllers
{
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {

            List < mvcEmpTable > dlist= null; 
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44307/api/Demo");
                var result = Client.GetAsync("Demo");
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof(List<mvcEmpTable>));
                    data.Wait();
                    dlist = (List<mvcEmpTable>)data.Result;
               //     DbSet<mvcEmpTable> itemList = new List<SelectListItem>();
                
                 //   ViewData["response"] = itemList;
                }
             /*   else
                {
                    ViewData["response"] = "error";
                }*/
            }

            return View(dlist) ;
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
                 
        }


        [HttpPost]
        public ActionResult Create(mvcEmpTable e)
        {
            List<mvcEmpTable> dlist =null;
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44307/api/Demo");
                var result = Client.PostAsJsonAsync("https://localhost:44307/api/Demo/Create", e);
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof(List<mvcEmpTable>));
                    data.Wait();
                    dlist = (List<mvcEmpTable>)data.Result;
     
                }
            }

       

            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult Edit()
        {
            return View();

        }

        [HttpPut]
        public ActionResult Edit(int id, mvcEmpTable e)
        {
            List<mvcEmpTable> dlist = null;
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44307/api/Demo/id");
                //  var result = Client.PostAsJsonAsync("https://localhost:44307/api/Demo/",e);
                var result = Client.GetAsync("Demo?id=" + id.ToString());
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof(List<mvcEmpTable>));
                    data.Wait();
                    dlist = (List<mvcEmpTable>)data.Result;

                }
            }


            return RedirectToAction("Index");


        }



        [HttpGet]
        public ActionResult Delete()
        {

            mvcEmpTable m = new mvcEmpTable();
            
            return View(m);

        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            List<mvcEmpTable> dlist = null;
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44307/api/Demo");
                var result = Client.PostAsJsonAsync("https://localhost:44307/api/Demo/DeleteData?id",id);
              
                result.Wait();
                var res = result.Result;
                if (res.IsSuccessStatusCode)
                {
                    var data = res.Content.ReadAsAsync(typeof(List<mvcEmpTable>));
                    data.Wait();
                    dlist = (List<mvcEmpTable>)data.Result;

                }
            }


            return RedirectToAction("Index");



        }


    }
}