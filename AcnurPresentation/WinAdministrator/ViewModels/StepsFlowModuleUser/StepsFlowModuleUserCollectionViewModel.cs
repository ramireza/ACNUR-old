using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using WinAdministrator.Common.Utils;
using WinAdministrator.ACNUREntitiesDataModel;
using WinAdministrator.Common.DataModel;
using Acnur.App.Repository.Data;
using WinAdministrator.Common.ViewModel;

namespace WinAdministrator.ViewModels
{
    /// <summary>
    /// Represents the StepsFlowModuleUser collection view model.
    /// </summary>
    public partial class StepsFlowModuleUserCollectionViewModel : CollectionViewModel<StepsFlowModuleUser, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StepsFlowModuleUserCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StepsFlowModuleUserCollectionViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StepsFlowModuleUserCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StepsFlowModuleUserCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StepsFlowModuleUserCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StepsFlowModuleUserCollectionViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StepsFlowModuleUser)
        {
        }
    }
}