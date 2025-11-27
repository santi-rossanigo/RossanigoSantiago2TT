using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace TP3_Entity
{
    public class RepositorioProductos
    {
        public void Agregar(Producto p)
        {
            using var ctx = new AppDbContext();
            ctx.Productos.Add(p);
            ctx.SaveChanges();
        }

        
        public List<Producto> Listar()
        {
            using var ctx = new AppDbContext();
            return ctx.Productos.ToList();
        }

        
        public bool Actualizar(Producto p)
        {
            using var ctx = new AppDbContext();
            var existe = ctx.Productos.Find(p.Id);
            if (existe is null) return false;

            existe.Nombre = p.Nombre;
            existe.Precio = p.Precio;
            existe.Stock = p.Stock;
            ctx.SaveChanges();
            return true;
        }

        
        public bool Eliminar(int id)
        {
            using var ctx = new AppDbContext();
            var entidad = ctx.Productos.Find(id);
            if (entidad is null) return false;

            ctx.Productos.Remove(entidad);
            ctx.SaveChanges();
            return true;
        }
    }
}
