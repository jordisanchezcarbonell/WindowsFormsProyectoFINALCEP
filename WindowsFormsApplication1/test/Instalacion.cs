//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMPLETE_FLAT_UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instalacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instalacion()
        {
            this.Espacio = new HashSet<Espacio>();
            this.Instalacion_Horario = new HashSet<Instalacion_Horario>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int id_tipo_gestion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Espacio> Espacio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instalacion_Horario> Instalacion_Horario { get; set; }
        public virtual Tipo_gestion Tipo_gestion { get; set; }
    }
}
