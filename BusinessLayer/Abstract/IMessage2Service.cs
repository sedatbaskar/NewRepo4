using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Service:IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);//Yazara göre veri getirme

    }
}
