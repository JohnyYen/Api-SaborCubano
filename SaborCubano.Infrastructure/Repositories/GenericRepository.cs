using System;
using System.Linq.Expressions;
using api.Models;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain;
using SaborCubano.Domain.Commons;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : BaseEntity
{
   protected readonly ApplicationDBContext _context;

    public GenericRepository(ApplicationDBContext context){
        _context = context;
    }
    public async Task<TModel> CreateAsync(TModel entity)
    {
       try
       {
        await _context.GetDbSet<TModel>().AddAsync(entity);
        await _context.SaveChangesAsync();
       }
       catch (ArgumentNullException e)
       {
        Console.WriteLine(e.Source);
        Console.WriteLine(e.StackTrace);
       }

       return entity;
    }

    public async Task<TModel?> DeleteAsync(int id)
    {
        var entity = await _context.GetDbSet<TModel>().FirstAsync(r => r.Id == id);

        if(entity == null)
            return null;

        _context.GetDbSet<TModel>().Remove(entity!);
        await _context.SaveChangesAsync();
        return entity;
    }

    public IQueryable<TModel> FindAsync(Expression<Func<TModel, bool>> filter = null!)
    {
        return _context.GetDbSet<TModel>().Where(filter);
    }

    public async Task<TModel?> FindOneAsync(Expression<Func<TModel, bool>> filter)
    {
        return await _context.GetDbSet<TModel>().FirstOrDefaultAsync(filter);
    }

    public IQueryable<TModel> GetAllAsync()
    {
        var entity = _context.GetDbSet<TModel>();
        return entity;
    }

    public async Task<TModel?> GetByIdAsync(int id)
    {
        return await _context.GetDbSet<TModel>().FindAsync(id);
    }

    public async Task<TModel?> UpdateAsync(TModel model)
    {
        var entity = _context.GetDbSet<TModel>().Update(model).Entity ?? null;
        
        await _context.SaveChangesAsync();
        return entity;
    }
}
