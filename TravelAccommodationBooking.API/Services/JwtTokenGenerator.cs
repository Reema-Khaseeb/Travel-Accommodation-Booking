﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.API.Utilities;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Services
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly string _secretKey;

        public JwtTokenGenerator(IConfiguration configuration)
        {
            _secretKey = configuration["Authentication:SecretKey"]
                ?? throw new ArgumentNullException(nameof(configuration));
        }

        public string GenerateToken(User user)
        {
            const int expiringDays = 2;
            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = GetClaimsIdentity(user),
                Expires = DateTime.UtcNow.AddDays(expiringDays), // Token expiration time
                SigningCredentials = CreateSigningCredentials(_secretKey)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public bool ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                tokenHandler.ValidateToken(token, GetTokenValidationParameters(), out _);
                return true;
            }
            catch (SecurityTokenException)
            {
                // Token validation failed
                return false;
            }
        }

        private ClaimsIdentity GetClaimsIdentity(User user)
        {
            return new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role.ToString()),
            new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // token unique identifier; preventing token replay attacks
            });
        }

        private TokenValidationParameters GetTokenValidationParameters()
        {
            return new TokenValidationParametersBuilder()
                .WithSecretKey(_secretKey)
                .WithDefaultValidationParameters()
                .Build();
        }

        private SigningCredentials CreateSigningCredentials(string secretKey)
        {
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            return new SigningCredentials(
                symmetricSecurityKey,
                SecurityAlgorithms.HmacSha256Signature);
        }
    }

}
