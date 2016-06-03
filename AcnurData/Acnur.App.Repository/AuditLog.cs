// ***********************************************************************
// Assembly         : Acnur.App.Repository
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 15-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 15-10-2015
// ***********************************************************************
// <copyright file="AuditoriaLog.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Archivo de clase que realiza el registro de la excepción atrapada</summary>
// ***********************************************************************

namespace Acnur.App.Repository
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using PostSharp;
    using PostSharp.Aspects;
    using Acnur.App.Aplication;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;

    /// <summary>
    /// Clase para estrategia de Logging con AOP
    /// </summary>
    /// <remarks>Aplicar solo a métodos de repositorio.</remarks>
    [Serializable]
    public sealed class AuditLog : OnMethodBoundaryAspect
    {
        #region "Atributos"

        /// <summary>
        /// Atributo constante para identificación de tabla de auditoria
        /// </summary>
        private const string TablaLog = "TabLog";

        /// <summary>
        /// Atributo para identificar que Método se esta auditando
        /// </summary>
        private AuditEnumerators methodAudit;

        /// <summary>
        /// Atributo para identificar cual es la entidad a auditar
        /// </summary>
        private object entidadEntra;

        /// <summary>
        /// Atributo que contiene lista de objetos agregados en transaction
        /// </summary>
        private List<object> objectsAdded = new List<object>();

        #endregion "Atributos"

        #region "Constructores"

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="method">Enumerado que indica el Método que entro por aspecto</param>
        public AuditLog(AuditEnumerators method)
        {
            this.methodAudit = method;
        }

        #endregion "Constructores"

        #region "Métodos Publicos"

        /// <summary>
        /// Método para interceptar la entrada en el Método Update
        /// </summary>
        /// <param name="args">Argumentos de ejecucion del Método a auditar</param>
        /// <exception cref="System.Exception">No existen headers</exception>
        public override void OnEntry(MethodExecutionArgs args)
        {
            AuditEntity entidadAuditar = null;

            if ((RepositoryData)args.Instance != null)
            {
                if (!((RepositoryData)args.Instance).Audit)
                {
                    return;
                }
            }

            entidadAuditar = this.SetEntidadAuditoria(args);

            if (!this.SetUserIp(entidadAuditar))
            {
                throw new Exception("No existen headers");
            }

            this.SetObjetoRecursoAuditar(entidadAuditar);

            if (this.methodAudit != AuditEnumerators.Update && this.methodAudit != AuditEnumerators.CommitTransaction)
            {
                return;
            }

            if (this.methodAudit.Equals(AuditEnumerators.CommitTransaction) && entidadAuditar.EsTransaccion)
            {
                this.SetListObjectsAdded(entidadAuditar);
            }
            else
            {
                this.ProcesarAuditoria(entidadAuditar, string.Empty);
            }
        }

        /// <summary>
        /// Método para interceptar la salida de los Métodos Add y Delete
        /// </summary>
        /// <param name="args">Argumentos de ejecucion del Método a auditar</param>
        /// <exception cref="System.Exception">No existen headers</exception>
        public override void OnSuccess(MethodExecutionArgs args)
        {
            ////Auditar entidades
            bool continuar = false;

            if ((RepositoryData)args.Instance != null)
            {
                if (!((RepositoryData)args.Instance).Audit)
                {
                    return;
                }
            }

            AuditEntity entidadAuditar = this.SetEntidadAuditoria(args);
            if (!this.SetUserIp(entidadAuditar))
            {
                throw new Exception("No existen headers");
            }

            if (this.methodAudit != AuditEnumerators.Update)
            {
                continuar = true;
            }

            if (this.methodAudit.Equals(AuditEnumerators.Add) && entidadAuditar.EsTransaccion)
            {
                continuar = false;
            }

            if (!continuar)
            {
                return;
            }

            this.SetObjetoRecursoAuditar(entidadAuditar);

            if (this.methodAudit.Equals(AuditEnumerators.CommitTransaction))
            {
                this.ProcesarAuditoriaTransaction(entidadAuditar);
            }
            else
            {
                this.ProcesarAuditoria(entidadAuditar, string.Empty);
            }
        }

        #endregion "Métodos Publicos"

        #region "Métodos Privados"

        /// <summary>
        /// Método que asigna el usuario e ip al log de auditoria
        /// </summary>
        /// <param name="entidadAuditar">Entidad que almacena la auditoria</param>
        /// <returns>Bool que indica si fue exitoso la asignación de usuario e ip</returns>
        private bool SetUserIp(AuditEntity entidadAuditar)
        {
            Users user = Acnur.App.Aplication.Security.Access.Usuario();

            if (user == null) return false;

            entidadAuditar.LogAuditoria.IdUser = user.IdUser;
            entidadAuditar.LogAuditoria.IPAdress = Utilities.ObtenerDireccionIP();

            return true;
        }

        /// <summary>
        /// Método que realiza el proceso de auditoria
        /// </summary>
        /// <param name="entidadAuditar">Entidad Audit</param>
        /// <param name="Método">Cadena que indica operación realizada</param>
        private void ProcesarAuditoria(AuditEntity entidadAuditar, string metodo)
        {
            if (this.AuditarTabla(entidadAuditar))
            {
                this.GrabarAuditoria(entidadAuditar, metodo);
            }
        }

        /// <summary>
        /// Método que realiza el proceso de auditoria
        /// </summary>
        /// <param name="entidadAuditar">Entidad Audit</param>
        private void ProcesarAuditoriaTransaction(AuditEntity entidadAuditar)
        {
            foreach (object objAdded in this.objectsAdded)
            {
                AuditEntity entAuditTransact = this.SetEntidadAuditoria(objAdded);
                this.SetObjetoRecursoAuditar(entAuditTransact);
                this.ProcesarAuditoria(entAuditTransact, "A");
            }

            this.objectsAdded = new List<object>();
        }

        /// <summary>
        /// Método que inicializa los objetos de auditoria y objeto a auditar
        /// </summary>
        /// <param name="args">Argumentos capturados en el aspecto</param>
        /// <returns>Retorna objeto de auditoria</returns>
        private AuditEntity SetEntidadAuditoria(MethodExecutionArgs args)
        {
            this.entidadEntra = args.Arguments.Count > 0 ? args.Arguments.GetArgument(0) : null;
            AuditEntity entidadAuditar = null;

            if ((RepositoryData)args.Instance != null)
            {
                entidadAuditar = new AuditEntity(this.entidadEntra, (RepositoryData)args.Instance);
            }
            else
            {
                entidadAuditar = new AuditEntity(this.entidadEntra);
            }

            return entidadAuditar;
        }

        /// <summary>
        /// Método que inicializa los objetos de auditoria y objeto a auditar
        /// </summary>
        /// <param name="entitieEntry">Entiti agregada al contexto transaccional</param>
        /// <returns>Retorna objeto de auditoria</returns>
        /// <exception cref="System.Exception">No existen headers</exception>
        private AuditEntity SetEntidadAuditoria(object entitieEntry)
        {
            this.entidadEntra = entitieEntry;
            AuditEntity entidadAuditar = null;
            entidadAuditar = new AuditEntity(this.entidadEntra);

            if (!this.SetUserIp(entidadAuditar))
            {
                throw new Exception("No existen headers");
            }

            return entidadAuditar;
        }

        /// <summary>
        /// Método que realiza proceso de grabado de auditoria
        /// </summary>
        /// <param name="entidadAuditar">Entidad a auditar</param>
        /// <param name="method">Cadena que indica operación realizada</param>
        private void GrabarAuditoria(AuditEntity entidadAuditar, string method)
        {
            this.SetValorLlavEntidad(entidadAuditar);
            this.SetValorLlaveConsulta(entidadAuditar);

            if (this.methodAudit == AuditEnumerators.Update)
            {
                entidadAuditar.SetEntidadAuditarOriginal();

                if (entidadAuditar.EsIgual)
                {
                    return;
                }
            }

            string MétodoAuditar = method == string.Empty ? this.methodAudit.ToString().Substring(0, 1) : method;
            entidadAuditar.SetLogAuditar(MétodoAuditar);
            entidadAuditar.InsertarLogAuditoria();
        }

        /// <summary>
        /// Método que identifica si la entidad que se esta modificando debe ser ó no auditada
        /// </summary>
        /// <param name="entidadAuditar">Entidad a auditar</param>
        /// <returns>Retorna Valor Boolean</returns>
        private bool AuditarTabla(AuditEntity entidadAuditar)
        {
            return entidadAuditar.ParametroAuditoria != null ? true : false;
        }

        /// <summary>
        /// Método que inicia el recurso que coincide con la entidad a auditar
        /// </summary>
        /// <param name="entidadAuditar">Nombre de entidad a auditar</param>
        private void SetObjetoRecursoAuditar(AuditEntity entidadAuditar)
        {
            int idAuditoria = (int)TypeParameter.Audit;
            List<ParameterDetail> detallesAuditoria = RepositoryData.Search<ParameterDetail>(det => det.IdParameter == idAuditoria, false, null);
            foreach (ParameterDetail item in detallesAuditoria)
            {
                if (item.Name.Equals(entidadAuditar.NombreEntidad))
                {
                    entidadAuditar.ParametroAuditoria = (ParameterDetail)item;
                    break;
                }
            }
        }

        /// <summary>
        /// Método que obtiene el valor del identificador de entidada a auditar
        /// Ojo este identificador debe ser númerico
        /// </summary>
        /// <param name="entidadAuditora">Objeto de auditoria</param>
        private void SetValorLlavEntidad(AuditEntity entidadAuditora)
        {
            var entitie = this.entidadEntra.GetType().GetProperty(entidadAuditora.ParametroAuditoria.Value1);
            entidadAuditora.LogAuditoria.IdKeyEntity = (int)entitie.GetValue(this.entidadEntra, null);
        }

        /// <summary>
        /// Método que asigna el valor de llave de consulta de la entidad auditada
        /// </summary>
        /// <param name="entidadAuditora">Objeto de auditoria</param>
        private void SetValorLlaveConsulta(AuditEntity entidadAuditora)
        {
            if (entidadAuditora.ParametroAuditoria.Value2 != null)
            {
                entidadAuditora.LogAuditoria.IdKeyConsult = Utilities.GetValueProperty(entidadAuditora.ParametroAuditoria.Value2, this.entidadEntra);
            }
        }

        /// <summary>
        /// Método que adiciona entities que fueron adicionadas en una transacción
        /// </summary>
        /// <param name="entAuditoria">Entidad de Audit</param>
        private void SetListObjectsAdded(AuditEntity entAuditoria)
        {
            foreach (System.Data.Entity.Infrastructure.DbEntityEntry item in entAuditoria.Repositorio.ContextTransaction.ChangeTracker.Entries())
            {
                if (item.State == System.Data.Entity.EntityState.Added && item.Entity.GetType().Name != TablaLog)
                {
                    object objAdded = item.Entity;
                    this.objectsAdded.Add(objAdded);
                }
            }
        }

        #endregion "Métodos Privados"
    }
}
