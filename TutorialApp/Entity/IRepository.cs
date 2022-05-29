using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TutorialApp.Entity
{
    
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task<List<T>> ReadAllAsync();
        Task<(List<T>, int)> ReadAllFilterAsync(int skip, int take);
        Task<List<T>> ReadAllAsync(Expression<Func<T, bool>> filter);

        Task<T> ReadAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
}
