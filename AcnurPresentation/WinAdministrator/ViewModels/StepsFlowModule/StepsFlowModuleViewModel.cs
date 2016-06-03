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
    /// Represents the single StepsFlowModule object view model.
    /// </summary>
    public partial class StepsFlowModuleViewModel : SingleObjectViewModel<StepsFlowModule, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StepsFlowModuleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StepsFlowModuleViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StepsFlowModuleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StepsFlowModuleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StepsFlowModuleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StepsFlowModuleViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StepsFlowModule, x => x.IdStepFlowModule)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of Modules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Modules> LookUpModules
        {
            get { return GetLookUpEntitiesViewModel((StepsFlowModuleViewModel x) => x.LookUpModules, x => x.Modules); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of StepsFlow for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<StepsFlow> LookUpStepsFlow
        {
            get { return GetLookUpEntitiesViewModel((StepsFlowModuleViewModel x) => x.LookUpStepsFlow, x => x.StepsFlow); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of StepsFlowModuleUser for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<StepsFlowModuleUser> LookUpStepsFlowModuleUser
        {
            get { return GetLookUpEntitiesViewModel((StepsFlowModuleViewModel x) => x.LookUpStepsFlowModuleUser, x => x.StepsFlowModuleUser); }
        }


        /// <summary>
        /// The view model for the StepsFlowModuleStepsFlowModuleUser detail collection.
        /// </summary>
        public CollectionViewModel<StepsFlowModuleUser, int, IACNUREntitiesUnitOfWork> StepsFlowModuleStepsFlowModuleUserDetails
        {
            get { return GetDetailsCollectionViewModel((StepsFlowModuleViewModel x) => x.StepsFlowModuleStepsFlowModuleUserDetails, x => x.StepsFlowModuleUser, x => x.IdStepFlowModule, (x, key) => { x.IdStepFlowModule = key; }); }
        }
    }
}
