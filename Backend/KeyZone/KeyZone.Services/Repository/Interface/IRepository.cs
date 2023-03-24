using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Services.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);

        Task<IEnumerable<T>> GetAll();


        Task DeleteAsyncById(int id);

        void DeleteAsync(T entity);


        Task Insert(T entity);


    }
}
