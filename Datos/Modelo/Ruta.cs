//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ruta()
        {
            this.Vuelos = new HashSet<Vuelos>();
        }
    
        public int id_ruta { get; set; }
        public Nullable<decimal> distancia { get; set; }
        public string tiempo { get; set; }
        public Nullable<int> aeropuerto_origen { get; set; }
        public Nullable<int> aeropuerto_destino { get; set; }
        public string nombre_ruta { get; set; }
        public string nombre_ruta1 { get; set; }
    
        public virtual Aeropuerto Aeropuerto { get; set; }
        public virtual Aeropuerto Aeropuerto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vuelos> Vuelos { get; set; }
    }
}
