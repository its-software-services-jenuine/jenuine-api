using System.Collections.Generic;
using Its.Jenuiue.Api.Models.Organization;
using Its.Jenuiue.Api.ModelsViews;

namespace Its.Jenuiue.Api.Services.Products
{
    public interface IProductsService
    {
        public void SetOrgId(string id);
        public List<MProduct> GetProducts(MProduct param, QueryParam queryParam);
        public MProduct GetProductById(MProduct param);
        public long GetProductsCount();
        public MProduct AddProduct(MProduct param);
        public MProduct UpdateProduct(MProduct param);
        public MProduct DeleteProduct(MProduct param);
    }
}
