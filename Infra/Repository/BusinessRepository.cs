//using Microsoft.EntityFrameworkCore;
//using Nomadwork.Infra.Data.Contexts;
//using Nomadwork.Infra.Data.ObjectData;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Nomadwork.Infra.Repository
//{
//    public class BusinessRepository
//    {
//        private readonly NomadworkDbContext _context;

//        private BusinessRepository(NomadworkDbContext context)
//        {
//            _context = context;
//        }

//        internal static BusinessRepository GetInstance(NomadworkDbContext context)
//          => new BusinessRepository(context);


//        internal BusinessModelData BusinessByUserId(long userId)
//            => _context.Business.Where(x => x.User.Equals(userId)).FirstOrDefault();



//        internal async Task<ReturnRepository> Create(BusinessModelData business)
//        {
//            try
//            {
//                _context.Business.Add(business);
//                await _context.SaveChangesAsync();

//                return ReturnRepository.Create(false, string.Format("Negócio {0} salvo com sucesso!", business));

//            }
//            catch (DbUpdateException ex)
//            {
//                return ReturnRepository.Create(true, string.Format("Erro ao salvar o Negócio!\n Analise o erro: {0}", ex.Message));

//            }

//        }
//    }
//}
