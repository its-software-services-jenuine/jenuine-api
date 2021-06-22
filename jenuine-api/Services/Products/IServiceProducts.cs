using System.Collections.Generic;
using Its.Jenuiue.Api.ModelsViews.Organization;

namespace Its.Jenuiue.Api.Services.Products
{
    public interface IServiceProducts
    {
        public List<MVProduct> GetProducts(MVProduct param);
        public int GetProductsCount();
        public MVProduct AddProduct(MVProduct param);
        public MVProduct UpdateProduct(MVProduct param);
        public void DeleteProduct(MVProduct param);
    }
}
