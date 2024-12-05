using System;
using api.Models;
using SaborCubano.Application.Features.User.Command.Register;

namespace SaborCubano.Application.Common.Mappers;

public static class UserMapper
{
    public static AppUser toModel(this RegisterRequestCommand dto){
        return new AppUser{
            Email = dto.email,
            Password = dto.password,
            User_Name = dto.user_name, 
           
        };

        // City = new City(dto.city),
    }

    public static RegisterResponseCommand toResponse(this AppUser user, string token) => new RegisterResponseCommand
    {
        Id = user.Id,
        User_name = user.User_Name,
        Email = user.Email!,
        Token = token,
    };
}
