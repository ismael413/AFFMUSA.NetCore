using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFFMUSA.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AFFMUSA.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ClientMethods clientMethods;

        public HomeController(ClientMethods methods, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            this.clientMethods = methods;
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