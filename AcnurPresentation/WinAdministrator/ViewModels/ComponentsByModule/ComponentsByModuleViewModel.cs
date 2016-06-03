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
    /// Represents the single ComponentsByModule object view model.
    /// </summary>
    public partial class ComponentsByModuleViewModel : SingleObjectViewModel<ComponentsByModule, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ComponentsByModuleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ComponentsByModuleViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ComponentsByModuleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ComponentsByModuleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ComponentsByModuleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ComponentsByModuleViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ComponentsByModule, x => x.Name)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of Modules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Modules> LookUpModules
        {
            get { return GetLookUpEntitiesViewModel((ComponentsByModuleViewModel x) => x.LookUpModules, x => x.Modules); }
        }

    }
}
