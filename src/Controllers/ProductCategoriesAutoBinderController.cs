using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceStoreCategorizer.ViewModels;

namespace PriceStoreCategorizer.Controllers
{
    [Route("api/[controller]")]
    public class ProductCategoriesAutoBinderController : Controller
    {
        
        [HttpPost]
        public void Post([FromBody]string productName)
        {
            //_productBinderAppService.AutoBind(productName);
        }
    }
}
