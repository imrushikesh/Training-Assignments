using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DemoController : ApiController
    {
     /*   public string get()
        {
            return "Web Api Method 1";
        }
*/
        public List<string> Get()
        {

            List<string> list1 = new List<string>();
            list1.Add("Value_1");
            list1.Add("Value_2");
            return list1;
        }
    }
}
