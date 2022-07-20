﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab03Parte3.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Lab03Entities1 : DbContext
    {
        public Lab03Entities1()
            : base("name=Lab03Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<sp_ConsultaProvincia_Result> sp_ConsultaProvincia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ConsultaProvincia_Result>("sp_ConsultaProvincia");
        }
    
        public virtual ObjectResult<sp_ConsultaUsuario_Result> sp_ConsultaUsuario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ConsultaUsuario_Result>("sp_ConsultaUsuario");
        }
    
        public virtual int sp_CrearProvincia(string codigo, string nombre)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CrearProvincia", codigoParameter, nombreParameter);
        }
    
        public virtual int sp_CrearUsuario(string nombreU, string nickname, string password, Nullable<System.DateTime> fecha_creacion, Nullable<System.DateTime> ultima_actualizacion)
        {
            var nombreUParameter = nombreU != null ?
                new ObjectParameter("NombreU", nombreU) :
                new ObjectParameter("NombreU", typeof(string));
    
            var nicknameParameter = nickname != null ?
                new ObjectParameter("Nickname", nickname) :
                new ObjectParameter("Nickname", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fecha_creacionParameter = fecha_creacion.HasValue ?
                new ObjectParameter("Fecha_creacion", fecha_creacion) :
                new ObjectParameter("Fecha_creacion", typeof(System.DateTime));
    
            var ultima_actualizacionParameter = ultima_actualizacion.HasValue ?
                new ObjectParameter("Ultima_actualizacion", ultima_actualizacion) :
                new ObjectParameter("Ultima_actualizacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CrearUsuario", nombreUParameter, nicknameParameter, passwordParameter, fecha_creacionParameter, ultima_actualizacionParameter);
        }
    
        public virtual int sp_EliminaProvincia(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaProvincia", codigoParameter);
        }
    
        public virtual int sp_EliminaUsuario(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaUsuario", idParameter);
        }
    
        public virtual int sp_UpdateProvincia(string codigo, string nombre)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateProvincia", codigoParameter, nombreParameter);
        }
    
        public virtual int sp_UpdateUsuario(Nullable<int> id, string nombreU, string nickname, string password, Nullable<System.DateTime> ultima_actualizacion)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreUParameter = nombreU != null ?
                new ObjectParameter("NombreU", nombreU) :
                new ObjectParameter("NombreU", typeof(string));
    
            var nicknameParameter = nickname != null ?
                new ObjectParameter("Nickname", nickname) :
                new ObjectParameter("Nickname", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var ultima_actualizacionParameter = ultima_actualizacion.HasValue ?
                new ObjectParameter("Ultima_actualizacion", ultima_actualizacion) :
                new ObjectParameter("Ultima_actualizacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateUsuario", idParameter, nombreUParameter, nicknameParameter, passwordParameter, ultima_actualizacionParameter);
        }
    
        public virtual ObjectResult<spConsultarProvinciaPorId_Result> spConsultarProvinciaPorId(Nullable<int> idProvincia)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarProvinciaPorId_Result>("spConsultarProvinciaPorId", idProvinciaParameter);
        }
    
        public virtual int spEditarProvincia(Nullable<int> idProvincia, string nombre, string estado)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarProvincia", idProvinciaParameter, nombreParameter, estadoParameter);
        }
    
        public virtual int spEliminarProvinciapt3(Nullable<int> idProvincia)
        {
            var idProvinciaParameter = idProvincia.HasValue ?
                new ObjectParameter("idProvincia", idProvincia) :
                new ObjectParameter("idProvincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEliminarProvinciapt3", idProvinciaParameter);
        }
    }
}
