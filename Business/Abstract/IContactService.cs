using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IContactService
    {
        void Add(Contact contact);
        void Update(Contact contact);   
        void Delete(Contact contact);
        List<Contact> GetAll();
        Contact Get(int id);

    }
}
