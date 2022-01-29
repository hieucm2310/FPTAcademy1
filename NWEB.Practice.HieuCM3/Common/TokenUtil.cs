using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Common
{
    public class TokenUtil
    {
        public static string EncodeSha256(List<Claim> claims, string key, string issuer, double seconds)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var creds = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer,
                issuer,
                claims,
                expires: DateTime.Now.AddSeconds(seconds),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public static ClaimsPrincipal ValidateToken(string jwtToken, string key, string issuer)
        {
            try
            {
                IdentityModelEventSource.ShowPII = true;

                SecurityToken validatedToken;
                TokenValidationParameters validationParameters = new TokenValidationParameters();

                validationParameters.ValidateLifetime = true;
                validationParameters.RequireExpirationTime = true;
                validationParameters.ValidAudience = issuer;
                validationParameters.ValidIssuer = issuer;
                validationParameters.LifetimeValidator = TokenLifetimeCustomValidator.Validate;
                validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

                ClaimsPrincipal principal =
                    new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

                return principal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public static class TokenLifetimeCustomValidator
    {
        public static bool Validate(
        DateTime? notBefore,
        DateTime? expires,
        SecurityToken tokenToValidate,
        TokenValidationParameters @param
    )
        {
            if (expires == null)
                return true;
            if (expires < DateTime.UtcNow)
                return false;
            return true;
        }
    }
}
