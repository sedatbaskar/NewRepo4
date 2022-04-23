using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcNetCoreWeb.ViewComponents.Blog
{
    public class BlogImageDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());


        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterByID(2);
            return View(values);


        }
    }
}
