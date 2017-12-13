using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prokhorenkoexzamen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        //public ActionResult File()
        //{
        //    ViewBag.Message = "Передача файлов на сервер.";

        //    return View();
        //}


       
        // GET: Home/File
        public ActionResult File()
        {
            return View();
        }

        // POST: Home/File
        [HttpPost]
        public ActionResult File(HttpPostedFileBase fileUpload)
        {
            //public string name = "";
            if (fileUpload == null) return View();
            else
            {
                string path = Server.MapPath("~/Files");
                string name = Path.GetFileName(fileUpload.FileName);
                fileUpload.SaveAs(Path.Combine(path, name));

                return RedirectToAction("File");
            }
        }

    }
}