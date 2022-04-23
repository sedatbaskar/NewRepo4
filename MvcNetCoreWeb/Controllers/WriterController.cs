using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcNetCoreWeb.Models;

namespace MvcNetCoreWeb.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();

        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();

        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var wiretervalues = wm.TGetById(2);
            return View(wiretervalues);

        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult result = wl.Validate(p);
                if (result.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
     
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            
            return View();

        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage!=null) //Paramatreden gelen Image değeri null değilse
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFolder/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }

            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");

        }
    }
}
