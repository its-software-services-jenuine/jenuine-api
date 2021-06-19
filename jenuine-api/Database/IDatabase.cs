using System;
using MongoDB.Driver;

namespace Its.Jenuiue.Api.Database
{
    public interface IDatabase
    {
        public IMongoDatabase GetCustomerDb(string custId);
        public IMongoCollection<T> GetCollectionGlobal<T>(string name);
    }
}
