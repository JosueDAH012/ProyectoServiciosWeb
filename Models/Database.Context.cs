//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace V_VuelosServiciosWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class servicioswebEntities2 : DbContext
    {
        public servicioswebEntities2()
            : base("name=servicioswebEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AEROLINEA> AEROLINEA { get; set; }
        public virtual DbSet<BITACORA> BITACORA { get; set; }
        public virtual DbSet<COMPRAR_BOLETO> COMPRAR_BOLETO { get; set; }
        public virtual DbSet<CONSECUTIVO_AEROLINEA> CONSECUTIVO_AEROLINEA { get; set; }
        public virtual DbSet<CONSECUTIVO_PAIS> CONSECUTIVO_PAIS { get; set; }
        public virtual DbSet<CONSECUTIVO_PUERTA> CONSECUTIVO_PUERTA { get; set; }
        public virtual DbSet<CONSECUTIVO_VUELO> CONSECUTIVO_VUELO { get; set; }
        public virtual DbSet<ERROR> ERROR { get; set; }
        public virtual DbSet<IMAGEN_AEROLINEA> IMAGEN_AEROLINEA { get; set; }
        public virtual DbSet<IMAGEN_PAIS> IMAGEN_PAIS { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<PUERTA> PUERTA { get; set; }
        public virtual DbSet<RESERVAR_BOLETO> RESERVAR_BOLETO { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<TARJETA> TARJETA { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<VUELO_LLEGADA> VUELO_LLEGADA { get; set; }
        public virtual DbSet<VUELO_SALIDA> VUELO_SALIDA { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
