using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext


    {
        //.net core web config dosyası yerine ConnectionStringi kendimiz yazıyoruz. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SEDATBASKARPC;database=CoreBlogDb;integrated security=true;");

        }
        //EntityLayerda sınıflarımıza karşılık gelicek DbSet türünde proportiler oluşturdum.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }



    }
}
