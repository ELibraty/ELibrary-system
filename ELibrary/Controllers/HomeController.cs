using ELibrary.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ELibrary.ViewModels;

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


        // public IActionResult Index(string UserNameSingIn, string PasswordSingIn, string UserNameSingUp, string PasswordSingUp, string EmailSingUp)
        [HttpPost]
        public IActionResult Index(IndexViewModel.SingInModel singInModel, IndexViewModel.SingUpModel singUp)
        {
            string Avatar = "";
            this.service.SingIn(singInModel.UserNameSingIn, singInModel.PasswordSingIn);
            this.service.SingUp(singUp.UserNameSingUp, singUp.PasswordSingUp, singUp.EmailSingUp,  Avatar);
            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult IndexORG()
        {
            return View();
        }
    }
}
