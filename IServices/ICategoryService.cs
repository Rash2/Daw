using Notes_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.IServices
{
    public interface ICategoryService
    {
        Category Create(Category cat);
        Category Get(int id);
        Category Update(Category cat);
        bool Delete(int id);
        List<Category> GetAll();

    }
}
