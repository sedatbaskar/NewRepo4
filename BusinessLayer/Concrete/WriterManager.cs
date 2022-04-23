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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetWriterByID(int id) //Dashboard portalı için kullandık
        {
            return _writerDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetByID(id);
        }

        public List<Writer> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }


    }
}
