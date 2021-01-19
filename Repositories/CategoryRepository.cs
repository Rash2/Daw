using Notes_App.Entities;
using Notes_App.IRepositories;
using Notes_App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Notes_App.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(Context context) : base(context)
        {

        }

        public Category GetCategoryAllDetails(int id)
        {
            return _table.Where(arg => arg.CategoryId == id)
                .FirstOrDefault();
        }

        public List<Category> GetCategoriesAllDetails()
        {
            return _table
                .ToList();
        }
    }
}