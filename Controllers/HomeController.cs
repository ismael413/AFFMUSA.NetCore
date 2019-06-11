using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AFFMUSA.Models;
using Microsoft.AspNetCore.Mvc;
using PruebasNetCore.Data;
using PruebasNetCore.Models;

namespace PruebasNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClientMethods clientMethods;
        private readonly ApplicationDbContext context;

        public HomeController(ClientMethods clientMethods, ApplicationDbContext context)
        {
            this.clientMethods = clientMethods;
            this.context = context;
        }
        public IActionResult Index()
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

        // GET: Home

        [Route("Home/ClientDetails", Name = "clientselecteddetails")]
        public IActionResult ClientDetails(int Id)
        {
            var model = clientMethods.GetClient(Id);
            return View(model);
        }

        // GET: Home/ClientIndex
        public IActionResult ClientIndex()
        {
            return View();
        }

        // POST: Home/ClientIndex/5
        [HttpPost]
        public IActionResult ClientIndex(Client client)
        {
            if (ModelState.IsValid)
            {
                clientMethods.AddClient(client);
                return RedirectToAction("clientdetails", new { id = client.ClientID });
            }
            else
            {
                return View(client);
            }

        }

        [HttpGet]
        [Route("Home/ClientList")]
        public IActionResult ClientList()
        {
            var model = clientMethods.GetClientsList();
            return View(model);
        }
    }
}
