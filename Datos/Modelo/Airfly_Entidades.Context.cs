﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirFly_Modelo : DbContext
    {
        public AirFly_Modelo()
            : base("name=AirFly_Modelo")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aerolinea> Aerolinea { get; set; }
        public virtual DbSet<Aeropuerto> Aeropuerto { get; set; }
        public virtual DbSet<Asientos> Asientos { get; set; }
        public virtual DbSet<Avion> Avion { get; set; }
        public virtual DbSet<Boleto> Boleto { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Estado_pago> Estado_pago { get; set; }
        public virtual DbSet<Metodo_pago> Metodo_pago { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Pasajeros> Pasajeros { get; set; }
        public virtual DbSet<Paypal> Paypal { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Reservacion> Reservacion { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
        public virtual DbSet<Secciones> Secciones { get; set; }
        public virtual DbSet<Tarjeta> Tarjeta { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vuelos> Vuelos { get; set; }
    }
}
