using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace Datos
{
    public class Crud
    {

        public static void Insertar(Object entidad){

            Sgsst.GetControlador().Entry(entidad).State = System.Data.Entity.EntityState.Added;
            Sgsst.GetControlador().SaveChanges();

        }

        public static void Actualizar(Object entidad)
        {

            Sgsst.GetControlador().Entry(entidad).State = System.Data.Entity.EntityState.Modified;
            Sgsst.GetControlador().SaveChanges();

        }

        public static void Eliminar(Object entidad)
        {

            Sgsst.GetControlador().Entry(entidad).State = System.Data.Entity.EntityState.Deleted;
            Sgsst.GetControlador().SaveChanges();

        }

    }
}
