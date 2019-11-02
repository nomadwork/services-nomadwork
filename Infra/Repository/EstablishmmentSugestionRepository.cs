using Nomadwork.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Repository
{
    public class EstablishmmentSugestionRepository
    {
        private readonly NomadworkDbContext _context;

        private EstablishmmentSugestionRepository(NomadworkDbContext context)
        {
            _context = context;
        }

        internal static EstablishmmentSugestionRepository GetInstance(NomadworkDbContext context)
            => new EstablishmmentSugestionRepository(context);

    }
}
