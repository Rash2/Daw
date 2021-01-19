using Notes_App.Entities;
using Notes_App.IRepositories;
using Notes_App.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_App.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Create(Category cat)
        {
            _categoryRepository.Create(cat);
            _categoryRepository.SaveChanges();

            return _categoryRepository.GetCategoryAllDetails(cat.CategoryId);
        }
        public Category Get(int id)
        {
            return _categoryRepository.GetCategoryAllDetails(id);
        }

        public bool Delete(int id)
        {
            var entity = _categoryRepository.FindById(id);
            if (entity != null)
            {
                _categoryRepository.Delete(entity);
                _categoryRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetCategoriesAllDetails();
        }
        
        public Category Update(Category cat)
        {
            if (_categoryRepository.FindById(cat.CategoryId) == null) return null;
            _categoryRepository.Update(cat);
            _categoryRepository.SaveChanges();
            return _categoryRepository.GetCategoryAllDetails(cat.CategoryId);
        }
    }
}
