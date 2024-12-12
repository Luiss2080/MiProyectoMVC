using mvcMiProyectoMVC.AccesoDatos.Data.Repository.IRepository;
using mvcMiProyectoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcMiProyectoMVC.AccesoDatos.Data.Repository
{
    public class AlmacenRepository : Repository<Almacen>, IAlmacenRepository
    {
        private readonly ApplicationDbContext _db;

        public AlmacenRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Almacen almacen)
        {
            var objDesdeDb = _db.Almacen.FirstOrDefault(s => s.Id == almacen.Id);
            objDesdeDb.NombreAlmacen = almacen.NombreAlmacen;
            objDesdeDb.Direccion = almacen.Direccion;
            objDesdeDb.UrlImagen = almacen.UrlImagen;

            //_db.SaveChanges();
        }
    }
}
