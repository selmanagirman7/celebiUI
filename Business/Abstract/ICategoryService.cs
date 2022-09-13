using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category); 
        void Delete(Category category);
        List<Category> GetAll();
        
        Category Get(int id);

    }
}
