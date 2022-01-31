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
    public class CommentManager : ICommentService
    {
        ICommentDal _commnetDal;

        public CommentManager(ICommentDal commnetDal)
        {
            _commnetDal = commnetDal;
        }

        public void CommentAdd(Comment comment)
        {

            
            _commnetDal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _commnetDal.GetListAll(x => x.BlogID == id);
        }
    }
}
