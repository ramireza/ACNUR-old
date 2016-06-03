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
    /// Represents the single ModuleUser object view model.
    /// </summary>
    public partial class ModuleUserViewModel : SingleObjectViewModel<ModuleUser, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ModuleUserViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ModuleUserViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ModuleUserViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ModuleUserViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ModuleUserViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ModuleUserViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ModuleUser, x => x.IdModuleUser)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of Modules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Modules> LookUpModules
        {
            get { return GetLookUpEntitiesViewModel((ModuleUserViewModel x) => x.LookUpModules, x => x.Modules); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers
        {
            get { return GetLookUpEntitiesViewModel((ModuleUserViewModel x) => x.LookUpUsers, x => x.Users); }
        }

    }
}
