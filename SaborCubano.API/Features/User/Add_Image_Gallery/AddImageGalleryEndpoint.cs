using System;
using Microsoft.AspNetCore.Http.HttpResults;
using SaborCubano.Application.Common.DTOs.AppUser;

namespace SaborCubano.API.Features.User.Add_Image_Gallery;

public class AddImageGalleryEndpoint(IMediator mediator) : Endpoint<ImageGalleryDto, AddImageResponse>
{
    private readonly IMediator _mediator = mediator;
     public override void Configure()
    {
        Post("api/user/add_image");
        AllowAnonymous();
        Description(x => x.WithTags("User"));
    }

    public async override Task<AddImageResponse> ExecuteAsync(ImageGalleryDto request,CancellationToken ct){
        if(request is null)
            throw new BadHttpRequestException("REQUEST_IS_NULL");

        await _mediator.Send(request);
        var response = new AddImageResponse();
        return response;
    }
}
