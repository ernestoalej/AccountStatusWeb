//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountStatusWeb.ModelBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class tLogConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tLogConfig()
        {
            this.tReport = new HashSet<tReport>();
        }
    
        public byte idLogConfig { get; set; }
        public string path { get; set; }
        public string extension { get; set; }
        public string receiverAccount { get; set; }
        public string subject { get; set; }
        public byte idStatus { get; set; }
        public System.DateTime createdAt { get; set; }
        public short createdBy { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public Nullable<short> updatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tReport> tReport { get; set; }
    }
}
