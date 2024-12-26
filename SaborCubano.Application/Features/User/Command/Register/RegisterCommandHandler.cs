
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
        var city = await _repo.FindCity(request.city!);

        if(city is null) throw new Exception("CITY_NOT_FOUND");

        var model = request.toModel();
        ((AppUser)model).City = city;


        var user = await _repo.CreateAppUserAsync(model);

        string token = _generator.GenerateJwt(user.Id, user.UserName!, user.Email!);
        return ((AppUser)user).toResponse(token);
    }
}
