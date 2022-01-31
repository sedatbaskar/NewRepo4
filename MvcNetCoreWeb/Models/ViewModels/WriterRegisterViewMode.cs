using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace MvcNetCoreWeb.Models.ViewModels
{
    public class WriterRegisterViewMode
    {
        public City City { get; set; }
        public Writer Writer { get; set; }
    }
}
