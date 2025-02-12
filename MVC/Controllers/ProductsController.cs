using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MVC.Controllers
{
    public class ProductsController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productAppService) {
            _productService = productAppService;
        }

    }
}