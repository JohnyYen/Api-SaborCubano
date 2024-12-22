using System;

namespace SaborCubano.Application.Features.User.Command.Login;

public record LoginRequestCommand(string UserName, string Password) : IRequest<LoginResponseCommand>;
