using System;

namespace SaborCubano.API.Features.Auth.Register;

public record RegisterRequest(string user_name, string email, string password, string city);
