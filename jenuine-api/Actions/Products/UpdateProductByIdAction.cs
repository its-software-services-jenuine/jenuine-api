using System.Collections.Generic;
using Its.Jenuiue.Api.Database;

namespace Its.Jenuiue.Api.Actions.Products
{
    public class UpdateProductByIdAction : BaseActionUpdateById
    {
        public UpdateProductByIdAction(IDatabase conn, string orgId)
        {
            Init(conn, orgId);
        }

        protected override string GetCollectionName()
        {
            return "products";
        }

        protected override List<string>GetUpdateFields()
        {
            var fields = new List<string>() 
            {
                "ProductId",
                "ProductName",
                "Description"
            };

            return fields;
        }
    }
}
