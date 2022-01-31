using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcNetCoreWeb.Models;

namespace MvcNetCoreWeb.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "sedat"

                },

                new UserComment
                {
                    ID = 2,
                    Username = "Başkar"

                },
                 new UserComment
                 {
                     ID = 3,
                     Username = "Mardin"

                 }
                 };
            return View(commentValues);
        }

    }
}
