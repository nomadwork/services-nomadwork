using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using System.Threading.Tasks;

namespace Nomadwork.Infra.Repository
{
    public class SugestionRepository
    {
        private readonly NomadworkDbContext _context;

        private SugestionRepository(NomadworkDbContext context)
        {
            _context = context;
        }

        internal static SugestionRepository GetInstance(NomadworkDbContext context)
            => new SugestionRepository(context);


        internal async Task<ReturnRepository> CreateSingle(EstablishmmentSugestionModelData establishmentModelData)
        {
            try
            {
                _context.EstablishmentSugestions.Add(establishmentModelData);
                await _context.SaveChangesAsync();
                return ReturnRepository.Create(false, string.Format("Estabelecimento {0} salvo com sucesso!", establishmentModelData.Name));
            }
            catch (DbUpdateException ex)
            {
                return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento {0}! Analise o erro: {1}", establishmentModelData.Name, ex.InnerException));
            }

        }

    }
}
