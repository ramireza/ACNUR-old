// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 14-10-2015
// ***********************************************************************
// <copyright file="AdministrarExcepcion.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase que realiza el registro de la excepción atrapada.</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Error
{
    using System;
    using System.Configuration;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Text;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;

    public static class ManagerException
    {
        #region "Metodos publicos"

        /// <summary>
        /// Crea objeto detalle error
        /// </summary>
        /// <param name="ex">Excepcion generada</param>
        /// <param name="nombreObjeto">Objeto en donde se genero excepcion</param>
        /// <param name="nombreMetodo">Nombre metodo en donde se genero excepcion</param>
        /// <param name="usuario">Usuario que ejecuto la accion</param>
        /// <param name="capaManejoExcepcion">Capa en la que se presento la excepcion</param>
        /// <returns>DTO detalle error</returns>
        public static DetailError CrearDetalleError(Exception ex, string nombreObjeto, string nombreMetodo, string usuario, ExceptionManager capaManejoExcepcion)
        {
            DetailError detError = new DetailError()
            {
                Error = ex.Message.ToString(),
                Fecha = DateTime.Now,
                Traza = ex.ToString(),
                Objeto = nombreObjeto,
                Metodo = nombreMetodo,
                Usuario = usuario,
                CapaManejoExcepcion = capaManejoExcepcion.ToString()
            };
            return detError;
        }

        /// <summary>
        /// Metodo que registra los errores generados en la aplicacion.
        /// </summary>
        /// <param name="infoError">Objeto que contiene la información del error que se va a registrar.</param>
        public static void RegistrarError(DetailError infoError)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string fuente = "Defensoria.Sisat";
                string logWindows = "Application";

                infoError.IP = Utilities.ObtenerDireccionIP();
                sb.AppendLine("Reporte Generado el: " + infoError.Fecha.ToString());
                sb.AppendLine();
                sb.AppendLine("IP que ejecuta proceso: " + infoError.IP.ToString());
                sb.AppendLine();
                sb.AppendLine("No se pudo reportar al repositorio central");
                sb.AppendLine("Debido a lo siguiente:");
                sb.AppendLine(infoError.Error);
                sb.AppendLine();
                sb.AppendLine(string.Format("Capa:{0}", infoError.CapaManejoExcepcion));
                sb.AppendLine();
                sb.AppendLine(string.Format("Objeto:{0}", infoError.Objeto));
                sb.AppendLine();
                sb.AppendLine(string.Format("Método:{0}", infoError.Metodo));
                sb.AppendLine();
                sb.AppendLine("El detalle del error es:");
                sb.AppendLine();
                sb.AppendLine(infoError.Traza);

                if (EventLog.SourceExists(fuente) == false)
                {
                    EventLog.CreateEventSource(fuente, logWindows);
                }

                EventLog.WriteEntry(fuente, sb.ToString(), EventLogEntryType.Error);
            }
            catch (Exception)
            {
                RegistraErrorBlockNotas(infoError);
            }
        }

        #endregion "Metodos publicos"

        #region "Metodos Privados"

        /// <summary>
        /// Metodo para almacenar error en block de notas
        /// </summary>
        /// <param name="infoError">Objeto con detalle del error</param>
        private static void RegistraErrorBlockNotas(DetailError infoError)
        {
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["logError"], true))
            {
                writer.WriteLine();
                writer.WriteLine("****************************************************************************");
                writer.WriteLine();
                writer.WriteLine("Reporte Generado el: " + infoError.Fecha.ToString());
                writer.WriteLine();
                writer.WriteLine("IP que ejecuta proceso: " + infoError.IP.ToString());
                writer.WriteLine();
                writer.WriteLine("No se pudo reportar al repositorio central");
                writer.WriteLine("Debido a lo siguiente:");
                writer.WriteLine();
                writer.WriteLine(infoError.Error);
                writer.WriteLine();
                writer.WriteLine(string.Format("Capa:{0}", infoError.CapaManejoExcepcion));
                writer.WriteLine();
                writer.WriteLine(string.Format("Objeto:{0}", infoError.Objeto));
                writer.WriteLine();
                writer.WriteLine(string.Format("Método:{0}", infoError.Metodo));
                writer.WriteLine();
                writer.WriteLine("El detalle del error es:");
                writer.WriteLine();
                writer.WriteLine(infoError.Traza);
            }
        }

        #endregion "Metodos Privados"
    }
}
