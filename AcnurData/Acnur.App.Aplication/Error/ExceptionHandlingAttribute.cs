// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 14-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 14-10-2015
// ***********************************************************************
// <copyright file="AtributoManejoExcepcion.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Define las politicas de manejo de excepciones</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Error
{
    using System;
    using System.ServiceModel;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using PostSharp.Aspects;

    /// <summary>
    /// A custom attribute for exception handling purposes under an Aspect Oriented Programming paradigm.
    /// </summary>
    /// <remarks>It applies only to methods.</remarks>
    [Serializable]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Event | AttributeTargets.Interface, AllowMultiple = true, Inherited = false)]
    public sealed class ExceptionHandlingAttribute : OnExceptionAspect
    {
        #region "Atributos"

        /// <summary>
        /// Represents the exception handling politic to apply while intercepting with this concern.
        /// </summary>
        private ExceptionHandlingPolitic politica;

        /// <summary>
        /// Enumeración que indica la capa desde la caul se detecta la excepción.
        /// </summary>
        private ExceptionManager capaManejoExcepcion;

        #endregion "Atributos"

        #region "Metodos Publicos"

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionHandlingAttribute" /> class.
        /// </summary>
        /// <param name="politic">The exception handling politic to follow.</param>
        public ExceptionHandlingAttribute(ExceptionHandlingPolitic politic)
        {
            this.politica = politic;
        }

        /// <summary>
        /// Crea una uneva instancia de la clase <see cref="ExceptionHandlingAttribute" />.
        /// </summary>
        /// <param name="capaManejoExcepcion">Capa en la que se detecta la excepción.</param>
        public ExceptionHandlingAttribute(ExceptionManager capaManejoExcepcion)
        {
            this.capaManejoExcepcion = capaManejoExcepcion;
        }

        /// <summary>
        /// Gets el valor de la enumeración que indica la capa desde la cual se detecta la excepción.
        /// </summary>
        /// <value>Capa desde la cual se detecta la excepción.</value>
        public ExceptionManager CapaManejoExcepcion
        {
            get { return this.capaManejoExcepcion; }
        }

        /// <summary>
        /// Gets the specified exception handling politic.
        /// </summary>
        /// <value>Returns the politic to use when handling exceptions represented as a <see cref="ExceptionHandlingPolitic" />.</value>
        public ExceptionHandlingPolitic Politic
        {
            get { return this.politica; }
        }   

        /// <summary>
        /// Metodo para capturar la excepción
        /// </summary>
        /// <param name="args">Argumentos de Ejecución</param>
        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
            args.FlowBehavior = FlowBehavior.Continue;
            DetailError detError = null;
            DetailError detErrorPropagate = null;
            this.ControlTrazaError(args, ref detError, ref detErrorPropagate);
            this.EstrategiaPropagacionError(args, detError);
        }

        #endregion "Metodos Publicos"

        #region "Metodos Privados"

        /// <summary>
        /// Metodo para realizar la propagación ó retorno del error.
        /// </summary>
        /// <param name="args">Argumentos de Ejecución</param>
        /// <param name="detError">Objeto con traza del error</param>
        /// <exception cref="FaultException{DetalleError}"></exception>
        private void EstrategiaPropagacionError(MethodExecutionArgs args, DetailError detError)
        {
            var instanticia = args.Instance;
            ManagerException.RegistrarError(detError);

            if (this.CapaManejoExcepcion != ExceptionManager.Presentacion)
            {
                throw new FaultException<DetailError>(detError, detError.Error);
            }
            else
            {
                try
                {
                    if (HttpContext.Current != null)
                    {
                        if (detError.Traza.IndexOf("clave duplicada") > 0)
                        {
                            try
                            {
                                detError.MensajeAmigable = "Error, el dato: " + detError.Traza.Substring(detError.Traza.IndexOf("(") + 1, detError.Traza.IndexOf(")") - detError.Traza.IndexOf("(") - 1) + " ya se encuentra registrado";
                            }
                            catch (Exception)
                            {
                                detError.MensajeAmigable = "Error, se intentó registrar un valor duplicado";
                            }
                        }
                        else
                        {
                            detError.MensajeAmigable = "Estimado usuario ha ocurrido un error y en el momento no podemos procesar su solicitud, por favor intente más tarde.";
                        }

                        Page pagina = HttpContext.Current.Handler as Page;
                        INotificationError ejecutor = (INotificationError)pagina.Master;
                        ejecutor.MostrarMensajeError(detError);
                    }
                }
                catch (Exception)
                {
                    HttpContext.Current.Response.Redirect("~/Error.aspx", false);
                }
            }
        }

        /// <summary>
        /// Metodo para determinar si se sobreescribe o no el objeto que almacenara la traza del error
        /// </summary>
        /// <param name="args">Argumentos de Ejecución</param>
        /// <param name="detError">Objeto con traza de error entrante</param>
        /// <param name="detErrorPropagate">Objeto con traza de error original</param>
        private void ControlTrazaError(MethodExecutionArgs args, ref DetailError detError, ref DetailError detErrorPropagate)
        {
            System.Reflection.MethodBase metodoInvocado = args.Method;
            string nombreMetodo = metodoInvocado.Name;
            string nombreObjeto = metodoInvocado.DeclaringType.FullName;

            if (args.Exception.GetType() == typeof(FaultException<DetailError>))
            {
                detErrorPropagate = ((FaultException<DetailError>)args.Exception).Detail;
            }

            if (detErrorPropagate != null)
            {
                detError = detErrorPropagate;
            }
            else
            {
                detError = new DetailError()
                {
                    Error = args.Exception.Message.ToString(),
                    Fecha = DateTime.Now,
                    Traza = args.Exception.ToString(),
                    Objeto = nombreObjeto,
                    Metodo = nombreMetodo,
                    CapaManejoExcepcion = this.capaManejoExcepcion.ToString()
                };
            }
        }

        #endregion "Metodos Privados"
    }
}
