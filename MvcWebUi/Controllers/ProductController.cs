using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUi.Controllers
{
    public class ProductController : Controller
    {
        public IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category > 0 ? _productService.GetByCategory(category) : _productService.GetAll()
            };
            return View(model);
        }

    }
}
