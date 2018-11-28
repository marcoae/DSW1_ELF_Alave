using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSW1_ELF_Alave.ReferenciaNegocios;

namespace DSW1_ELF_Alave.Controllers
{
    public class NegociosController : Controller
    {
        Service1Client proxy = new Service1Client();
        // GET: Negocios
        public ActionResult Clientes()
        {
            return View(proxy.Clientes());
        }
        public ActionResult Pedidoscabexyear(int y = 0)
        {
            ViewBag.y = y;
            return View(proxy.Pedidoscabexyear(y));
        }
        public ActionResult Pedidoscabexcliente(string cliente ="")
        {
            ViewBag.cliente = cliente;
            return View(proxy.Pedidoscabexcliente(cliente));
        }
    }
}