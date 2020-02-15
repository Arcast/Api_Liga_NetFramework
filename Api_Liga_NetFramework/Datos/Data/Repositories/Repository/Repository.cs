using Datos.Data.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data.Repositories.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal DbContext _context; 
        internal DbSet<T> _DbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _DbSet = _context.Set<T>();

        }

        public void AddOrUpdate(T entidad)
        {
            _DbSet.AddOrUpdate(entidad);
        }

        public void AddRange(IEnumerable<T> entidad)
        {
            _DbSet.AddRange(entidad);
        }

        public void Edit(T entidad)
        {
            _context.Entry(entidad).State = EntityState.Modified;
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate);
        }

        public IEnumerable<T> getAll()
        {
            return _DbSet.ToList();
        }

        public T getById(int id)
        {
            return _DbSet.Find(id);
        }

        
    }
}
