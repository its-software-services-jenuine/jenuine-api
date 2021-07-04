using Its.Jenuiue.Api.Database;

namespace Its.Jenuiue.Api.Actions.Products
{
    public class AddProductAction : BaseActionAdd
    {
        public AddProductAction(IDatabase conn, string orgId)
        {
            Init(conn, orgId);
        }

        protected override string GetCollectionName()
        {
            return "products";
        }
    }
}
