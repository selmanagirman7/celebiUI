using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAboutService
    {
        void Add(About about);
        void Update(About about);
        void Delete(About about);
        List<About> GetAll();
        About Get(int id);
    }
}
