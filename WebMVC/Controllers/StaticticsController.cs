using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class StaticticsController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var categoryCount = context.Categories.Count().ToString();
            ViewBag.CategoryCount = categoryCount;

            var heading = context.Headings.Count(h => h.CategoryId == 10).ToString();
            ViewBag.Heading = heading;

            var writer = context.Writers.Where(w=>w.WriterName.Contains("a") || w.WriterName.Contains("A")).Count();
            ViewBag.Writer = writer;

            var headingMax = context.Headings.Where(u => u.CategoryId == context.Headings.GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count())
               .Select(x => x.Key).FirstOrDefault()).Select(x => x.Category.CategoryName).FirstOrDefault(); 
            ViewBag.HeadingMax = headingMax;

            var trueStatus = context.Categories.Where(c => c.CatogoryStatus == true).Count();
            var falseStatus = context.Categories.Where(c => c.CatogoryStatus == false).Count();

            ViewBag.Status = (trueStatus-falseStatus);

            return View();

        }
    }
}