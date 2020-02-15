using Datos.Data.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Data.Repositories.Repository
{
    public class RepresentanteRepository : Repository<RepresentanteLiga>, IRepresentanteRepository
    {
     public RepresentanteRepository(DbContext _Context) : base(_Context)
        {

        }
        public DbContext LigaFutbolContext
        {
            get { return _context as DbContext; }
        }
    }
}
