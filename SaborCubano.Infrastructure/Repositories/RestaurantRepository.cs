using System;
using api.Models;
using SaborCubano.Domain.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly ApplicationDBContext _context;

    public RestaurantRepository(ApplicationDBContext context){
        _context = context;
    }
    public Task<Restaurant> CreateAsync(Restaurant restaurant)
    {
        
    }

    public Task<Restaurant?> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Restaurant>> GetAllAsync()
    {
        return await _context.Restaurants.ToList();
    }

    public async Task<Restaurant?> GetByIdAsync(int id)
    {
        var item = await_context.Restaurants.FindAsync(id);
        return Task(item);
    }

    public async Task<Restaurant?> UpdateAsync(Restaurant restaurant)
    {
        throw new NotImplementedException();
    }
}
