using System;
using SaborCubano.Application.Features.User.Command.Login;

namespace SaborCubano.API.Features.Auth.Login;

public class LoginEndpoint(IMediator mediator) : Endpoint<LoginRequest, LoginResponse>
{
    private readonly IMediator _mediator = mediator;
     public override void Configure()
    {
        Get("api/auth/login");
        AllowAnonymous();
    }

    public async override Task<LoginResponse> ExecuteAsync(LoginRequest request,CancellationToken ct){
        var response = await _mediator.Send(new LoginRequestCommand(request.user_name, request.password));

        return new LoginResponse(response.id, response.token);
    }
}

