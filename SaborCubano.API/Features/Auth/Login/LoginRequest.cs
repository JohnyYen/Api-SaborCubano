using System;
using SaborCubano.Application.Features.User.Command.Login;

namespace SaborCubano.API.Features.Auth.Login;

public record LoginRequest(string user_name, string password);