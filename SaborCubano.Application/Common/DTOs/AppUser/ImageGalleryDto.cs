using System;

namespace SaborCubano.Application.Common.DTOs.AppUser;

public class ImageGalleryDto : IRequest
{
    public string IdUser {get; set;} = null!;
    public string Image {get; set;} = null!;
}
