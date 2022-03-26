using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetList();
        Blog GetById(int id);
<<<<<<< HEAD
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogByWriter(int id);
        
=======
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5
    }
}
