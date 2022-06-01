﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using Entidades;

    public partial class RHEntities : DbContext
    {
        public RHEntities()
            : base("name=RHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<empleados> empleados { get; set; }
    
        public virtual int actualizarEmpleado(Nullable<int> numEmp, string nombre, string correo, string estatus, Nullable<System.DateTime> fechaCrea)
        {
            var numEmpParameter = numEmp.HasValue ?
                new ObjectParameter("numEmp", numEmp) :
                new ObjectParameter("numEmp", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var estatusParameter = estatus != null ?
                new ObjectParameter("estatus", estatus) :
                new ObjectParameter("estatus", typeof(string));
    
            var fechaCreaParameter = fechaCrea.HasValue ?
                new ObjectParameter("fechaCrea", fechaCrea) :
                new ObjectParameter("fechaCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("actualizarEmpleado", numEmpParameter, nombreParameter, correoParameter, estatusParameter, fechaCreaParameter);
        }
    
        public virtual int agregarEmpleado(string nombre, string correo, string estatus, Nullable<System.DateTime> fechCrea)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var estatusParameter = estatus != null ?
                new ObjectParameter("estatus", estatus) :
                new ObjectParameter("estatus", typeof(string));
    
            var fechCreaParameter = fechCrea.HasValue ?
                new ObjectParameter("fechCrea", fechCrea) :
                new ObjectParameter("fechCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("agregarEmpleado", nombreParameter, correoParameter, estatusParameter, fechCreaParameter);
        }
    
        public virtual int eliminarEmpleado(Nullable<int> numEmp)
        {
            var numEmpParameter = numEmp.HasValue ?
                new ObjectParameter("numEmp", numEmp) :
                new ObjectParameter("numEmp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminarEmpleado", numEmpParameter);
        }
    
        public virtual ObjectResult<leerEmpleado_Result> leerEmpleado(Nullable<int> numEmp)
        {
            var numEmpParameter = numEmp.HasValue ?
                new ObjectParameter("numEmp", numEmp) :
                new ObjectParameter("numEmp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<leerEmpleado_Result>("leerEmpleado", numEmpParameter);
        }
    
        public virtual ObjectResult<verEmpleados_Result> verEmpleados()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<verEmpleados_Result>("verEmpleados");
        }
    }
}