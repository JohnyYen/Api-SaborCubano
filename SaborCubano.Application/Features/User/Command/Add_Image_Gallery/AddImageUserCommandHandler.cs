using System;
using api.Models;
using SaborCubano.Application.Common.DTOs.AppUser;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.User.Command.Add_Image_Gallery;

public class AddImageUserCommandHandler(IUserRepository repo) : IRequestHandler<ImageGalleryDto>
{

    private readonly IUserRepository _repo = repo;
    public async Task Handle(ImageGalleryDto request, CancellationToken cancellationToken)
    {
        var user = await _repo.FindByIdAsync(request.IdUser);

        if(user is null)
            throw new Exception("USER_NO_FOUND");

        var appUser = (AppUser) user;

        var image = Convert.FromBase64String(request.Image)!;
        appUser.Gallery.Add(image);

    }
}
