using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Driver;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Infra.Data.ObjectData.Schemes;

namespace Nomadwork.Repository
{
    public class LogRepository 
    {
        private readonly NomadworkMongoDbContext _context;

        public LogRepository(NomadworkMongoDbContext context)
        {
            _context = context;
        }

        public async Task CreateEstablishimmentLog(List<EstablishmmentDetailsScheme> establishmment)
        {
            await _context.Establishmentcollection.InsertManyAsync(establishmment);
        }

        public async Task<IEnumerable<EstablishmmentDetailsScheme>> GetAllEstablishmmentDetails()
        {
            return await _context
                            .Establishmentcollection
                            .Find(_ => true)
                            .ToListAsync();
        }

        public async Task<EstablishmmentDetailsScheme> GetEstablishmmentDetail(long establishmmentId)
        {
            FilterDefinition<EstablishmmentDetailsScheme> filter = Builders<EstablishmmentDetailsScheme>.Filter.Eq(m => m.EstablishmmentId, establishmmentId);

            return await _context
                    .Establishmentcollection
                    .Find(filter)
                    .FirstOrDefaultAsync();

            
             



            //.FirstOrDefaultAsync();
        }

        
    }
}