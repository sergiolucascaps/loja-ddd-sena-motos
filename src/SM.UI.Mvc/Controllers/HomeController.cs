using SM.UI.Mvc.Enumeradores;
using SM.UI.Mvc.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SM.UI.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //this.AddToastMessage("Este eh o corpo da mensagem 1, eh obrigatoria", "Este eh o Titulo", ToastType.Success, true);
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
    }
}