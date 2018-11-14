using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _5Semester.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Send mail");
            return View();
        }
    }
}