using System;
using api.Models;

namespace SaborCubano.Application.Interfaces;

public interface IUserRepository
{
    public Task<User> CreateAppUserAsync(User user);
    public Task<User?> FindByIdAsync(string id);
    public Task<User?> FindUser(string user_name);
     public Task<bool> CheckPassword(User user, string password); 
}
