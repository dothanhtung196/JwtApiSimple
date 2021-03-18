using JwtApiSimple.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JwtApiSimple.Services
{
    public interface IAuthenticationService
    {
        public string GenerateToken(List<Claim> claims);
        public string GenerateRefreshToken();

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
