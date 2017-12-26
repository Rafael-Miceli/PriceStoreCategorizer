using System;
using System.Diagnostics;
using PriceStoreCategorizer.ApplicationServices.Interfaces;
using Serilog;

namespace PriceStoreCategorizer.ApplicationServices
{
    public class ProductBinderAppService : IProductBinderAppService
    {
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

            return "Sem Categoria";
        }
    }
}
