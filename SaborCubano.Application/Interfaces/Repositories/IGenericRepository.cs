using System;
using System.Linq.Expressions;
using SaborCubano.Application.Commons;
using SaborCubano.Domain.Commons;

namespace SaborCubano.Application.Interfaces;

public interface IGenericRepository<TModel> where TModel : class, IModel
{
    public IQueryable<TModel> GetAllAsync();
    public Task<TModel?> GetByIdAsync(int id);
    public Task<TModel?> FindOneAsync(Expression<Func<TModel, bool>> filter);
    public IQueryable<TModel> FindAsync(Expression<Func<TModel, bool>> filter);
    public Task<TModel> CreateAsync(TModel model);
    public Task<TModel?> UpdateAsync(GenericDTO<TModel> model, int id);
    public Task<TModel?> DeleteAsync(int id);
}
