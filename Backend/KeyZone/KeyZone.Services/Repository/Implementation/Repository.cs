using KeyZone.DataAccess;
using KeyZone.Services.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _dbset.AddAsync(entity);
        }


    }
}
