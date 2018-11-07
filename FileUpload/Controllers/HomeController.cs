using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Upload()
        {
            HttpPostedFileBase file = HttpContext.Request.Files[0];// Request.Files;
            return Json(new {a="aaa",b="666" });
        }

        public ActionResult Download()
        {
            return File(new FileStream(Server.MapPath("/Upload/1.gif"), FileMode.Open), "image/gif", Server.UrlEncode("qqq.gif"));
            //return View();
        }
    }
}