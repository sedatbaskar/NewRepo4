﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcNetCoreWeb.Controllers
{
<<<<<<< HEAD:MvcNetCoreWeb/Controllers/ErrorPageController.cs
    public class ErrorPageController : Controller
=======
    public class CategoryController : Controller
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5:MvcNetCoreWeb/Controllers/CategoryController.cs
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
