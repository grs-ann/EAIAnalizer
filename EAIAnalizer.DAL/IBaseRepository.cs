using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.DAL
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T?> GetById(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T?> DeleteById(int id);
        Task<T?> DeleteById(Guid id);
    }
}
