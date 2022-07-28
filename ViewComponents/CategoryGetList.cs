using System;
using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CategoryProduct.ViewComponents
{
    public class CategoryGetList : ViewComponent
    {
        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            var values = context.Categories.ToList();
            return View(values);

        }
    }
}
