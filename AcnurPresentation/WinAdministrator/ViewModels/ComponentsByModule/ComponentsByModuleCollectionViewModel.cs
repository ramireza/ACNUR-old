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
    /// Represents the ComponentsByModule collection view model.
    /// </summary>
    public partial class ComponentsByModuleCollectionViewModel : CollectionViewModel<ComponentsByModule, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ComponentsByModuleCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ComponentsByModuleCollectionViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ComponentsByModuleCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ComponentsByModuleCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ComponentsByModuleCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ComponentsByModuleCollectionViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ComponentsByModule)
        {
        }
    }
}