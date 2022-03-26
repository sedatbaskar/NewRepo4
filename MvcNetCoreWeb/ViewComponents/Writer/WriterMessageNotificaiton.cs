using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcNetCoreWeb.ViewComponents.Writer
{
    public class WriterMessageNotificaiton : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
