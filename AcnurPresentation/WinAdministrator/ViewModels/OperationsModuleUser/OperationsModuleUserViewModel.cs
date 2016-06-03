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
    /// Represents the single OperationsModuleUser object view model.
    /// </summary>
    public partial class OperationsModuleUserViewModel : SingleObjectViewModel<OperationsModuleUser, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of OperationsModuleUserViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OperationsModuleUserViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new OperationsModuleUserViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OperationsModuleUserViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OperationsModuleUserViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OperationsModuleUserViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.OperationsModuleUser, x => x.IdOperationModuleUser)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of OperationsModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OperationsModule> LookUpOperationsModule
        {
            get { return GetLookUpEntitiesViewModel((OperationsModuleUserViewModel x) => x.LookUpOperationsModule, x => x.OperationsModule); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Users> LookUpUsers
        {
            get { return GetLookUpEntitiesViewModel((OperationsModuleUserViewModel x) => x.LookUpUsers, x => x.Users); }
        }

    }
}
