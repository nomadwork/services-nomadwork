using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nomadwork.Controllers.ViewObject;
using Nomadwork.Infra;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.Infra.TokenGenerate;
using Nomadwork.Validate;
using Nomadwork.ViewObject;
using System.Threading.Tasks;

namespace Nomadwork.Controllers
{
    [ApiController, Route("api/user"), Authorize("Bearer")]
    public class UserController : ControllerBase
    {
        private readonly NomadworkDbContext _context;

        public UserController(NomadworkDbContext context)

        {
            _context = context;
        }

        [AllowAnonymous, HttpGet("{email}")]
        public Json Get(string email)
        {
            if (email.IsEmail())
            {
                var repositoy = UserRepository.GetInstance(_context);

                if (repositoy.EmailValidation(email))
                {
                    return Json.Ok("Email validado!", true);
                }

                return Json.NotFound("Email não está cadastrado!", false);
            }

            return Json.BadRequest("Email inválido!", email);
        }


        private async Task<LoginToResponse> Login(UserToLogin userLogin, SigningConfigurations signingConfigurations, TokenConfiguration tokenConfigurations)
        {
            if (userLogin.Email.IsEmail() && !string.IsNullOrEmpty(userLogin.Password))
            {
                var repository = UserRepository.GetInstance(_context);

                var user = await repository.GetUserLogin(userLogin.Email, userLogin.Password);

                if (user != null)
                {
                    var token = GenerateToken.TokenGenerate(user.Email, signingConfigurations, tokenConfigurations);

                    return LoginToResponse.Create(user.ToDisplay(), token);
                }

            }
            return null;
        }


        [AllowAnonymous, HttpPost("login")]
        public async Task<Json> PostLogin([FromBody] UserToLogin userLogin, [FromServices]SigningConfigurations signingConfigurations, [FromServices]TokenConfiguration tokenConfigurations)
        {
            var user = await Login(userLogin, signingConfigurations, tokenConfigurations);

            if (user != null)
            {

                var userResponse = LoginToResponse.Create(user.User, user.Token);

                return Json.Ok("Usuário Validado e autenticado!.", userResponse);

            }
            else
            {

                if (Get(userLogin.Email).StatusCode.Value.Equals(200))
                {
                    return Json.NotFound("Senha inválida", false);
                }
               
                    return Json.NotFound("Usuário não cadastrado!", false);
               

            }
        }


        [AllowAnonymous, HttpPost("create")]
        public async Task<Json> PostCreateAsync([FromBody] UserToCreate userSend, [FromServices]SigningConfigurations signingConfigurations, [FromServices]TokenConfiguration tokenConfigurations)
        {
            var repositoy = UserRepository.GetInstance(_context);

            var userCreate = await repositoy.Create(userSend.ToUser());

            if (userCreate.Erro)
            {
                return Json.BadRequest("Falha ao criar usuário!", userCreate.Description);
            }

            var userLogin = UserToLogin.Create(userSend.Email, userSend.Password);

            var login = await Login(userLogin, signingConfigurations, tokenConfigurations);

            if (login == null)
            {
                return Json.BadRequest("Falha ao criar usuário", userSend);
            }

            var userResponse = LoginToResponse.Create(login.User, login.Token);

            return Json.Ok("Ususário criado com sucesso!", userResponse);

        }
    }

}
