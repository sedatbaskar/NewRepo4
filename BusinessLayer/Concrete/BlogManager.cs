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

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetByID(id);
        }


        public List<Blog> GetBlogByID(int id) //Blogları id'ye göre listeleme
        {
            return _blogDal.GetListAll(x => x.BlogID == id);

        }

        public List<Blog> TGetList() //Bütün blokları listeleme
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetLast3Blog() //Footer kısmı için 3 blog listemele
        {
            return _blogDal.GetListAll().Take(3).ToList();

        }

        public List<Blog> GetBlogByWriter(int id)
        {

            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }


    }
}
