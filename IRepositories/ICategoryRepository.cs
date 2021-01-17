using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Entities;

namespace Notes_App.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetCategoryAllDetails(int id);
        List<Category> GetCategoriesAllDetails();
    }
}
