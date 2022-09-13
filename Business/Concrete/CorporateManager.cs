using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CorporateManager : ICorporatesService
    {
        ICorporateDal _corporateDal;

        public CorporateManager(ICorporateDal corporateDal)
        {
            _corporateDal = corporateDal;
        }

        public void Add(Corporate corporate)
        {
            _corporateDal.Add(corporate);
        }

        public void Delete(Corporate corporate)
        {
            _corporateDal.Delete(corporate);
        }

        public Corporate Get(int id)
        {
            return _corporateDal.GetById(id);
        }

        public List<Corporate> GetAll()
        {
            return _corporateDal.GetAll();
        }

        public void Update(Corporate corporate)
        {
            _corporateDal.Update(corporate);
        }
    }
}
