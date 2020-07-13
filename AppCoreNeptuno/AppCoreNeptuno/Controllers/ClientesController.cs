using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCoreNeptuno.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCoreNeptuno.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDBContext context;
        public ClientesController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(context.Clientes.ToList());
        }
    }
}