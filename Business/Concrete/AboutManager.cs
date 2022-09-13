using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
          _aboutDal.Add(about);
        }

        public void Delete(About about)
        {
            _aboutDal.Delete(about);
        }

        public About Get(int id)
        {
           return _aboutDal.GetById(id);
        }

        public List<About> GetAll()
        {
           return _aboutDal.GetAll();
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
