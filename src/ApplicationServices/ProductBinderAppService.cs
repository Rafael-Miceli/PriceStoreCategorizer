using System;
using System.Diagnostics;
using PriceStoreCategorizer.ApplicationServices.Interfaces;

namespace PriceStoreCategorizer.ApplicationServices
{
    public class ProductBinderAppService : IProductBinderAppService
    {
        public void AutoBind(string productName)
        {
            Debug.WriteLine(productName);
        }
    }
}
