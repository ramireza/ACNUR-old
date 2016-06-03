// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 15-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 15-10-2015
// ***********************************************************************
// <copyright file="Utilidades.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase para utilidades varias</summary>
// ***********************************************************************

namespace Acnur.App.Entities
{
    using System.Runtime.Serialization;

    public partial class Users
    {
        /// <summary>
        /// Gets or Sets
        /// Obtiene y asigna la IP del Usuario
        /// </summary>
        [DataMember]
        public string IP { get; set; }
    }
}
