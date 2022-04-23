using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
       public Category TGetById(int id)
        {
            return _categoryDal.GetByID(id);
        }
        public List<Category> TGetList()
        {
            return _categoryDal.GetListAll();
        }
        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }
        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }
        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
