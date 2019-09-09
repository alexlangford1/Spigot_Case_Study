using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WebRequest webRequest = WebRequest.Create("https://imp.onesearch.org/impression.do?event=CaseStudy&source=AlexCaseStudy&traffic_source=AlexCaseStudy");
            webRequest.Method = "Head";
            return View();
        }
    }
}