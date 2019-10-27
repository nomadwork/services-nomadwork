using Microsoft.AspNetCore.Mvc;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Controllers
{
    [Route("resetdatabase")]
    [ApiController]
    public class InitController : ControllerBase
    {
        private readonly NomadworkDbContext _context;

        public InitController(NomadworkDbContext context)
        {
            _context = context;
        }

        [HttpDelete("estab/{code}")]
        public async Task<ActionResult> ResetDatabase(string code)
        {
            if (code.Equals("090787"))
            {
                var repository = EstablishmmentRepository.GetInstance(_context);

                if (repository.GetAll().ToList().Count > 0)
                {
                    repository.DeleteAll();
                }

                var establishments = new EstablishmmentMockup().Init();
                await repository.CreateMok(establishments);

                return Ok("Estabelecimentos resetados!!");
            }

            return BadRequest("Código errado");

        }

        [HttpDelete("user/{code}")]
        public async Task<ActionResult> ResetUser(string code)
        {
            if (code.Equals("090787"))
            {
                var repositoy = UserRepository.GetInstance(_context);
                var userMok =  UserMockup.Init();
                await repositoy.CreateMultiple(userMok);

                return Ok("Usuarios Criados resetados!!");

            }

            return BadRequest("Código errado");

        }

    }
}
