using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Datos
{
    public class Crud
    {

        private static Sgsst mapeo = new Sgsst();

        public static void Insertar(Object entidad){

            mapeo.Entry(entidad).State = System.Data.Entity.EntityState.Added;
            mapeo.SaveChanges();

        }

        public static void Actualizar(Object entidad)
        {

            mapeo.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
            mapeo.SaveChanges();

        }

        public static void Eliminar(Object entidad)
        {

            mapeo.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
            mapeo.SaveChanges();

        }

    }
}
