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
    
    public partial class tReportMessage
    {
        public int idReportMessage { get; set; }
        public Nullable<short> idReport { get; set; }
        public Nullable<byte> messageType { get; set; }
        public string message { get; set; }
        public byte idStatus { get; set; }
        public System.DateTime createdAt { get; set; }
        public short createdBy { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public Nullable<short> updatedBy { get; set; }
    
        public virtual tReport tReport { get; set; }
    }
}
