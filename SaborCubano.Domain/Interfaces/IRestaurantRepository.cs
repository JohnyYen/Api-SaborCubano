using System;
using api.Models;

namespace SaborCubano.Domain.Interfaces;

public interface IRestaurantRepository
{
    public Task<List<Restaurant>> GetAllAsync();
    public Task<Restaurant?> GetByIdAsync(int id);
    public Task<Restaurant> CreateAsync(Restaurant restaurant);
    public Task<Restaurant?> UpdateAsync(Restaurant restaurant);
    public Task<Restaurant?> DeleteAsync(int id);
}
