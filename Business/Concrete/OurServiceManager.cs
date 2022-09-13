using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OurServiceManager : IOurServiceService
    {
        IOurServiceDal _serviceDal;

        public OurServiceManager(IOurServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(OurService ourService)
        {
           _serviceDal.Add(ourService);
        }

        public void Delete(OurService ourService)
        {
           _serviceDal.Delete(ourService);
        }

        public OurService Get(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<OurService> GetAll()
        {
           return _serviceDal.GetAll(); 
        }

        public void Update(OurService ourService)
        {
           _serviceDal.Update(ourService);
        }
    }
}
