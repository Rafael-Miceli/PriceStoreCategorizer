using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PriceStoreCategorizer.ViewModels;

namespace PriceStoreCategorizer.Controllers
{
    [Route("api/[controller]")]
    public class ProductCategoriesBinderController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]ProductBinderVm productBinderVM)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    [Route("api/[controller]")]
    public class ProductCategoriesAutoBinderController : Controller
    {
        
        [HttpPost]
        public void Post([FromBody]string productName)
        {
            
        }
    }
}
