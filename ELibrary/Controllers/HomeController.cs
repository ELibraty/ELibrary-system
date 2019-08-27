using ELibrary.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELibrary.Controllers
{
    public class HomeController:Controller
    {
        private readonly IIndexService service;

        public HomeController(IIndexService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string UserName, string Password, string Email)
        {
            string Type = "user", Avatar = "";
            this.service.SingUp(UserName,  Password,  Email,  Type,  Avatar);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
