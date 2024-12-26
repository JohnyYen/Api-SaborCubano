using System;
using SaborCubano.Application.Features.User.Command.Register;

namespace SaborCubano.API.Features.Auth.Register;

public class RegisterEndpoint(IMediator mediator) : Endpoint<RegisterRequest, RegisterResponse>
{
   private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Post("api/auth/register");
        AllowAnonymous();
        Description(x => x.WithTags("Auth"));
    }

    public async override Task<RegisterResponse> ExecuteAsync(RegisterRequest request, CancellationToken ct){
       var response = await _mediator.Send(new RegisterRequestCommand(
        request.user_name,
        request.password,
        request.email,
        request.city));
        Console.WriteLine(response);
        return new RegisterResponse(response.Id, response.Token);
    }
}
