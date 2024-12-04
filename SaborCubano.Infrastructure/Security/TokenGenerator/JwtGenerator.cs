using System;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Infrastructure.Security.TokenGenerator;

public class JwtGenerator : ITokenGenerator
{
    public string GenerateJwt(Guid id, string user_name, string email)
    {
        throw new NotImplementedException();
    }
}
