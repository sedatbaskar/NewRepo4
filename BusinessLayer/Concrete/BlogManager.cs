using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogDelete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog blog)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

=======
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5
        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

<<<<<<< HEAD
        public List<Blog> GetBlogByID(int id) //Blogları id'ye göre listeleme
        {
            return _blogDal.GetListAll(x => x.BlogID == id);

        }

        public List<Blog> GetList() //Bütün blokları listeleme
        {
            return _blogDal.GetListAll();
        }

        public List<Blog>GetLast3Blog() //Footer kısmı için 3 blog listemele
        {
            return _blogDal.GetListAll().Take(3).ToList();

        }

        public List<Blog> GetBlogByWriter(int id)
        {

            return _blogDal.GetListAll(x => x.WriterID == id);
        }
=======
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
>>>>>>> e726a4710b88cb61c8f1ae12c82d6fdaa32a8bb5
    }
}
