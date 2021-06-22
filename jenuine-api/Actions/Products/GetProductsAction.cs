using MongoDB.Driver;
using Its.Jenuiue.Api.Database;
using Its.Jenuiue.Api.Models.Organization;

namespace Its.Jenuiue.Api.Actions.Products
{
    public class GetProductsAction : BaseActionQuery
    {
        public GetProductsAction(IDatabase conn, string orgId)
        {
            Init(conn, orgId);
        }
        
        protected override string GetCollectionName()
        {
            return "products";
        }
        
        protected override FilterDefinition<T> GetFilter<T>(T model)
        {
            var filter = FilterDefinition<T>.Empty;
            return filter;
        }
    }
}
