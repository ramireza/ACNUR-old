using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WinAdministrator.Common.Utils;
using WinAdministrator.ACNUREntitiesDataModel;
using WinAdministrator.Common.DataModel;
using Acnur.App.Repository.Data;
using WinAdministrator.Common.ViewModel;

namespace WinAdministrator.ViewModels
{
    /// <summary>
    /// Represents the single Modules object view model.
    /// </summary>
    public partial class ModulesViewModel : SingleObjectViewModel<Modules, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ModulesViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ModulesViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ModulesViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ModulesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ModulesViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ModulesViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Modules, x => x.ModuleName)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of ComponentsByModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ComponentsByModule> LookUpComponentsByModule
        {
            get { return GetLookUpEntitiesViewModel((ModulesViewModel x) => x.LookUpComponentsByModule, x => x.ComponentsByModule); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ModuleUser for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ModuleUser> LookUpModuleUser
        {
            get { return GetLookUpEntitiesViewModel((ModulesViewModel x) => x.LookUpModuleUser, x => x.ModuleUser); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of OperationsModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OperationsModule> LookUpOperationsModule
        {
            get { return GetLookUpEntitiesViewModel((ModulesViewModel x) => x.LookUpOperationsModule, x => x.OperationsModule); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of StepsFlowModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<StepsFlowModule> LookUpStepsFlowModule
        {
            get { return GetLookUpEntitiesViewModel((ModulesViewModel x) => x.LookUpStepsFlowModule, x => x.StepsFlowModule); }
        }


        /// <summary>
        /// The view model for the ModulesComponentsByModule detail collection.
        /// </summary>
        public CollectionViewModel<ComponentsByModule, int, IACNUREntitiesUnitOfWork> ModulesComponentsByModuleDetails
        {
            get { return GetDetailsCollectionViewModel((ModulesViewModel x) => x.ModulesComponentsByModuleDetails, x => x.ComponentsByModule, x => x.IdModule, (x, key) => { x.IdModule = key; }); }
        }

        /// <summary>
        /// The view model for the ModulesModuleUser detail collection.
        /// </summary>
        public CollectionViewModel<ModuleUser, int, IACNUREntitiesUnitOfWork> ModulesModuleUserDetails
        {
            get { return GetDetailsCollectionViewModel((ModulesViewModel x) => x.ModulesModuleUserDetails, x => x.ModuleUser, x => x.IdModule, (x, key) => { x.IdModule = key; }); }
        }

        /// <summary>
        /// The view model for the ModulesOperationsModule detail collection.
        /// </summary>
        public CollectionViewModel<OperationsModule, int, IACNUREntitiesUnitOfWork> ModulesOperationsModuleDetails
        {
            get { return GetDetailsCollectionViewModel((ModulesViewModel x) => x.ModulesOperationsModuleDetails, x => x.OperationsModule, x => x.IdModule, (x, key) => { x.IdModule = key; }); }
        }

        /// <summary>
        /// The view model for the ModulesStepsFlowModule detail collection.
        /// </summary>
        public CollectionViewModel<StepsFlowModule, int, IACNUREntitiesUnitOfWork> ModulesStepsFlowModuleDetails
        {
            get { return GetDetailsCollectionViewModel((ModulesViewModel x) => x.ModulesStepsFlowModuleDetails, x => x.StepsFlowModule, x => x.IdModule, (x, key) => { x.IdModule = key; }); }
        }
    }
}
