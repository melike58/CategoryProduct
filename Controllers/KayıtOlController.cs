using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CategoryProduct.Controllers
{
    public class KayıtOlController : Controller
    {
        // GET: /<controller>/
        
        Context context = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Login log)
        {
            if (ModelState.IsValid)
            {
                context.Logins.Add(log);
                context.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View();
            }
        }
    }
}
