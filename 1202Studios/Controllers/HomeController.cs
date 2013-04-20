using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1202Studios.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            var portfilio = new BusinessModel().GetPortfolio();
            return View(portfilio);
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Blog()
        {
            var blog = new BusinessModel().GetBlog();
            return View(blog);
        }

        public ActionResult BlogItem(int Id)
        {
            var blog = new BusinessModel().GetSingleBlog(Id);
            return View(blog);
        }
    }
}
