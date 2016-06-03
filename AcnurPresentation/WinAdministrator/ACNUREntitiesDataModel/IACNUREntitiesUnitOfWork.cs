using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using WinAdministrator.Common.Utils;
using WinAdministrator.Common.DataModel;
using WinAdministrator.Common.DataModel.EntityFramework;
using Acnur.App.Repository.Data;

namespace WinAdministrator.ACNUREntitiesDataModel
{
    /// <summary>
    /// IACNUREntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IACNUREntitiesUnitOfWork : IUnitOfWork
    {

        /// <summary>
        /// The ComponentsByModule entities repository.
        /// </summary>
        IRepository<ComponentsByModule, int> ComponentsByModule { get; }

        /// <summary>
        /// The Modules entities repository.
        /// </summary>
        IRepository<Modules, int> Modules { get; }

        /// <summary>
        /// The ModuleUser entities repository.
        /// </summary>
        IRepository<ModuleUser, int> ModuleUser { get; }

        /// <summary>
        /// The Operations entities repository.
        /// </summary>
        IRepository<Operations, int> Operations { get; }

        /// <summary>
        /// The OperationsModule entities repository.
        /// </summary>
        IRepository<OperationsModule, int> OperationsModule { get; }

        /// <summary>
        /// The OperationsModuleUser entities repository.
        /// </summary>
        IRepository<OperationsModuleUser, int> OperationsModuleUser { get; }

        /// <summary>
        /// The Parameter entities repository.
        /// </summary>
        IRepository<Parameter, int> Parameter { get; }

        /// <summary>
        /// The ParameterDetail entities repository.
        /// </summary>
        IRepository<ParameterDetail, int> ParameterDetail { get; }

        /// <summary>
        /// The StepsFlow entities repository.
        /// </summary>
        IRepository<StepsFlow, int> StepsFlow { get; }

        /// <summary>
        /// The StepsFlowModule entities repository.
        /// </summary>
        IRepository<StepsFlowModule, int> StepsFlowModule { get; }

        /// <summary>
        /// The StepsFlowModuleUser entities repository.
        /// </summary>
        IRepository<StepsFlowModuleUser, int> StepsFlowModuleUser { get; }

        /// <summary>
        /// The Users entities repository.
        /// </summary>
        IRepository<Users, int> Users { get; }
    }
}
