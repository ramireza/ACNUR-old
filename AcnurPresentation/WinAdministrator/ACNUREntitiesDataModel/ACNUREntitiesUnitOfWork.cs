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
    /// A ACNUREntitiesUnitOfWork instance that represents the run-time implementation of the IACNUREntitiesUnitOfWork interface.
    /// </summary>
    public class ACNUREntitiesUnitOfWork : DbUnitOfWork<ACNUREntities>, IACNUREntitiesUnitOfWork
    {

        public ACNUREntitiesUnitOfWork(Func<ACNUREntities> contextFactory)
            : base(contextFactory)
        {
        }

        IRepository<ComponentsByModule, int> IACNUREntitiesUnitOfWork.ComponentsByModule
        {
            get { return GetRepository(x => x.Set<ComponentsByModule>(), (ComponentsByModule x) => x.IdComponentByModule); }
        }

        IRepository<Modules, int> IACNUREntitiesUnitOfWork.Modules
        {
            get { return GetRepository(x => x.Set<Modules>(), (Modules x) => x.IdModule); }
        }

        IRepository<ModuleUser, int> IACNUREntitiesUnitOfWork.ModuleUser
        {
            get { return GetRepository(x => x.Set<ModuleUser>(), (ModuleUser x) => x.IdModuleUser); }
        }

        IRepository<Operations, int> IACNUREntitiesUnitOfWork.Operations
        {
            get { return GetRepository(x => x.Set<Operations>(), (Operations x) => x.IdOperation); }
        }

        IRepository<OperationsModule, int> IACNUREntitiesUnitOfWork.OperationsModule
        {
            get { return GetRepository(x => x.Set<OperationsModule>(), (OperationsModule x) => x.IdOperationModule); }
        }

        IRepository<OperationsModuleUser, int> IACNUREntitiesUnitOfWork.OperationsModuleUser
        {
            get { return GetRepository(x => x.Set<OperationsModuleUser>(), (OperationsModuleUser x) => x.IdOperationModuleUser); }
        }

        IRepository<Parameter, int> IACNUREntitiesUnitOfWork.Parameter
        {
            get { return GetRepository(x => x.Set<Parameter>(), (Parameter x) => x.IdParameter); }
        }

        IRepository<ParameterDetail, int> IACNUREntitiesUnitOfWork.ParameterDetail
        {
            get { return GetRepository(x => x.Set<ParameterDetail>(), (ParameterDetail x) => x.IdParameterDetail); }
        }

        IRepository<StepsFlow, int> IACNUREntitiesUnitOfWork.StepsFlow
        {
            get { return GetRepository(x => x.Set<StepsFlow>(), (StepsFlow x) => x.IdStepFlow); }
        }

        IRepository<StepsFlowModule, int> IACNUREntitiesUnitOfWork.StepsFlowModule
        {
            get { return GetRepository(x => x.Set<StepsFlowModule>(), (StepsFlowModule x) => x.IdStepFlowModule); }
        }

        IRepository<StepsFlowModuleUser, int> IACNUREntitiesUnitOfWork.StepsFlowModuleUser
        {
            get { return GetRepository(x => x.Set<StepsFlowModuleUser>(), (StepsFlowModuleUser x) => x.IdStepFlowModuleUser); }
        }

        IRepository<Users, int> IACNUREntitiesUnitOfWork.Users
        {
            get { return GetRepository(x => x.Set<Users>(), (Users x) => x.IdUser); }
        }
    }
}
