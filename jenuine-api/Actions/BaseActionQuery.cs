using System.Collections.Generic;
using MongoDB.Driver;
using Its.Jenuiue.Api.Database;
using Its.Jenuiue.Api.ModelsViews;

namespace Its.Jenuiue.Api.Actions
{
    public class BaseActionQuery : IActionQuery
    {
        private readonly IDatabase dbConn;
        private readonly IMongoDatabase db;

        public BaseActionQuery(IDatabase conn, string orgId)
        {
            dbConn = conn;
            db = conn.GetOrganizeDb(orgId);
        }

        public List<T> Apply<T>(T param, BaseModelView queryParam)
        {
            return null;
        }
    }
}
