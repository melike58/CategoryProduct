using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CategoryProduct.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            var kategoriler = context.Categories.ToList();
            List<SelectListItem> categoryList = (from x in kategoriler
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryId.ToString()
                                                }).ToList();
            ViewBag.v1 = categoryList;
            return View();
        }
        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            var kategoriler = context.Categories.ToList();

            List<SelectListItem> categoryList = (from x in kategoriler
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.v1 = categoryList;
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index","Product", new { Areas = "Admin"});

            
        }
        public IActionResult ProductDelete(int productId)
        {
            var productDelete = context.Products.Find(productId);
            context.Remove(productDelete);
            context.SaveChanges();
            return RedirectToAction("Index", "Admin", "Product");
        }
        [HttpGet]
        public IActionResult ProductUpdate(int Id)
        {
            var productUpdate = context.Products.Find(Id);
            List<SelectListItem> categoryList = (from y in context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = y.CategoryName,
                                                     Value = y.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.v2 = categoryList;
            return View(productUpdate);
        }
        [HttpPost]
        public IActionResult ProductUpdate(Product prd)
        {
            context.Products.Update(prd);
            context.SaveChanges();
            return RedirectToAction("Index", ",Admin", "Product");
        }
    }
}
