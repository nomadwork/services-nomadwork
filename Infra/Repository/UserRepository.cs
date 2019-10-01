using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Repository
{
    public class UserRepository
    {
        private readonly NomadworkDbContext _context;

        private UserRepository(NomadworkDbContext context)
        {
            _context = context;
        }

        public static UserRepository GetInstance(NomadworkDbContext context)
            => new UserRepository(context);

        public UserModelData GetByEmail(string email)
             => _context.Users
                                    
                                    .FirstOrDefault(user => user.Email.Equals(email) && user.Active);
    }
}
