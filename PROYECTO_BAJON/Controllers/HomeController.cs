using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROYECTO_BAJON.Controllers
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
        public ActionResult Login()
        {

            return View("/Views/Home/login.cshtml");
        }
        public ActionResult Agregar_pedido()
        {

            return View("/Views/Home/agregar_pedido.cshtml");
        }
        public ActionResult Cliente_antiguo()
        {

            return View("/Views/Home/cliente_antiguo.cshtml");
        }
        public ActionResult Cliente_nuevo()
        {

            return View("/Views/Home/cliente_nuevo.cshtml");
        }
        public ActionResult Estado_pedido()
        {

            return View("/Views/Home/estado_pedido.cshtml");
        }
        public ActionResult Resumen_pedido()
        {

            return View("/Views/Home/resumen_pedido.cshtml");
        }
    }
}