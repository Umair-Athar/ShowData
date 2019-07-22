using ShowData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? id)
        {
            Mn_Info_Repository mnInfo = new Mn_Info_Repository();
            ModelState.Clear();

            ViewBag.info = mnInfo.Get_MnInfo(id);
            return View();
        }
        //public ActionResult SearchAction()
        //{
        //    Mn_Info_Repository mnInfo = new Mn_Info_Repository();
        //    ModelState.Clear();

        //    ViewBag.info = mnInfo.Get_MnInfo(id);
        //    return View();
        //}

    }
}