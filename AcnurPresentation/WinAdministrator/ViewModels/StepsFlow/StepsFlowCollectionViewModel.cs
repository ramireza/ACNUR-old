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
    /// Represents the StepsFlow collection view model.
    /// </summary>
    public partial class StepsFlowCollectionViewModel : CollectionViewModel<StepsFlow, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of StepsFlowCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StepsFlowCollectionViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new StepsFlowCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StepsFlowCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StepsFlowCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StepsFlowCollectionViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.StepsFlow)
        {
        }
    }
}