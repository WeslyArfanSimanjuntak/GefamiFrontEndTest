using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GefamiFrontEndTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FetchPosts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/");
                var response = client.GetAsync("posts").Result;
                var data = response.Content.ReadAsStringAsync().Result;
                return Json(data);
            }
        }

        public ActionResult testdebug()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}