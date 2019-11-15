using Microsoft.Extensions.Options;
using MongoDB.Driver;

using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Nomadwork.Infra.Data.Contexts
{
   
    public class NomadworkMongoDbContext
    {

      
            private readonly IMongoDatabase _db;
            

            public NomadworkMongoDbContext(IOptions<MongoSettings> options, IMongoClient client)
            {
                _db = client.GetDatabase(options.Value.Database);
            }

            public IMongoCollection<GameModelData> Games => _db.GetCollection<GameModelData>("Games");
        
    }
}
