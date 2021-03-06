using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using PriceStoreCategorizer.ApplicationServices.Interfaces;
using Serilog;

namespace PriceStoreCategorizer.ApplicationServices
{
    public class ProductBinderAppService : IProductBinderAppService
    {
        private Dictionary<string, string> tagsBindedToProductsNames;

        public ProductBinderAppService()
        {
            tagsBindedToProductsNames = new Dictionary<string, string>();
        }

        public void AutoBind(string productName)
        {
            Log.Information(productName);
            //Encontrar categoria do Produto
            
            //Setar categoria na base
            //Retornar para Front
        }

        public void BindProductToCategory(string productName, string categoryName)
        {
            tagsBindedToProductsNames.Add(categoryName, productName);
        }

        public string GetProductCategory(string productName)
        {
            if(tagsBindedToProductsNames.ContainsValue(productName))
                return tagsBindedToProductsNames.FirstOrDefault(p => p.Value == productName).Key;

            return "Sem Categoria";
        }
    }
}
