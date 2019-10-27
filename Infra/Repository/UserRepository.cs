using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;
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

        internal static UserRepository GetInstance(NomadworkDbContext context)
            => new UserRepository(context);


        internal UserModelData GetByEmail(string email)
             => _context.Users.FirstOrDefault(user => user.Email.Equals(email) && user.Active);


        internal bool EmailValidation(string email)
             => _context.Users.Any(user => user.Email.Equals(email) && user.Active);


        internal async Task<UserModelData> GetUserLogin(string email, string password)
            => await _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(email) && x.Password.Equals(password) && x.Active);


        internal async Task<ReturnRepository> CreateMultiple(List<UserModelData> users)
        {
            try
            {
                _context.Users.AddRange(users);
                await _context.SaveChangesAsync();

                return ReturnRepository.Create(false, "Usuários salvo com sucesso!");

            }
            catch (DbUpdateException ex)
            {
                return ReturnRepository.Create(true, string.Format("Erro ao salvar usuario! Analise o erro: {0}", ex.Message));
            }

        }


        internal async Task<ReturnRepository> Create(UserModelData user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return ReturnRepository.Create(false, string.Format("Usuário {0} salvo com sucesso!", user.Email));

            }
            catch (DbUpdateException ex)
            {
                return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}", user.Email, ex.Message));

            }

        }


        //internal async Task<ReturnRepository> CreateUser(UserToCreate userToCreate)
        //{

        //    try
        //    {
        //        _context.Users.Add(userToCreate.ToUser());
        //        await _context.SaveChangesAsync();

        //        return ReturnRepository.Create(false, string.Format("Usuário {0} salvo com sucesso!", userToCreate.Email));


        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        return ReturnRepository.Create(true, string.Format("Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}", userToCreate.Email, ex.Message));

        //    }

        //}

    }
}
