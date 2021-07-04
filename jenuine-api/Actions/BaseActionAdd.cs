using System;
using MongoDB.Driver;
using MongoDB.Bson;
using Its.Jenuiue.Api.Models;
using Its.Jenuiue.Api.Database;

namespace Its.Jenuiue.Api.Actions
{
    public abstract class BaseActionAdd : IActionManipulate
    {
        private IDatabase dbConn;
        private IMongoDatabase db;

        protected abstract string GetCollectionName();

        protected virtual bool UseGlobalDb()
        {
            return false;
        }

        protected void Init(IDatabase conn, string orgId)
        {
            dbConn = conn;
            db = conn.GetOrganizeDb(orgId);
        }

        public T Apply<T>(T param)
        {
            (param as BaseModel).CreatedDtm = DateTime.UtcNow;
            (param as BaseModel).ModifiedDtm = DateTime.UtcNow;
            (param as BaseModel).Id = ObjectId.GenerateNewId().ToString();

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

            collection.InsertOne(param);
            return param;
        }
    }
}