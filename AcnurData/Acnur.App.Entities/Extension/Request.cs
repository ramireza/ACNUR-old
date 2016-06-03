// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-22-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="Request.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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
    /// Class Request.
    /// </summary>
    public partial class Request
    {
        /// <summary>
        /// Gets the request unit.
        /// </summary>
        /// <value>The request unit.</value>
        [DataMember]
        public string RequestUnit
        {
            get { return this.ParameterDetail.Name; }
        }
    }
}
