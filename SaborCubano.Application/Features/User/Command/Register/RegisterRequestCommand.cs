namespace SaborCubano.Application.Features.User.Command.Register;

public record RegisterRequestCommand(string user_name, string password, string email, string? city) : IRequest<RegisterResponseCommand>;
