using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSW1_ELF_Alave.ReferenciaNegocios;
using WcfService1;

namespace DSW1_ELF_Alave.Controllers
{
    public class IndexController : Controller
    {

        Service1Client proxy = new Service1Client();
        // GET: Index
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Clientes()
        {
            return View(proxy.Clientes());
        }
    }
}