using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using OpenQA.Selenium;
using CrdtsScoringTestLib;

namespace CrdtsScoringTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //IList<IWebElement> results;
            IWebElement result;
            using (var examiner = new Scoring())
            {
                examiner.loadUrl("https://demo.p1dev.net/crdtsdemo");
                result = examiner.test1();
            }
            return View(result);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
