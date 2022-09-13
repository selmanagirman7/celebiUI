using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGaleryService
    {
        Galery Get(int id);

        void Add(Galery galery);
        void Update(Galery galery); 
        void Delete(Galery galery); 
        List<Galery> GetAll();
    }
}
