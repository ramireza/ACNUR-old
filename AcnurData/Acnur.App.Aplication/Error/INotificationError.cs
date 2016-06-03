// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 14-10-2015
// ***********************************************************************
// <copyright file="INotificacionError.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Interface que define el método para notificar el error en la capa de presentación.</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Error
{
    using Acnur.App.Entities;

    /// <summary>
    /// Interface que define el método para notificar el error en la capa de presentación.
    /// </summary>
    public interface INotificationError
    {
        /// <summary>
        /// Método que despliega el mensaje de error en la capa de presentación.
        /// </summary>
        /// <param name="mensajeError">Mensaje de error que se va a desplegar en la capa de presentación.</param>
        void MostrarMensajeError(DetailError mensajeError);
    }
}
