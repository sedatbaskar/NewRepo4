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
    public class CityManager : ICityService
    {
        ICityDal _CityDal;

        public CityManager(ICityDal cityDal)
        {
            _CityDal = cityDal;
        }

        public void CityAdd(City city)
        {
            _CityDal.Insert(city);
        }
    }
}
