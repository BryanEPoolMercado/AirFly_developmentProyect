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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Compra = new HashSet<Compra>();
        }
    
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidopat_usuario { get; set; }
        public string apellidomat_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string contraseña_usuario { get; set; }
        public Nullable<int> id_perfil { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compra { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
