using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nomadwork.Controllers.ViewObject;
using Nomadwork.Infra.Converts;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Repository;
using Nomadwork.Infra.TokenGenerate;
using Nomadwork.ViewObject;
using Nomadwork.ViewObject.User;
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

                return Json.NotFound("Email n�o est� cadastrado!", false);
            }

            return Json.BadRequest("Email inv�lido!", email);
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

                return Json.Ok("Usu�rio Validado e autenticado!.", userResponse);

            }
            else
            {

                if (Get(userLogin.Email).StatusCode.Value.Equals(200))
                {
                    return Json.NotFound("Senha inv�lida", false);
                }
               
                    return Json.NotFound("Usu�rio n�o cadastrado!", false);
               

            }
        }


        [AllowAnonymous, HttpPost("create")]
        public async Task<Json> PostCreateAsync([FromBody] UserToCreate userSend, [FromServices]SigningConfigurations signingConfigurations, [FromServices]TokenConfiguration tokenConfigurations)
        {

            var repositoy = UserRepository.GetInstance(_context);

            if (repositoy.EmailValidation(userSend.Email))
            {
                return Json.BadRequest("Este email est� sendo utilizado por outro usu�rio", userSend);
            }

            var userValidate = userSend.ToValidate();

            if (userValidate.Erro)
            {
                return Json.BadRequest("Erro ao validar usu�rio, verifique os erros",userValidate.Erros);
            }

            var userCreate = await repositoy.Create(userSend.ToUserData());

            if (userCreate.Erro)
            {
                return Json.BadRequest("Falha ao criar usu�rio!", userCreate.Description);
            }

            var userLogin = UserToLogin.Create(userSend.Email, userSend.Password);

            var login = await Login(userLogin, signingConfigurations, tokenConfigurations);

            if (login == null)
            {
                return Json.BadRequest("Falha ao criar usu�rio", userSend);
            }

            var userResponse = LoginToResponse.Create(login.User, login.Token);

            return Json.Ok("Usus�rio criado com sucesso!", userResponse);

        }

        [HttpPut("{id:long}")]
        public async Task<Json> Update(long id,[FromBody] UserToUpdate user) 
        {
            if (id <= 0
                || user == null
                || !id.Equals(user.Id))
            {
                return Json.BadRequest("Este usu�ro n�o � v�lido!",user);
            }

            var repository = UserRepository.GetInstance(_context);

            var userToUpdate = repository.GetById(id);

            if (!repository.EmailValidation(user.Email)
                || userToUpdate == null)
            {

                return Json.NotFound("Este usu�ro n�o � v�lido!", user);

            }

            var userValidate = user.ToValidate();

            if (userValidate.Erro)
            {
                return Json.BadRequest("Erro ao validar usu�rio, verifique os erros", userValidate.Erros);

            }

            var resultUpdate = await repository.Update(user.ToUserData());

            if (resultUpdate.Erro)
            {
                return Json.BadRequest("Falha ao criar usu�rio!", resultUpdate.Description);
            }

            userToUpdate =  repository.GetById(id);
            return Json.Ok("Usu�rio alterrado com sucesso!", userToUpdate);

        }

        [HttpDelete("{id:long}")]
        public async Task<Json> Delete(long id, [FromBody] UserToLogin user) 
        {
            if (id <= 0
              || user == null)
            {
                return Json.BadRequest("Este usu�ro n�o � v�lido!", user);
            }

            var repository = UserRepository.GetInstance(_context);

            var userToDelete = repository.GetById(id);
           

            if (!repository.EmailValidation(user.Email)
                || userToDelete == null)
            {

                return Json.NotFound("Este usu�ro n�o � v�lido!", user);

            }

            var result = await repository.Delete(user.Email,user.Password);

            if (result.Erro)
            {
                return Json.BadRequest("Falha ao deletar usu�rio!", result.Description);
            }

            userToDelete =  repository.GetById(id);

            if (userToDelete.Result.Active)
            {
                return Json.BadRequest("Falha ao deletar usu�rio!", userToDelete);
            }

            return Json.Ok("Usu�rio Apagado com sucesso!",null);

        }
    }

}
