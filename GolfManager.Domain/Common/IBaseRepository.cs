using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Common
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllWithPagination(int page, int pageSize);
        void Delete(T entity);
    }
}
