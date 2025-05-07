using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phuclien_company.Models;

namespace phuclien_company.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(BaseModel entity);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(BaseModel entity);
    }
}