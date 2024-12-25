using System;
using System.Linq.Expressions;
using api.Models;
using Microsoft.AspNetCore.Identity;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class UserRepository(UserManager<User> manager, ApplicationDBContext context) : IUserRepository
{
   private readonly UserManager<User> _manager = manager;
   private readonly ApplicationDBContext _context = context;

    public async Task<User> CreateAppUserAsync(AppUser user = null!)
    {
        var searchingUser = await _manager.FindByEmailAsync(user.Email!);
        if(searchingUser is not null)
            throw new Exception("USER_EXIST");

        var result = await _manager.CreateAsync(user, user.Password);
        // Console.WriteLine(user.Password);
        // Console.WriteLine(result);
        return user;
    }
    public Task<City?> FindCity(string name) => _context.GetDbSet<City>().FirstOrDefaultAsync(c => c.Name == name);
    public Task<User?> FindByIdAsync(string id) => _manager.FindByIdAsync(id);

    public Task<User?> FindUser(string user_name) => _manager.FindByNameAsync(user_name);

    public Task<bool> CheckPassword(User user, string password) => _manager.CheckPasswordAsync(user, password);

}
