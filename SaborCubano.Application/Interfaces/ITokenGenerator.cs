using System;

namespace SaborCubano.Application.Interfaces;

public interface ITokenGenerator
{
    string GenerateJwt(Guid id, string user_name, string email);
}
