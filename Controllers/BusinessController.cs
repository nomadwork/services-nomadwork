using Microsoft.AspNetCore.Mvc;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.Infra.TokenGenerate;
using Nomadwork.ViewObject;
using Nomadwork.ViewObject.Business;
using System.Threading.Tasks;

namespace Nomadwork.Controllers
{
    [Route("api/business")]

    public class BusinessController : ControllerBase
    {
        private readonly NomadworkDbContext _context;

        public BusinessController(NomadworkDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<Json> Post([FromBody]BusinessToCreate business, [FromServices]SigningConfigurations signingConfigurations, [FromServices]TokenConfiguration tokenConfigurations)
        {
            business.User.Admin = true;
            var controllerUser = new UserController(_context);
            var controllerEstab = new EstablishmmentController(_context);

             _ = await controllerUser.PostCreate(business.User, signingConfigurations,tokenConfigurations);

            var repositoryUser = UserRepository.GetInstance(_context);

            var user = await repositoryUser.GetUserLogin(business.User.Email,business.User.Password);
           
            foreach (var e in business.Establishmments)
            {
                e.IdUser = user.Id;
              await controllerEstab.Post(e);
             
            }


            return Json.Ok("Criado!!",user);


        }
    }
}
