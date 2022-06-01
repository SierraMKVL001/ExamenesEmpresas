using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Negocio
{
    public class NEmpleados
{
private RHEntities DBContext = new RHEntities();
        public List<empleados> Consultar()
        {
            DBContext.Configuration.LazyLoadingEnabled = false;
            List<empleados> lista = DBContext.empleados.ToList();
            return lista;
        }
        public empleados Consultar(int id)
        {
            empleados consultar = DBContext.empleados.Find(id);
            return consultar;
        }
        public void Agregar(empleados emp)
        {
            DBContext.agregarEmpleado(emp.nombre, emp.correo, emp.estatus, emp.fechaCreacion);
            DBContext.SaveChanges();
        }
        public void Eliminar(int numEmpl)
        {
            DBContext.eliminarEmpleado(numEmpl);
            DBContext.SaveChanges();
        }
        public void Actualizar(empleados emp)
        {
            DBContext.actualizarEmpleado(emp.numEmp, emp.nombre, emp.correo, emp.estatus, emp.fechaCreacion);
            DBContext.SaveChanges();
        }
    }
}
