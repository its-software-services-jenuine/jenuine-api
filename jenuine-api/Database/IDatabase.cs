using System;
using MongoDB.Driver;

namespace Its.Jenuiue.Api.Database
{
    public interface IDatabase
    {
        public IMongoDatabase GetOrganizeDb(string orgId);
        public IMongoCollection<T> GetCollectionGlobal<T>(string name);
    }
}
