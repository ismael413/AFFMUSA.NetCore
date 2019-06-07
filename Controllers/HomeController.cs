using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using AFFMUSA.Models;
using System.Diagnostics;

namespace AFFMUSA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClientMethods clientMethods;
        private readonly IHostingEnvironment hostingEnviroment;

        public HomeController(IHostingEnvironment hostingEnviroment,
            ClientMethods clientMethods)
        {
            this.hostingEnviroment = hostingEnviroment;
            this.clientMethods = clientMethods;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ClientIndex(Client cliente)
        {
            if (ModelState.IsValid)
            {
                //Llama al metodo agregar para agregar el cliente especificado.
                Client client = clientMethods.Add(cliente);
                //devolver cliente agregado a la pagina especificada.
                return RedirectToAction("clientdetails", new { id = client.Id });
            }
            else
            {
                var model = clientMethods.GetClients();
                return View(model);
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
        }

        [HttpGet]
        public IActionResult ClientIndex()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public ViewResult ClientList()
        {
            var model = clientMethods.GetClients();
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [Route("Home/ClientDetails", Name= "clientselecteddetails")]
        public ViewResult ClientDetails(int Id)
        {
            var model = clientMethods.GetClient(Id);
            return View(model);
        }
    }
}
