using mvcMiProyectoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcMiProyectoMVC.AccesoDatos.Data.Repository.IRepository
{
    public interface IAlmacenRepository : IRepository<Almacen>
    {
        void Update(Almacen almacen);
    }
}
