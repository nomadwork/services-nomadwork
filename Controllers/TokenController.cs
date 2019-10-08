
using Nomadwork.Infra.Repository;
using Nomadwork.ViewObject;
using System.Text.RegularExpressions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Nomadwork.Infra.Data.ObjectData;
using Nomadwork.Infra.Data.Contexts;
using Microsoft.Extensions.Configuration;
using System;

namespace Nomadwork.Controllers
{
    [Route("api/token")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly NomadworkDbContext _context;
        private readonly IConfiguration _confguration;
        public TokenController(NomadworkDbContext context, IConfiguration configuration)
        {
            _context = context;
            _confguration = configuration;
        }
        [HttpPost("user/login")]
        public ActionResult<Json> RequestToken([FromBody] UserModelData request)
        {



            var repositoy = UserRepository.GetInstance(_context);
            var user = repositoy.GetByEmail(request.Email);

            if (user != null)
            {
                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                if (rg.IsMatch(user.Email))
                {

                    var claims = new[]
                    {
                    new Claim(ClaimTypes.Name,request.Email),
                };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_confguration["SecurityKey"]));

                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: "nomadwork.com.br",
                        audience: "nomadwork.com.br",
                        claims: claims,
                        //expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: creds);

                    var tokenFinal = new JwtSecurityTokenHandler().WriteToken(token);

                    var tokenUser = new TokenCreateGetUser(tokenFinal, user);

                    return Ok(Json.Create("Token Criado.", tokenUser));

                }
                return BadRequest("Credenciais inválidas...");
            }
            return BadRequest("Usuario Não Encontrado...");
        


    }

        [HttpPost("user/create")]
        public ActionResult<Json> CreateUser([FromBody] UserModelData request)
        {

            var repositoy = UserRepository.GetInstance(_context);
            var user = repositoy.GetByEmail(request.Email);

            if (user != null)
            {
                Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

                if (rg.IsMatch(user.Email))
                {

                    var claims = new[]
                    {
                    new Claim(ClaimTypes.Name,request.Email),
                };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_confguration["SecurityKey"]));

                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: "nomadwork.com.br",
                        audience: "nomadwork.com.br",
                        claims: claims,
                        //expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: creds);

                    var tokenFinal = new JwtSecurityTokenHandler().WriteToken(token);

                    var tokenUser = new TokenCreateGetUser(tokenFinal, user);

                    return Ok(Json.Create("Token Criado.", tokenUser));

                }
                return BadRequest("Credenciais inválidas...");
            }
            return BadRequest("Usuario Não Encontrado...");
        }

    }
}