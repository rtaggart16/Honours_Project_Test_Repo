using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Honours_Project_Test.Controllers
{
    /// <summary>
    /// The default controller of the application
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Main method of the application that displays the home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}