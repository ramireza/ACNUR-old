//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// DTO TabCuenta
    /// </summary>
    [System.Runtime.Serialization.DataContract(IsReference=true)]
    [Serializable]
    public partial class PT8
    {
    	/// <summary>
        /// Constructor PT8
        /// </summary>
        public PT8()
        {
            this.SatffInformation = new HashSet<SatffInformation>();
        }
    
    
    	/// <summary>
        /// Atributo IdPT8
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdPT8 { get; set; }
    
    	/// <summary>
        /// Atributo IdAuthor
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdAuthor { get; set; }
    
    	/// <summary>
        /// Atributo IdOffice
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdOffice { get; set; }
    
    	/// <summary>
        /// Atributo IdUnit
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdUnit { get; set; }
    
    	/// <summary>
        /// Atributo DatePT8
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public System.DateTime DatePT8 { get; set; }
    
    	/// <summary>
        /// Atributo PT8Id
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int PT8Id { get; set; }
    
    	/// <summary>
        /// Atributo AditionalDate
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public System.DateTime AditionalDate { get; set; }
    
    	/// <summary>
        /// Atributo PreparedBy
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string PreparedBy { get; set; }
    
    	/// <summary>
        /// Atributo RegisterAdded
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int RegisterAdded { get; set; }
    
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail1
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail1 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ParameterDetail2
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail2 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion SatffInformation
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ICollection<SatffInformation> SatffInformation { get; set; }
    }
}