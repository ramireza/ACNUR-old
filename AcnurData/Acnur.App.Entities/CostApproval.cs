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
    public partial class CostApproval
    {
    
    	/// <summary>
        /// Atributo IdCostApproval
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdCostApproval { get; set; }
    
    	/// <summary>
        /// Atributo IdItineraryInformation
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdItineraryInformation { get; set; }
    
    	/// <summary>
        /// Atributo IdCertifyingOffice
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdCertifyingOffice { get; set; }
    
    	/// <summary>
        /// Atributo IdTitle
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdTitle { get; set; }
    
    	/// <summary>
        /// Atributo AssignedAccount
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string AssignedAccount { get; set; }
    
    	/// <summary>
        /// Atributo Account
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string Account { get; set; }
    
    	/// <summary>
        /// Atributo VoucherNumber
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public string VoucherNumber { get; set; }
    
    	/// <summary>
        /// Atributo Value
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public double Value { get; set; }
    
    	/// <summary>
        /// Atributo IdCanceled
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdCanceled { get; set; }
    
    	/// <summary>
        /// Atributo IdLegalization
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public int IdLegalization { get; set; }
    
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
        /// Atributo de agregacion ParameterDetail3
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ParameterDetail ParameterDetail3 { get; set; }
    
    	/// <summary>
        /// Atributo de agregacion ItineraryInformation
        /// </summary>
    	[System.Runtime.Serialization.DataMember]
        public virtual ItineraryInformation ItineraryInformation { get; set; }
    }
}
