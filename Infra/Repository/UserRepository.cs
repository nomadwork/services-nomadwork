using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.ViewObject;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Nomadwork.ViewObject.Shared.Enum;

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
        public UserModelData GetUser(string email, string password)
            => _context.Users.FirstOrDefault(x => x.Email.Equals(email) && x.Password.Equals(password) && x.Active);

        public async Task<UserCreateResponse> CreateSingle(UserModelData user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return new UserCreateResponse
                {
                    status = true,
                    mensage = "Usuário {0} salvo com sucesso!" + user.Email
                };
                         
            }
            catch (Exception ex)
            {
                return new UserCreateResponse
                {
                    status = false,
                    mensage = "Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}"+
                    user.Email +
                    ex.Message
                };
            }

        }
        public async Task<UserCreateResponse> CreateUser(UserCreateToUserModelData userSend)
        {
            try
            {
                var date = userSend.Dateborn;
                var split = date.Split('/');
                var day = int.Parse(split[0]);
                var month = int.Parse(split[1]);
                var year = int.Parse(split[2]);
                var myDate = new DateTime(year, month, day);

                var gender = Gender.Others;
                switch (userSend.Gender)
                {
                    case 0:
                        gender = Gender.Male;
                        break;
                    case 1:
                        gender = Gender.Female;
                        break;
                    case 2:
                        gender = Gender.Others;
                        break;
                }



                var userConvert = new UserModelData
                {
                    Name = userSend.Name,
                    Email = userSend.Email,
                    Password = userSend.Password,
                    Dateborn = myDate,
                    Gender = gender

                };
                _context.Users.Add(userConvert);
                await _context.SaveChangesAsync();
                return new UserCreateResponse
                {
                    status = true,
                    mensage = "Usuário {0} salvo com sucesso!" + userConvert.Email
                };

            }
            catch (Exception ex)
            {
                return new UserCreateResponse
                {
                    status = false,
                    mensage = "Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}" +
                    userSend.Email +
                    ex.Message
                };
            }

        }

    }
}
