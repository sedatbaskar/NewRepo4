using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5
using Microsoft.AspNetCore.Mvc;

namespace MvcNetCoreWeb.Controllers
{
<<<<<<< HEAD
    [AllowAnonymous]
=======
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
<<<<<<< HEAD
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id; //Tıkladığımız İd'ye göre yorum getirmek için İd değerini Viewbag ile taşıdık.(32) 
                             
            var values = bm.GetBlogByID(id);
            return View(values);
        }

       
=======
            var values = bm.GetList();
            return View(values);
        }
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5
    }
}
