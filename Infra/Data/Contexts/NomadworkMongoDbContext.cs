using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Nomadwork.Infra.Data.ObjectData.Schemes;
using Nomadwork.ViewObject.Shared;

namespace Nomadwork.Infra.Data.Contexts
{
   
    public class NomadworkMongoDbContext
    {

      
            private readonly IMongoDatabase _db;
            

            public NomadworkMongoDbContext(IOptions<MongoSettings> options, IMongoClient client)
            {
                _db = client.GetDatabase(options.Value.Database);
            }

            public IMongoCollection<EstablishmmentDetailsScheme> Establishmentcollection => _db.GetCollection<EstablishmmentDetailsScheme>("Establishmentcollection");
        
    }
}
