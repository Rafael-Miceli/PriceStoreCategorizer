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
        public void Dado_Um_Produto_Sem_Nome_Entao_Retorne_BadRequest()
        {
            var sut = new ProductCategoriesAutoBinderController(new ProductBinderAppService());

            var result = sut.Post(null);

            Assert.Equal(400, (result as BadRequestResult).StatusCode);
        }

        [Fact]
        public void Dado_O_Produto_Tomate_Entao_Retorne_A_Categoria_Legumes()
        {
            var sut = new ProductBinderAppService();

            var result = sut.GetProductCategory("Tomate");

            Assert.Equal("Legumes", result);
        }

        [Fact]
        public void Dado_O_Produto_Alface_Entao_Retorne_A_Categoria_Verduras()
        {
            var sut = new ProductBinderAppService();

            var result = sut.GetProductCategory("Alface");

            Assert.Equal("Verduras", result);
        }

        [Fact]
        public void Dado_O_Produto_SabaoEmPo_Entao_Retorne_A_Categoria_MaterialDeLimpeza()
        {
            var sut = new ProductBinderAppService();

            var result = sut.GetProductCategory("Sabão em Pó");

            Assert.Equal("Materiais de Limpeza", result);
        }
    }
}
