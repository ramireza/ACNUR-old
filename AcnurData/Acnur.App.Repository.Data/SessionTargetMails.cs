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
    
    public partial class SessionTargetMails
    {
        public SessionTargetMails()
        {
            this.SessionTargetMailProcessed = new HashSet<SessionTargetMailProcessed>();
        }
    
        public int IdSessionTargetMail { get; set; }
        public string TargetMail { get; set; }
        public int IdSession { get; set; }
    
        public virtual Sessions Sessions { get; set; }
        public virtual ICollection<SessionTargetMailProcessed> SessionTargetMailProcessed { get; set; }
    }
}
