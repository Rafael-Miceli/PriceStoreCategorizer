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
        }
    }
}
