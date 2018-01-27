using System;

namespace PriceStoreCategorizer.Domain
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
            CategoryName = "Sem Categoria";
        }

        public string Name { get; private set; }
        public string CategoryName { get; private set; }

        public void CategorizeProduct(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
