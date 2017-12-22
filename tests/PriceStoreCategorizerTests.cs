using System;
using Xunit;
using PriceStoreCategorizer.Controllers;
using Microsoft.AspNetCore.Mvc;
using PriceStoreCategorizer.ApplicationServices;

namespace tests
{
    public class PriceStoreCategorizerTests
    {
        [Fact]
        public void Dado_Um_Produto_Sem_Nome_Entao_Retorn_BadRequest()
        {
            var sut = new ProductCategoriesAutoBinderController(new ProductBinderAppService());

            var result = sut.Post(null);

            Assert.Equal(400, (result as BadRequestResult).StatusCode);
        }
    }
}
