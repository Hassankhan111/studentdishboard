using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication20.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
            
        }

        public ActionResult StudentEnroledSubject()
        {

            return View();

        }

        public ActionResult StudentGradeBySemester()
        {
            return View();

        }

        public ActionResult UploadAssignment()
        {
            return View();
        }

        public ActionResult ListOfAssignment()
        {
            return View();
        }

        public  ActionResult stParentDetails()
        {
            return View();

        }

        public ActionResult Techerpage()
        {
            return View();
        }

    }
}