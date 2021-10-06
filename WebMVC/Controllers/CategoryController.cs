using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class CategoryController : Controller
    {
       
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
       
    }
}