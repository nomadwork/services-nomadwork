using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using System;
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
             => _context.Users.FirstOrDefault(user => user.Email.Equals(email) && user.Active);


        public async Task<string> CreateSingle(UserModelData user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return string.Format("Usuário {0} salvo com sucesso!", user.Email);
            }
            catch (Exception ex)
            {
                return string.Format("Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}", user.Email, ex.Message);
            }

        }
    }
}
