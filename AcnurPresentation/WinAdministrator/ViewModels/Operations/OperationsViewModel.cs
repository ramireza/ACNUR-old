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
    /// Represents the single Operations object view model.
    /// </summary>
    public partial class OperationsViewModel : SingleObjectViewModel<Operations, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of OperationsViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OperationsViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new OperationsViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OperationsViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OperationsViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OperationsViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Operations, x => x.Name)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of OperationsModule for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OperationsModule> LookUpOperationsModule
        {
            get { return GetLookUpEntitiesViewModel((OperationsViewModel x) => x.LookUpOperationsModule, x => x.OperationsModule); }
        }


        /// <summary>
        /// The view model for the OperationsOperationsModule detail collection.
        /// </summary>
        public CollectionViewModel<OperationsModule, int, IACNUREntitiesUnitOfWork> OperationsOperationsModuleDetails
        {
            get { return GetDetailsCollectionViewModel((OperationsViewModel x) => x.OperationsOperationsModuleDetails, x => x.OperationsModule, x => x.IdOperation, (x, key) => { x.IdOperation = key; }); }
        }
    }
}
