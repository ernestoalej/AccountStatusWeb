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
    
    public partial class tClientUSA
    {
        public int idClientUSA { get; set; }
        public Nullable<int> idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
        public string contactoAdm { get; set; }
        public string telefonoAdm { get; set; }
        public string emailAdm { get; set; }
        public string contactoTecnico { get; set; }
        public string telefonoTecnico { get; set; }
        public string emailTecnico { get; set; }
        public string RUC { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<int> idVendedor { get; set; }
        public string estado { get; set; }
        public string nombreQuickBook { get; set; }
        public string tipoFacturacion { get; set; }
        public string cantFacturas { get; set; }
        public string terms { get; set; }
        public Nullable<int> meses { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<int> createdBy { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public Nullable<int> updatedBy { get; set; }
    }
}
