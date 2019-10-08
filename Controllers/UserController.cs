
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Nomadwork.Controllers.ViewObject;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Infra.Repository;
using Nomadwork.Infra.Token;
using Nomadwork.ViewObject;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Nomadwork.ViewObject.Shared.Enum;

namespace Nomadwork.Controllers
{
    [Route("api/user")]
    [Authorize("Bearer")]
    [ApiController]

    public class UserController : ControllerBase
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



        [AllowAnonymous]
        [HttpPost("login")]
        public object PostLogin([FromBody] UserToSelect userSend,[FromServices]SigningConfigurations signingConfigurations,[FromServices]TokenConfiguration tokenConfigurations)
        {

            var UserGet = UserRepository.GetInstance(_context).GetUser(userSend.Email, userSend.Password);
            bool credenciaisValidas = false;
            if (userSend != null && !string.IsNullOrEmpty(userSend.Email) && !string.IsNullOrEmpty(userSend.Password))
            {
                
                //var UserGet = userRepositry.GetUser(userSend.Email, userSend.Password);
                credenciaisValidas = (UserGet != null && UserGet.Id != 0);
            }

            if (credenciaisValidas)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(userSend.Email, "Login"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, userSend.Email)
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao +
                    TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });
                var token = handler.WriteToken(securityToken);
                var userFinal = new UserModelDataToUser
                {

                    Name = UserGet.Name,
                    Email = UserGet.Email,
                    Dateborn = UserGet.Dateborn,
                    Gender = UserGet.Gender

                };

                var tokenFinal = new TokenCreateGetUser(new
                {
                    authenticated = true,
                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,

                }, userFinal);

                return Ok(Json.Create("Token Criado.", tokenFinal));
                
            }
            else
            {
                return new
                {
                    authenticated = false,
                    message = "Falha ao autenticar"
                };
            }
        }

        [AllowAnonymous]
        [HttpPost("create")]
        public async Task<object> PostCreateAsync([FromBody] UserCreateToUserModelData userSend, [FromServices]SigningConfigurations signingConfigurations, [FromServices]TokenConfiguration tokenConfigurations)
        {

            
            var repositoy = UserRepository.GetInstance(_context);
            var userCreate =  await repositoy.CreateUser(userSend);

            if (userCreate.status) {

                ClaimsIdentity identity = new ClaimsIdentity(
                        new GenericIdentity(userSend.Email, "Login"),
                        new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, userSend.Email)
                        }
                    );

                    DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao +
                        TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                    var handler = new JwtSecurityTokenHandler();
                    var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                    {
                        Issuer = tokenConfigurations.Issuer,
                        Audience = tokenConfigurations.Audience,
                        SigningCredentials = signingConfigurations.SigningCredentials,
                        Subject = identity,
                        NotBefore = dataCriacao,
                        Expires = dataExpiracao
                    });
                    var token = handler.WriteToken(securityToken);
                    var UserGet = UserRepository.GetInstance(_context).GetByEmail(userSend.Email);
                    var userFinal = new UserModelDataToUser
                    {

                        Name = UserGet.Name,
                        Email = UserGet.Email,
                        Dateborn = UserGet.Dateborn,
                        Gender = UserGet.Gender

                    };

                    var tokenFinal = new TokenCreateGetUser(new
                    {
                        authenticated = true,
                        created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                        expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                        accessToken = token,

                    }, userFinal);

                    return Ok(Json.Create("Token Criado.", tokenFinal));

                }
            return new
            {
                authenticated = false,
                message = "Falha ao autenticar"
            };
        }
        
                
            

        
    




        [HttpDelete]
        public async Task Go()
        {
            var repositoy = UserRepository.GetInstance(_context);
            var userMok = new UserMockup().Init();
            await repositoy.CreateSingle(userMok);
        }

    }
}
