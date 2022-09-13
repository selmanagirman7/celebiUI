using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICorporatesService
    {
        void Add(Corporate corporate);
        void Update(Corporate corporate);   
        void Delete(Corporate corporate);
        List<Corporate> GetAll();
        Corporate Get(int id);

    }
}
