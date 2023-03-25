using KeyZone.DataAccess;
using KeyZone.Services.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KeyZone.Services.Repository.Implementation
{
    public class Repository<T> :IRepository<T> where T : class
    {
        private KeyZoneDbContext _db;
        private readonly DbSet<T> _dbset;
        public Repository(KeyZoneDbContext db)
        {
            _db = db;
            _dbset = _db.Set<T>();
        }


        public async Task DeleteAsyncById(int id)
        {

            var elementDelete = await this.GetById(id);

            if (elementDelete != null)
            {
                _dbset.Remove(elementDelete);
            }
        }

        public void DeleteAsync(T entity)
        {
            _dbset.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T,bool>> filter = null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,string addProperties = null)
        {
            IQueryable<T> query = _dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (addProperties != null)
            {
                //Busco separar las propiedades por la coma y elimina del areglo que devulve los elementos vacios
                foreach (var includePorperties in addProperties.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includePorperties);

                }
                return query;
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }

            return await query.ToListAsync();
        }


        public async Task<T?> GetFirst(Expression<Func<T,bool>> filter = null,string addProperties = null)
        {
            IQueryable<T> query = _dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (addProperties != null)
            {
                //Busco separar las propiedades por la coma y elimina del areglo que devulve los elementos vacios
                foreach (var includePorperties in addProperties.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includePorperties);

                }
                return await query.FirstOrDefaultAsync();
            }

            return await query.FirstOrDefaultAsync();

        }


        public async Task<T?> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _dbset.AddAsync(entity);
        }


    }
}
