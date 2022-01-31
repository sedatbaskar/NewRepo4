using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcNetCoreWeb.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {
        BlogManager bm=new BlogManager (new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Blog();
            return View(values);

        }
    }
}
