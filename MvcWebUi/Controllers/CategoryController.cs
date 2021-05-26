using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUi.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var model = new CategoryListModelView
            {
                Categories = _categoryService.GetAll(),
            };
            return View(model);
        }
    }
}
