//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Vuelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vuelos()
        {
            this.Boleto = new HashSet<Boleto>();
            this.Reservacion = new HashSet<Reservacion>();
        }
    
        public int id_vuelo { get; set; }
        public Nullable<System.DateTime> fecha_vuelo { get; set; }
        public string hora_vuelo { get; set; }
        public string tiempo_vuelo { get; set; }
        public string distancia_vuelo { get; set; }
        public Nullable<int> id_avion { get; set; }
        public Nullable<int> id_ruta { get; set; }
    
        public virtual Avion Avion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boleto> Boleto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservacion> Reservacion { get; set; }
        public virtual Ruta Ruta { get; set; }
    }
}