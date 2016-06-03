// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-25-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="Events.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

/// <summary>
/// The Entities namespace.
/// </summary>
namespace Acnur.App.Entities
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Class Events.
    /// </summary>
    public partial class Events
    {
        /// <summary>
        /// Gets the type of the accommodation.
        /// </summary>
        /// <value>The type of the accommodation.</value>
        [DataMember]
        public string AccommodationType
        {
            get { return this.ParameterDetail.Name; }
        }
    }
}
