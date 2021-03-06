namespace PriceStoreCategorizer.ApplicationServices.Interfaces
{
    public interface IProductBinderAppService
    {
        void AutoBind(string productName);
        string GetProductCategory(string productName);
        void BindProductToCategory(string productName, string categoryName);
    }
}
