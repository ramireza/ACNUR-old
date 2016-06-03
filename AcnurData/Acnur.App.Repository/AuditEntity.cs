// ***********************************************************************
// Assembly         : Acnur.App.Repository
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 15-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 15-10-2015
// ***********************************************************************
// <copyright file="AuditoriaEntidad.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Archivo de clase que realiza el registro de la excepción atrapada</summary>
// ***********************************************************************

namespace Acnur.App.Repository
{
    using System;
    using Acnur.App.Aplication;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;

    /// <summary>
    /// Clase generica utilizada para retornar un objeto por si key
    /// </summary>
    public class AuditEntity
    {
        #region "Atributos"

        /// <summary>
        /// Objeto a auditar
        /// </summary>
        private object objectAudit;

        /// <summary>
        /// Objeto a auditar original
        /// </summary>
        private object objectAuditOriginal;

        /// <summary>
        /// Atributo para propiedades de entidades que no se deben comparar
        /// </summary>
        private string[] propiedadesOmitir = { "FechaModificacion", "Usuario" };

        #endregion "Atributos"

        #region "Constructores"

        /// <summary>
        /// Constructor con objeto entrante
        /// </summary>
        /// <param name="entidadAuditar">Objeto que entra para ser auditado</param>
        public AuditEntity(object entidadAuditar)
        {
            this.objectAudit = entidadAuditar;
            this.LogAuditoria = new Audit()
            {
                IPAdress = string.Empty,
                EntityAfter = new byte[]
                { 
                },
                EntityBefore = new byte[] 
                {
                },
                ModificationDate = DateTime.Now,
                IdProcessEntity = 0,
                IdKeyConsult = string.Empty,
                IdKeyEntity = 0,
                IdAudit = 0,
                IdUser = 0,
                Operation = string.Empty,
                Users = new Users()
            };

            this.NombreEntidad = this.objectAudit == null ? string.Empty : this.objectAudit.GetType().Name;
        }

        /// <summary>
        /// Constructor con objeto entrante
        /// </summary>
        /// <param name="entidadAuditar">Objeto que entra para ser auditado</param>
        /// <param name="context">Contexto transaccional</param>
        public AuditEntity(object entidadAuditar, RepositoryData context)
        {
            this.objectAudit = entidadAuditar;
            this.LogAuditoria = new Audit()
            {
                IPAdress = string.Empty,
                EntityAfter = new byte[]
                { 
                },
                EntityBefore = new byte[] 
                {
                },
                ModificationDate = DateTime.Now,
                IdProcessEntity = 0,
                IdKeyConsult = string.Empty,
                IdKeyEntity = 0,
                IdAudit = 0,
                IdUser = 0,
                Operation = string.Empty,
                Users = new Users()
            };

            this.Repositorio = context;
            this.NombreEntidad = this.objectAudit == null ? string.Empty : this.objectAudit.GetType().Name;
            this.EsTransaccion = true;
        }

        #endregion "Constructores"

        #region "Propiedades"

        /// <summary>
        /// Get's or set propiedad que contiene la información de la auditoria
        /// </summary>
        public Audit LogAuditoria { get; set; }

        /// <summary>
        /// Get's or set propiedad Nombre de la entidad
        /// </summary>
        public string NombreEntidad { get; set; }

        /// <summary>
        /// Get's or set propiedad para identificar cual es el recurso de la entidad a auditar
        /// </summary>
        public ParameterDetail ParametroAuditoria { get; set; }

        /// <summary>
        /// Get's or set de propiedad para identificar si se esta auditando en transacción
        /// </summary>
        public bool EsTransaccion { get; set; }

        /// <summary>
        /// Atributo contexto para operaciones con transacción
        /// </summary>
        public RepositoryData Repositorio { get; set; }

        /// <summary>
        /// Gets or sets para propiedad que identifica si existe alguna diferencia en la entidad modificada a auditar.
        /// </summary>
        public bool EsIgual { get; set; }

        #endregion "Propiedades"

        #region "Metodos Publicos"

        /// <summary>
        /// Metodo para obtener la entidad a la que se realizara auditoria
        /// </summary>
        public void SetEntidadAuditarOriginal()
        {
            this.objectAuditOriginal = RepositoryData.GetEntityXObject(this.objectAudit);
            this.EsIgual = Utilities.SonIguales(this.objectAudit, this.objectAuditOriginal, this.propiedadesOmitir);
        }

        /// <summary>
        /// Metodo que inserta log de auditoria
        /// </summary>
        public void InsertarLogAuditoria()
        {
            if (this.Repositorio != null)
            {
                this.Repositorio.AddTransaction<Audit>(this.LogAuditoria);
            }
            else
            {
                RepositoryData.Add<Audit>(this.LogAuditoria);
            }
        }

        /// <summary>
        /// Método que agrega los valores correspondientes al log de auditoría
        /// </summary>
        /// <param name="operacion">Valor que identifica operación que se está realizando</param>
        public void SetLogAuditar(string operacion)
        {
            this.LogAuditoria.EntityBefore = this.objectAuditOriginal != null ? Utilities.SerializarXML(this.objectAuditOriginal) : new byte[] { };
            this.LogAuditoria.EntityAfter = this.objectAudit != null ? Utilities.SerializarXML(this.objectAudit) : new byte[] { };
            this.LogAuditoria.ModificationDate = DateTime.Now;
            this.LogAuditoria.Operation = operacion;
            this.LogAuditoria.IdProcessEntity = (int)this.ParametroAuditoria.Ordinal;
            this.LogAuditoria.Users = null;
        }

        #endregion "Metodos Publicos"
    }
}
