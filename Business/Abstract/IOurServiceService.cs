using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOurServiceService
    {
        OurService Get(int id);

        void Add(OurService ourService);
        void Update(OurService ourService);
        void Delete(OurService ourService);
        List<OurService> GetAll();
    }
}
