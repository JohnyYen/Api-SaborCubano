using System;
using System.Linq.Expressions;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using SaborCubano.Application.Commons;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class UserRepository(UserManager<User> manager) : IUserRepository
{
   private readonly UserManager<User> _manager = manager;

    public Task<User> CreateAppUserAsync(User user = null!)
    {
        if(_manager.FindByEmailAsync(user.Email!) is not null)
            throw new Exception("USER_EXIST");

        return Task.FromResult(user);
    }

    public Task<User?> FindByIdAsync(string id){
        return _manager.FindByIdAsync(id);
   }

}
