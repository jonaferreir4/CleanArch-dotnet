using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
         _productService =  productService;
         
        }

        [HttpGet]
        public  async Task<IActionResult> Index()
        {   
            var result = await  _productService.GetProducts();

            return View(result);
        }

    }
}