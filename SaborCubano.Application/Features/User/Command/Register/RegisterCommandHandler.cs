
using api.Models;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.User.Command.Register;

public record class RegisterCommandHandler(ITokenGenerator tokenGenerator
, IUserRepository repo) : IRequestHandler<RegisterRequestCommand, RegisterResponseCommand>
{
    private readonly IUserRepository _repo = repo;
    private readonly ITokenGenerator _generator = tokenGenerator;
    public async Task<RegisterResponseCommand> Handle(RegisterRequestCommand request, CancellationToken cancellationToken)
    { 
        var user = await _repo.CreateAppUserAsync(request.toModel());

        string token = _generator.GenerateJwt(user.Id, user.User_Name, user.Email!);
        return ((AppUser)user).toResponse(token);
    }
}
