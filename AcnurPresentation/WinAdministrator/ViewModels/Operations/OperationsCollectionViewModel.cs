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
    /// Represents the Operations collection view model.
    /// </summary>
    public partial class OperationsCollectionViewModel : CollectionViewModel<Operations, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of OperationsCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OperationsCollectionViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new OperationsCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OperationsCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OperationsCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OperationsCollectionViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Operations)
        {
        }
    }
}