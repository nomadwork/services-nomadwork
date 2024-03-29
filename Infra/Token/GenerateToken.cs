﻿using Microsoft.IdentityModel.Tokens;
using Nomadwork.ViewObject.User;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace Nomadwork.Infra.TokenGenerate
{
    public static class GenerateToken
    {
        internal static Token TokenGenerate(string email, SigningConfigurations signingConfigurations, TokenConfiguration tokenConfigurations)
        {
            var identity = new ClaimsIdentity(
                       new GenericIdentity(email, "Login"),
                       new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, email)
                       }
                   );

            var handler = new JwtSecurityTokenHandler();

            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = tokenConfigurations.Issuer,
                Audience = tokenConfigurations.Audience,
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = DateTime.Now,
                Expires = DateTime.Now + TimeSpan.FromSeconds(tokenConfigurations.Seconds)
            });

            var token = string.Format("{0} {1}", "Bearer", handler.WriteToken(securityToken));

            return Token.Create(tokenConfigurations.Seconds,token);
        }
    }
}
