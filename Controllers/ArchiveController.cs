using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace rahulkhadseblog.Controllers
{
    public class ArchiveController : Controller
    {
        public IActionResult Index(string title = "")
        {
            if(string.IsNullOrEmpty(title))
                return RedirectToAction("List"); ;
            
            return View("Index", title);
        }

        public IActionResult List()
        {
            return View("List");
        }
    }
}
