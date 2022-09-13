using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HomeAboutManager : IHomeAboutService
    {
        IHomeAboutDal _aboutDal;

        public HomeAboutManager(IHomeAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(HomeAbout homeAbout)
        {
            _aboutDal.Add(homeAbout);
        }

        public void Delete(HomeAbout homeAbout)
        {
           _aboutDal.Delete(homeAbout);
        }

        public HomeAbout Get(int id)
        {
           return _aboutDal.GetById(id);
        }

        public List<HomeAbout> GetAll()
        {
            return _aboutDal.GetAll();
        }

        public void Update(HomeAbout homeAbout)
        {
            _aboutDal.Update(homeAbout);
        }
    }
}
