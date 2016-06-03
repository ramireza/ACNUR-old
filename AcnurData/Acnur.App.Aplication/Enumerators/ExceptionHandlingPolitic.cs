// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 14-10-2015
// ***********************************************************************
// <copyright file="CapaPoliticaExcepcion.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Define las politicas de manejo de excepciones</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Enumerators
{
    /// <summary>
    /// Defines the exception handling politics to use.
    /// </summary>
    public enum ExceptionHandlingPolitic
    {
        /// <summary>
        /// Represents the propagation politic. 
        /// This politic specifies that every exception will be passed to the caller without any transformation.
        /// </summary>
        Propagate,

        /// <summary>
        /// Represents the wrap politic. 
        /// This politic specifies that every exception will be wrapped inside another exception and then passed to the caller.
        /// </summary>
        Wrap,

        /// <summary>
        /// Represents the replacement politic. 
        /// This politic specifies that every exception will be replaced for another exception; then the new exception will be passed to the caller.
        /// </summary>
        /// <remarks>
        /// The original exception will be lost.
        /// </remarks>
        Replace
    }
}
