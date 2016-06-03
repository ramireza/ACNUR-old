// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-25-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="Goods.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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
    /// Class Goods.
    /// </summary>
    public partial class Goods
    {
        /// <summary>
        /// Gets the unit measure.
        /// </summary>
        /// <value>The unit measure.</value>
        [DataMember]
        public string UnitMeasure
        {
            get
            {
                return this.ParameterDetail.Name;
            }
        }
    }
}
