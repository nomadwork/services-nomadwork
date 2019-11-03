using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Repository;

namespace Nomadwork.Controllers
{
    [Produces("application/json")]
    [AllowAnonymous, Route("api/Game")]
    public class GameController : Controller
    {
        private readonly LogRepository _gameRepository;

        public GameController(LogRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        // GET: api/Game
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _gameRepository.GetAllGames());
        }

        // GET: api/Game/name
        [HttpGet("{name}", Name = "Get")]
        public async Task<IActionResult> Get(string name)
        {
            var game = await _gameRepository.GetGame(name);

            if (game == null)
                return new NotFoundResult();

            return new ObjectResult(game);
        }

        // POST: api/Game
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GameModelData game)
        {
            await _gameRepository.Create(game);
            return new OkObjectResult(game);
        }

        // PUT: api/Game/5
        [HttpPut("{name}")]
        public async Task<IActionResult> Put(string name, [FromBody]GameModelData game)
        {
            var gameFromDb = await _gameRepository.GetGame(name);

            if (gameFromDb == null)
                return new NotFoundResult();

            game.Id = gameFromDb.Id;

            await _gameRepository.Update(game);

            return new OkObjectResult(game);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            var gameFromDb = await _gameRepository.GetGame(name);

            if (gameFromDb == null)
                return new NotFoundResult();

            await _gameRepository.Delete(name);

            return new OkResult();
        }
    }
}
