using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Datos
{
    public class Crud
    {

   
        public static void Insertar(Object entidad){

            Sgsst controlador = new Sgsst();

            controlador.Entry(entidad).State = System.Data.Entity.EntityState.Added;
            controlador.SaveChanges();

        }

        public static void Actualizar(Object entidad)
        {

            Sgsst controlador = new Sgsst();

            controlador.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
            controlador.SaveChanges();

        }

        public static void Eliminar(Object entidad)
        {

            Sgsst controlador = new Sgsst();

            controlador.Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
            controlador.SaveChanges();

        }

    }
}
