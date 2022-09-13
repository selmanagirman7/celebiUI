using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IReferanceService
    { 
        Referance Get(int id);
        void Add(Referance referance);
        void Delete(Referance referance);   
        void Update (Referance referance);   
        List<Referance> GetAll();
    }
}
