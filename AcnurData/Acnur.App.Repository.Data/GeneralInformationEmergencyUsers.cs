//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class GeneralInformationEmergencyUsers
    {
        public int IdGeneralInformationEmergencyUser { get; set; }
        public int IdGeneralInformationEmergency { get; set; }
        public int IdUser { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual GeneralInformationEmergency GeneralInformationEmergency { get; set; }
    }
}
