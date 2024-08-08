using Dropdownbinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dropdownbinding.Controllers
{
    public class HomeController : Controller
    {
        JquerdataEntities1 db = new JquerdataEntities1 ();
        public ActionResult Index()
        {
            List<loading> namelist  = db.loadings.ToList ();
            ViewBag.nametbl = new  SelectList(namelist, "Id","Name");
            return View();
        }

        
    }
}