

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Nomadwork.Infra.Models;

namespace Nomadwork.Controllers
{
    [Route("api/token")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _confguration;

        public TokenController (IConfiguration configuration){
            _confguration = configuration;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] UserLogin request ){

            if (true){

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name,request.Email),
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_confguration["SecurityKey"]));

                var creds =  new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "nomadwork.com.br", 
                    audience: "nomadwork.com.br",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            return BadRequest("Credenciais inválidas...");
        }
    }
}