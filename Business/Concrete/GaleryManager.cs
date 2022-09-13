using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GaleryManager : IGaleryService
    {
        IGaleryDal _galeryDal;

        public GaleryManager(IGaleryDal galeryDal)
        {
            _galeryDal = galeryDal;
        }

        public void Add(Galery galery)
        {
            _galeryDal.Add(galery);
        }

        public void Delete(Galery galery)
        {
           _galeryDal.Delete(galery);
        }

        public Galery Get(int id)
        {
            return _galeryDal.GetById(id);
        }

        public List<Galery> GetAll()
        {
            return _galeryDal.GetAll();
        }

        public void Update(Galery galery)
        {
            _galeryDal.Update(galery);
        }
    }
}
