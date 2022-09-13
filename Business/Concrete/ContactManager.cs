using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
           _contactDal.Add(contact);
        }

        public void Delete(Contact contact)
        {
           _contactDal.Delete(contact);
        }

        public Contact Get(int id)
        {
           return _contactDal.GetById(id);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
