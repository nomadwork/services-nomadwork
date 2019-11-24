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

        public async Task<IEnumerable<EstablishmmentDetailsScheme>> GetEstablishmmentDetail(long establishmmentId)
        {
            FilterDefinition<EstablishmmentDetailsScheme> filter = Builders<EstablishmmentDetailsScheme>.Filter.Eq(m => m.EstablishmmentId, establishmmentId);

            return await _context
                    .Establishmentcollection
                    .Find(filter)
                    .ToListAsync();

            
             



            //.FirstOrDefaultAsync();
        }

        //public async Task<IEnumerable<GameModelData>> GetAllGames()
        //{
        //    return await _context
        //                    .Games
        //                    .Find(_ => true)
        //                    .ToListAsync();
        //}

        //public Task<GameModelData> GetGame(string name)
        //{
        //    FilterDefinition<GameModelData> filter = Builders<GameModelData>.Filter.Eq(m => m.Name, name);

        //    return _context
        //            .Games
        //            .Find(filter)
        //            .FirstOrDefaultAsync();
        //}

        //public async Task Create(GameModelData game)
        //{
        //    await _context.Games.InsertOneAsync(game);
        //}

        //public async Task<bool> Update(GameModelData game)
        //{
        //    ReplaceOneResult updateResult =
        //        await _context
        //                .Games
        //                .ReplaceOneAsync(
        //                    filter: g => g.Id == game.Id,
        //                    replacement: game);

        //    return updateResult.IsAcknowledged
        //            && updateResult.ModifiedCount > 0;
        //}

        //public async Task<bool> Delete(string name)
        //{
        //    FilterDefinition<GameModelData> filter = Builders<GameModelData>.Filter.Eq(m => m.Name, name);

        //    DeleteResult deleteResult = await _context
        //                                        .Games
        //                                        .DeleteOneAsync(filter);

        //    return deleteResult.IsAcknowledged
        //        && deleteResult.DeletedCount > 0;
        //}
    }
}