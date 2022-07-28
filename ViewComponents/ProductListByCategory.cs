using System;
using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CategoryProduct.ViewComponents
{
    public class ProductListByCategory : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke(int id)
        {
            var productList = context.Products.ToList().Where(x => x.CategoryId == id);
            return View(productList);
        }
    }
}
