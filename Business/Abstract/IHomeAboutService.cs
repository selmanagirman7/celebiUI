using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHomeAboutService
    {
        HomeAbout Get(int id);

        void Add(HomeAbout homeAbout);
        void Update(HomeAbout homeAbout);
        void Delete(HomeAbout homeAbout);
        List<HomeAbout> GetAll();
    }
}
