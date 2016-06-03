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
    /// Represents the single Users object view model.
    /// </summary>
    public partial class UsersViewModel : SingleObjectViewModel<Users, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of UsersViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UsersViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new UsersViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UsersViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UsersViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UsersViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Users, x => x.LastName)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of ModuleUser for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ModuleUser> LookUpModuleUser
        {
            get { return GetLookUpEntitiesViewModel((UsersViewModel x) => x.LookUpModuleUser, x => x.ModuleUser); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of OperationsModuleUser for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OperationsModuleUser> LookUpOperationsModuleUser
        {
            get { return GetLookUpEntitiesViewModel((UsersViewModel x) => x.LookUpOperationsModuleUser, x => x.OperationsModuleUser); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of StepsFlowModuleUser for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<StepsFlowModuleUser> LookUpStepsFlowModuleUser
        {
            get { return GetLookUpEntitiesViewModel((UsersViewModel x) => x.LookUpStepsFlowModuleUser, x => x.StepsFlowModuleUser); }
        }


        /// <summary>
        /// The view model for the UsersModuleUser detail collection.
        /// </summary>
        public CollectionViewModel<ModuleUser, int, IACNUREntitiesUnitOfWork> UsersModuleUserDetails
        {
            get { return GetDetailsCollectionViewModel((UsersViewModel x) => x.UsersModuleUserDetails, x => x.ModuleUser, x => x.IdUser, (x, key) => { x.IdUser = key; }); }
        }

        /// <summary>
        /// The view model for the UsersOperationsModuleUser detail collection.
        /// </summary>
        public CollectionViewModel<OperationsModuleUser, int, IACNUREntitiesUnitOfWork> UsersOperationsModuleUserDetails
        {
            get { return GetDetailsCollectionViewModel((UsersViewModel x) => x.UsersOperationsModuleUserDetails, x => x.OperationsModuleUser, x => x.IdUser, (x, key) => { x.IdUser = key; }); }
        }

        /// <summary>
        /// The view model for the UsersStepsFlowModuleUser detail collection.
        /// </summary>
        public CollectionViewModel<StepsFlowModuleUser, int, IACNUREntitiesUnitOfWork> UsersStepsFlowModuleUserDetails
        {
            get { return GetDetailsCollectionViewModel((UsersViewModel x) => x.UsersStepsFlowModuleUserDetails, x => x.StepsFlowModuleUser, x => x.IdUser, (x, key) => { x.IdUser = key; }); }
        }
    }
}
