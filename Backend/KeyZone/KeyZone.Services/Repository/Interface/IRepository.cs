using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Services.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetById(int id);

        public Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> filter = null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,string addProperties = null);


        Task DeleteAsyncById(int id);

        void DeleteAsync(T entity);


        Task Insert(T entity);
        Task<T?> GetFirst(Expression<Func<T,bool>> filter = null,string addProperties = null);

    }
}
