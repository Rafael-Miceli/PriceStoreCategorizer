using System;
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
            
        }

        public void AutoBind(string productName)
        {
            Log.Information(productName);
            //Encontrar categoria do Produto
            
            //Setar categoria na base
            //Retornar para Front
        }

        public string GetProductCategory(string productName)
        {
            if(productName.ToLower() == "Tomate".ToLower())
                return "Legumes";

            if(productName.ToLower() == "Alface".ToLower())
                return "Verduras";

            if(productName.ToLower() == "Sabão em Pó".ToLower())
                return "Materiais de Limpeza";

            return "Sem Categoria";
        }
    }
}
