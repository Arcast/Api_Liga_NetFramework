using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data.Repositories.IRepository
{
    public interface IRepository<T> where T : class
    {
        T getById(int id);
        IEnumerable<T> getAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void AddOrUpdate(T entidad);
        void AddRange(IEnumerable<T> entidad);

        void Edit(T entidad);
    }
}
