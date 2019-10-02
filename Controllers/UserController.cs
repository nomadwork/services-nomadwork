using Microsoft.AspNetCore.Mvc;
using Nomadwork.Domain.Business;
using Nomadwork.Infra;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.ViewObject;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nomadwork.Controllers
{
    [Route("api/user")]
    public class UserController
    {
        private readonly NomadworkDbContext _context;

        public UserController(NomadworkDbContext context)
        {
            _context = context;
        }
        [HttpGet("{email}")]
        public bool Get(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                var repositoy = UserRepository.GetInstance(_context);
                var user = repositoy.GetByEmail(email);
                if (user != null)
                {
                    return true;
                }
            }


            return false;


        }

        // [HttpDelete]
        // public async Task Go()
        // {
        //     var repositoy = UserRepository.GetInstance(_context);
        //     var userMok = new UserMockup().Init();
        //     await repositoy.CreateSingle(userMok);
        // }
    }
}
