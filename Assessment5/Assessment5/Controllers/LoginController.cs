using Assessment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5.Controllers
{
    public class LoginController : Controller
    {
        public void Login(WelcomeViewModel origin)
        {
            var destination = new WelcomeViewModel();

            if (destination.password == "open sesame")
            { 
                Welcome(destination);
            }
            else WrongPassword();

        }   

        public IActionResult Welcome(WelcomeViewModel origin)
        {
            var destination = new WelcomeViewModel();

            destination.name = origin.name;

            destination.name = origin.name.ToUpper();

            destination.length = origin.name.Length;

            return View(destination);
        }

        public IActionResult WrongPassword()
        {
            return View();
        }
    }
}
