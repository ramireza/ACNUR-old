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
    
    public partial class Request
    {
        public Request()
        {
            this.Events = new HashSet<Events>();
            this.Goods = new HashSet<Goods>();
            this.Services = new HashSet<Services>();
        }
    
        public int IdRequest { get; set; }
        public int IdRequestUnit { get; set; }
        public string RequesterPerson { get; set; }
        public string DutyStation { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string Responsible { get; set; }
        public string BackgroundRationale { get; set; }
        public string DeliveryLocation { get; set; }
        public System.DateTime EstimatedDeliveryDate { get; set; }
        public bool Active { get; set; }
    
        public virtual ParameterDetail ParameterDetail { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<Goods> Goods { get; set; }
        public virtual ICollection<Services> Services { get; set; }
    }
}