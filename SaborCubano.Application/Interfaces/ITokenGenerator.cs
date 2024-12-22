using System;

namespace SaborCubano.Application.Interfaces;

public interface ITokenGenerator
{
    string GenerateJwt(string id, string user_name, string email);
}
