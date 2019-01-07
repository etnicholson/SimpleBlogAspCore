using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlog.Data;
using SimpleBlog.Entities;
using SimpleBlog.Models;

namespace SimpleBlog.Controllers
{
    public class HomeController : Controller


    {

        private DataRetriver data;

        public HomeController(ApplicationDbContext context)
        {
          data = new DataRetriver(context);
            
        }
        public IActionResult Index()
        {

            var t = data.Retrive();
            return View(t);

        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
