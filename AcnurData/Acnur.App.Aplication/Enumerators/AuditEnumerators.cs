// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 15-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 15-10-2015
// ***********************************************************************
// <copyright file="EnumeradosMetodosAuditoria.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Enumerador para la auditoría</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Enumerators
{
    public enum AuditEnumerators
    {
        /// <summary>
        /// Enumerado para aquellos metodos que no se auditaran
        /// </summary>
        Ninguno = 0,

        /// <summary>
        /// Enumerado para auditar metodo de inserción
        /// </summary>
        Add = 1,

        /// <summary>
        /// Enumerado para auditar metodo de eliminación
        /// </summary>
        Delete = 2,

        /// <summary>
        /// Enumerado para auditar metodo de actualización
        /// </summary>
        Update = 3,

        /// <summary>
        /// Enumerado para auditar metodo de commit transaction
        /// </summary>
        CommitTransaction = 4
    }
}
