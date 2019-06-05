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
        ClientMethodsImplementation clientMethods = new ClientMethodsImplementation();
        private readonly IHostingEnvironment hostingEnviroment;

        public HomeController(IHostingEnvironment hostingEnviroment)
        {
            this.hostingEnviroment = hostingEnviroment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientIndex()
        {
            var model = clientMethods.GetClients();
            return View(model);
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
    }
}
