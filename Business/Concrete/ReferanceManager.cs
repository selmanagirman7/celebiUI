using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ReferanceManager : IReferanceService
    {
        IReferanceDal _referance;

        public ReferanceManager(IReferanceDal referance)
        {
            _referance = referance;
        }

        public void Add(Referance referance)
        {
            _referance.Add(referance);
        }

        public void Delete(Referance referance)
        {
           _referance.Delete(referance);
        }

        public Referance Get(int id)
        {
            return _referance.GetById(id);
        }

        public List<Referance> GetAll()
        {
            return _referance.GetAll(); 
        }

        public void Update(Referance referance)
        {
            _referance.Update(referance);
        }
    }
}
