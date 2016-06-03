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
    /// Represents the single Parameter object view model.
    /// </summary>
    public partial class ParameterViewModel : SingleObjectViewModel<Parameter, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ParameterViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ParameterViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ParameterViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ParameterViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ParameterViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ParameterViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Parameter, x => x.Name)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of ParameterDetail for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ParameterDetail> LookUpParameterDetail
        {
            get { return GetLookUpEntitiesViewModel((ParameterViewModel x) => x.LookUpParameterDetail, x => x.ParameterDetail); }
        }


        /// <summary>
        /// The view model for the ParameterParameterDetail detail collection.
        /// </summary>
        public CollectionViewModel<ParameterDetail, int, IACNUREntitiesUnitOfWork> ParameterParameterDetailDetails
        {
            get { return GetDetailsCollectionViewModel((ParameterViewModel x) => x.ParameterParameterDetailDetails, x => x.ParameterDetail, x => x.IdParameter, (x, key) => { x.IdParameter = key; }); }
        }
    }
}
