using System.Collections.Generic;
using Its.Jenuiue.Api.Database;
using Its.Jenuiue.Api.ModelsViews;
using Its.Jenuiue.Api.Actions.Products;
using Its.Jenuiue.Api.Models.Organization;

namespace Its.Jenuiue.Api.Services.Products
{
    public class ProductsService : IProductsService
    {
        private readonly IDatabase database;
        private string orgId = "";

        public ProductsService(IDatabase db)
        {
            database = db;
        }

        public void SetOrgId(string id)
        {
            orgId = id;
        }

        public List<MProduct> GetProducts(MProduct param, QueryParam queryParam)
        {
            var act = new GetProductsAction(database, orgId);            
            var results = act.Apply<MProduct>(param, queryParam);

            return results;
        }

        public MProduct GetProductById(MProduct param)
        {
            var act = new GetProductByIdAction(database, orgId);            
            var product = act.Apply<MProduct>(param);

            return product;            
        }

        public long GetProductsCount()
        {
            var m = new MProduct();

            var act = new GetProductCountAction(database, orgId);            
            var cnt = act.Apply<MProduct>(m);

            return cnt;
        }

        public MProduct AddProduct(MProduct param)
        {
            return null;
        }

        public MProduct UpdateProduct(MProduct param)
        {
            return null;
        }

        public void DeleteProduct(MProduct param)
        {
        }
    }
}
