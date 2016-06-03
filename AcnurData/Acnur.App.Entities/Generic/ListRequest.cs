// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 12-14-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-14-2015
// ***********************************************************************
// <copyright file="ListRequest.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Entities
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Class ListRequest.
    /// </summary>
    public class ListRequest
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ListRequest"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool Active { get; set; }
    }
}
