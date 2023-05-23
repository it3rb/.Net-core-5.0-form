using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Form.Models;


namespace Form.Controllers
{
    public class DataAddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(PAdd body)
        {
            return View();
        }
        
    }
}
