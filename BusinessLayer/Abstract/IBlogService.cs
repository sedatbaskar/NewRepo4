using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogByWriter(int id);
        List<Blog> GetLast3Blog();

        List<Blog> GetListWithCategoryByWriterBm(int id);

    }
}
