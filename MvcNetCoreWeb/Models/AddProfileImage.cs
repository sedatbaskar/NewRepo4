using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MvcNetCoreWeb.Models
{

    //EntityLayer da ki modeli bozmamak için aynı propertilere sahip farklı bir model oluşturdul sadece WriterImage kısmını değiştirdik.
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

    }
}
