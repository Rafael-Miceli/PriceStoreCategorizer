using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceStoreCategorizer.ViewModels;
using PriceStoreCategorizer.ApplicationServices.Interfaces;

namespace PriceStoreCategorizer.Controllers
{
    [Route("api/[controller]")]
    public class ProductCategoriesAutoBinderController : Controller
    {
        private IProductBinderAppService _productBinderAppService;

        public ProductCategoriesAutoBinderController(IProductBinderAppService productBinderAppService)
        {
            _productBinderAppService = productBinderAppService;
        }
        
        [HttpPost]
        public void Post([FromBody]string productName)
        {
            _productBinderAppService.AutoBind(productName);
        }
    }
}
