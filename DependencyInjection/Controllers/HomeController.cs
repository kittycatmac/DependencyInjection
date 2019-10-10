using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
 
namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new Repository().Products);
        }
    }
}