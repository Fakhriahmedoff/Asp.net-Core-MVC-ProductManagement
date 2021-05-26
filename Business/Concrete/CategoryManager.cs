using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryService;

        public CategoryManager(ICategoryDal categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetList();
        }
    }
}
