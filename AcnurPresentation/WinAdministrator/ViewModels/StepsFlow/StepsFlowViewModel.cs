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
    /// Represents the single StepsFlow object view model.
    /// </summary>
    public partial class StepsFlowViewModel : SingleObjectViewModel<StepsFlow, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StepsFlowViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StepsFlowViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StepsFlowViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StepsFlowViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StepsFlowViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StepsFlowViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StepsFlow, x => x.Name)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of StepsFlowModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<StepsFlowModule> LookUpStepsFlowModule
        {
            get { return GetLookUpEntitiesViewModel((StepsFlowViewModel x) => x.LookUpStepsFlowModule, x => x.StepsFlowModule); }
        }


        /// <summary>
        /// The view model for the StepsFlowStepsFlowModule detail collection.
        /// </summary>
        public CollectionViewModel<StepsFlowModule, int, IACNUREntitiesUnitOfWork> StepsFlowStepsFlowModuleDetails
        {
            get { return GetDetailsCollectionViewModel((StepsFlowViewModel x) => x.StepsFlowStepsFlowModuleDetails, x => x.StepsFlowModule, x => x.IdStepFlow, (x, key) => { x.IdStepFlow = key; }); }
        }
    }
}
