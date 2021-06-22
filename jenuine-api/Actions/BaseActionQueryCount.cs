using MongoDB.Driver;
using Its.Jenuiue.Api.Database;

namespace Its.Jenuiue.Api.Actions
{
    public abstract class BaseActionQueryCount : IActionQueryCount
    {
        private IDatabase dbConn;
        private IMongoDatabase db;

        protected abstract string GetCollectionName();

        protected virtual FilterDefinition<T> GetFilter<T>(T model)
        {
            var filter = FilterDefinition<T>.Empty;
            return filter;
        }

        protected virtual bool UseGlobalDb()
        {
            return false;
        }

        protected void Init(IDatabase conn, string orgId)
        {
            dbConn = conn;
            db = conn.GetOrganizeDb(orgId);
        }

        public long Apply<T>(T param)
        {
            bool isGlobalDb = UseGlobalDb();
            string collName = GetCollectionName();

            IMongoCollection<T> collection;
            if (isGlobalDb)
            {
                collection = dbConn.GetCollectionGlobal<T>(collName);
            }
            else
            {
                collection = db.GetCollection<T>(collName);
            }

            var filter = GetFilter<T>(param);
            var results = collection.Find(filter);

            return results.CountDocuments();
        }
    }
}