using System;
using api.Models;

namespace SaborCubano.Application.Interfaces;

public interface IUserRepository
{
    public Task<User> CreateAppUserAsync(User user);
    public Task<User?> FindByIdAsync(string id); 
}
