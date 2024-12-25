using System;
using api.Models;

namespace SaborCubano.Application.Interfaces;

public interface IUserRepository
{
    public Task<User> CreateAppUserAsync(AppUser user);
    public Task<User?> FindByIdAsync(string id);
    public Task<User?> FindUser(string user_name);
    public Task<bool> CheckPassword(User user, string password); 
    public Task<City?> FindCity(string name);
}
