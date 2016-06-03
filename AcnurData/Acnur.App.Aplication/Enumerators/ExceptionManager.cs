// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 14-10-2015
// ***********************************************************************
// <copyright file="CapaManejoExcepcion.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para el Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Enumeración para especificar la capa en la cual se detecta una excepción generada por la aplicación.</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Enumerators
{
    /// <summary>
    /// Enumeración para especificar la capa en la cual se detecta una excepción generada por la aplicación.
    /// </summary>
    public enum ExceptionManager
    {
        /// <summary>
        /// Valor no definido.
        /// </summary>
        NoDefinido,

        /// <summary>
        /// Excepción manejada en la capa de presentación.
        /// </summary>
        Presentacion,

        /// <summary>
        /// Excepción manejada en la capa de servicios.
        /// </summary>
        Servicios,

        /// <summary>
        /// Excepción manejada en la capa de dominio.
        /// </summary>
        Dominio,

        /// <summary>
        /// Excepción manejada en la capa de infraestructura.
        /// </summary>
        Infraestructura
    } 
}
