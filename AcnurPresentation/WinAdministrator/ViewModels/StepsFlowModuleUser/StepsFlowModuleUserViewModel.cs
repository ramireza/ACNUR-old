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
    /// Represents the single StepsFlowModuleUser object view model.
    /// </summary>
    public partial class StepsFlowModuleUserViewModel : SingleObjectViewModel<StepsFlowModuleUser, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StepsFlowModuleUserViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StepsFlowModuleUserViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StepsFlowModuleUserViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StepsFlowModuleUserViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StepsFlowModuleUserViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StepsFlowModuleUserViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StepsFlowModuleUser, x => x.IdStepFlowModuleUser)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of StepsFlowModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<StepsFlowModule> LookUpStepsFlowModule
        {
            get { return GetLookUpEntitiesViewModel((StepsFlowModuleUserViewModel x) => x.LookUpStepsFlowModule, x => x.StepsFlowModule); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers
        {
            get { return GetLookUpEntitiesViewModel((StepsFlowModuleUserViewModel x) => x.LookUpUsers, x => x.Users); }
        }

    }
}
