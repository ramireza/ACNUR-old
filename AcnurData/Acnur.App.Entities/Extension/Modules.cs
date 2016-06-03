// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 03-17-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 03-17-2016
// ***********************************************************************
// <copyright file="Modules.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************


/// <summary>
/// The Extension namespace.
/// </summary>
namespace Acnur.App.Entities
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Class Modules.
    /// </summary>
    public partial class Modules
    {
        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>The picture.</value>
        [DataMember]
        public System.Drawing.Image Picture { get; set; }
    }
}
