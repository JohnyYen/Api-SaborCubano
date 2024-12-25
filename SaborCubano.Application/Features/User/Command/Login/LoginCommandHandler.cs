using System;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.User.Command.Login;

public class LoginCommandHandler(IUserRepository repo
, ITokenGenerator generator) : IRequestHandler<LoginRequestCommand, LoginResponseCommand>
{
    private readonly IUserRepository _repo = repo;
    private readonly ITokenGenerator _generator = generator;
    public async Task<LoginResponseCommand> Handle(LoginRequestCommand request, CancellationToken cancellationToken)
    {
        var user = await _repo.FindUser(request.UserName);

        if(user is null)
            throw new Exception("USER_NOT_EXIST");

        if(!(await _repo.CheckPassword(user, request.Password)))
            throw new Exception("PASSWORD_NOT_EQUALS");

        string token = _generator.GenerateJwt(user.Id, user.UserName!, user.Email!);
        return new LoginResponseCommand(user.Id, token);
    }
}
