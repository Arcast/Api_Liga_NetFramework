using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Data.UnitOfWork;
using Services.ViewModels;

namespace Services
{
    public class RepresentanteService
    {
      
        public static RepresentanteLiga getRepresentante(int id)
        {
            using (var unit = new UnitOfWork(new LigaFutbolEntities()))
            {                
                    return (unit.RepresentanteLiga.getById(id));
              
            }   
        }

        public static List<RepresentanteLiga> getListaRepresentantes()
        {
            using (var unit = new UnitOfWork(new LigaFutbolEntities()))
            {
                return (unit.RepresentanteLiga.getAll().ToList());
            }
        }

        public static Boolean GuardarRepresentante(VM_RepresentanteLiga representante)
        {
            using (var unit = new UnitOfWork(new LigaFutbolEntities()))
            {
                try
                {
                    RepresentanteLiga _representante = new RepresentanteLiga();
                    _representante.Nombres = representante.Nombres;
                    _representante.Apellidos = representante.Apellidos;
                    _representante.Cedula = representante.Cedula;
                    _representante.Direccion = representante.Direccion;
                    _representante.Telefono = representante.Telefono;
                    _representante.Cargo = representante.Cargo;

                    unit.RepresentanteLiga.AddOrUpdate(_representante);
                    unit.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;

                }
            }
        }

        public static Boolean EditarRepresentante(RepresentanteLiga representanteLiga)
        {
            using (var unit = new UnitOfWork(new LigaFutbolEntities()))
            {
                try
                {
                    unit.RepresentanteLiga.Edit(representanteLiga);
                    unit.Complete();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
