using System;
using System.Linq.Expressions;
using SaborCubano.Domain;
using SaborCubano.Domain.Commons;

namespace SaborCubano.Application.Interfaces;

public interface IGenericRepository<TModel> where TModel : BaseEntity
{
    public IQueryable<TModel> GetAllAsync();
    public Task<TModel?> GetByIdAsync(int id);
    public Task<TModel?> FindOneAsync(Expression<Func<TModel, bool>> filter);
    public IQueryable<TModel> FindAsync(Expression<Func<TModel, bool>> filter);
    public Task<TModel> CreateAsync(TModel model);
    public Task<TModel?> UpdateAsync(TModel model);
    public Task<TModel?> DeleteAsync(int id);
}
