using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowView()
        {
            Thread.Sleep(3000);
            return PartialView("partialView1");

        }

        /// <summary>
        /// 重载
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "|";
        }
    }
}