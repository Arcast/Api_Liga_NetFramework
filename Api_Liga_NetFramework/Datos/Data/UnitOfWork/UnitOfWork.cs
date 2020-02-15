using Datos.Data.Repositories.IRepository;
using Datos.Data.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _Context;

        public UnitOfWork(DbContext context)
        {
            _Context = context;
            RepresentanteLiga = new RepresentanteRepository(_Context);
        }

        public IRepresentanteRepository RepresentanteLiga { get; private set; }
        
        public int Complete()
        {
            return _Context.SaveChanges();
        }
        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
