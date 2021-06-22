using MongoDB.Driver;
using Its.Jenuiue.Api.Database;
using Its.Jenuiue.Api.Models.Organization;

namespace Its.Jenuiue.Api.Actions.Products
{
    public class GetProductByIdAction : BaseActionQuerySingle
    {
        public GetProductByIdAction(IDatabase conn, string orgId)
        {
            Init(conn, orgId);
        }
        protected override string GetCollectionName()
        {
            return "products";
        }
        
        protected override FilterDefinition<T> GetFilter<T>(T model)
        {
            var md = model as MProduct;
            var filter = Builders<T>.Filter.Eq("Id", md.Id);
            return filter;
        }
    }
}
