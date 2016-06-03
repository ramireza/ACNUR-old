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
    /// Represents the single OperationsModule object view model.
    /// </summary>
    public partial class OperationsModuleViewModel : SingleObjectViewModel<OperationsModule, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of OperationsModuleViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OperationsModuleViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new OperationsModuleViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OperationsModuleViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OperationsModuleViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OperationsModuleViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.OperationsModule, x => x.IdOperationModule)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of Modules for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Modules> LookUpModules
        {
            get { return GetLookUpEntitiesViewModel((OperationsModuleViewModel x) => x.LookUpModules, x => x.Modules); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Operations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Operations> LookUpOperations
        {
            get { return GetLookUpEntitiesViewModel((OperationsModuleViewModel x) => x.LookUpOperations, x => x.Operations); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of OperationsModuleUser for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OperationsModuleUser> LookUpOperationsModuleUser
        {
            get { return GetLookUpEntitiesViewModel((OperationsModuleViewModel x) => x.LookUpOperationsModuleUser, x => x.OperationsModuleUser); }
        }


        /// <summary>
        /// The view model for the OperationsModuleOperationsModuleUser detail collection.
        /// </summary>
        public CollectionViewModel<OperationsModuleUser, int, IACNUREntitiesUnitOfWork> OperationsModuleOperationsModuleUserDetails
        {
            get { return GetDetailsCollectionViewModel((OperationsModuleViewModel x) => x.OperationsModuleOperationsModuleUserDetails, x => x.OperationsModuleUser, x => x.IdOperationModule, (x, key) => { x.IdOperationModule = key; }); }
        }
    }
}
