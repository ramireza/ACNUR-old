// ***********************************************************************
// Assembly         : Acnur.App.Entities
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 14-10-2015
// ***********************************************************************
// <copyright file="DetalleError.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para el Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Archivo de manejo de error.</summary>
// ***********************************************************************

namespace Acnur.App.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;

    /// <summary>
    /// Entidad que representa el detalle de un error.
    /// </summary>
    [DataContract]
    public class DetailError
    {
        /// <summary>
        /// Mensaje Amigable al usuario
        /// </summary>
        public string MensajeAmigable;

        /// <summary>
        /// Constructor basado en el error que entra por parametro
        /// </summary>
        /// <param name="exepcionEntra">Error de entrada</param>
        public DetailError(DetailError exepcionEntra)
        {
            this.Fecha = exepcionEntra.Fecha;
            this.IP = exepcionEntra.IP;
            this.Metodo = exepcionEntra.Metodo;
            this.Objeto = exepcionEntra.Objeto;
            this.Traza = exepcionEntra.Traza;
            this.Usuario = exepcionEntra.Usuario;
            this.Error = exepcionEntra.Error;
            this.CapaManejoExcepcion = exepcionEntra.CapaManejoExcepcion;
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public DetailError()
        {
        }

        /// <summary>
        /// Fecha y hora en la cual se presento el error
        /// </summary>
        /// <value>The fecha.</value>
        [DataMember]
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Usuario que estaba autenticado cuando se presento el error
        /// </summary>
        /// <value>The usuario.</value>
        [DataMember]
        public string Usuario { get; set; }

        /// <summary>
        /// IP de la maquina en la que se presento el error
        /// </summary>
        /// <value>The ip.</value>
        [DataMember]
        public string IP { get; set; }

        /// <summary>
        /// Mensaje de error. Corresponde con ex.Message
        /// </summary>
        /// <value>The error.</value>
        [DataMember]
        public string Error { get; set; }

        /// <summary>
        /// Detalle del error que se presento. Corresponde con el ex.ToString()
        /// </summary>
        /// <value>The traza.</value>
        [DataMember]
        public string Traza { get; set; }

        /// <summary>
        /// Capa donde se realiza el manejo de la excepción.
        /// </summary>
        /// <value>The capa manejo excepcion.</value>
        [DataMember]
        public string CapaManejoExcepcion { get; set; }

        /// <summary>
        /// Nombre del objeto donde se genera la excepción.
        /// </summary>
        /// <value>The objeto.</value>
        [DataMember]
        public string Objeto { get; set; }

        /// <summary>
        /// Nombre del método donde se genera la excepción.
        /// </summary>
        /// <value>The metodo.</value>
        [DataMember]
        public string Metodo { get; set; }
    }
}
