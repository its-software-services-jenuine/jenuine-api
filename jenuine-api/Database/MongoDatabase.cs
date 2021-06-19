using System;
using MongoDB.Driver;

namespace Its.Jenuiue.Api.Database
{
    public class MongoDatabase : IDatabase
    {
        private const string GLOBAL_DB_NAME = "_global_";
        private readonly IMongoClient conn = null;
        private readonly IMongoDatabase globalDb = null;

        public MongoDatabase(IMongoClient client)
        {
            conn = client;
            globalDb = conn.GetDatabase(GLOBAL_DB_NAME);
        }

        public IMongoDatabase GetCustomerDb(string custId)
        {
            var db = conn.GetDatabase(custId);
            return db;
        }

        public IMongoCollection<T> GetCollectionGlobal<T>(string name)
        {
            var coll = globalDb.GetCollection<T>(name);
            return coll;
        }
    }
}
