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
    /// Represents the single ParameterDetail object view model.
    /// </summary>
    public partial class ParameterDetailViewModel : SingleObjectViewModel<ParameterDetail, int, IACNUREntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of ParameterDetailViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ParameterDetailViewModel Create(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new ParameterDetailViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ParameterDetailViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ParameterDetailViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ParameterDetailViewModel(IUnitOfWorkFactory<IACNUREntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ParameterDetail, x => x.Name)
        {
        }



        /// <summary>
        /// The view model that contains a look-up collection of Parameter for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Parameter> LookUpParameter
        {
            get { return GetLookUpEntitiesViewModel((ParameterDetailViewModel x) => x.LookUpParameter, x => x.Parameter); }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ParameterDetail for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ParameterDetail> LookUpParameterDetail
        {
            get { return GetLookUpEntitiesViewModel((ParameterDetailViewModel x) => x.LookUpParameterDetail, x => x.ParameterDetail); }
        }


        /// <summary>
        /// The view model for the ParameterDetailParameterDetail1 detail collection.
        /// </summary>
        public CollectionViewModel<ParameterDetail, int, IACNUREntitiesUnitOfWork> ParameterDetailParameterDetail1Details
        {
            get { return GetDetailsCollectionViewModel((ParameterDetailViewModel x) => x.ParameterDetailParameterDetail1Details, x => x.ParameterDetail, x => x.IdParameterDetailFather, (x, key) => { x.IdParameterDetailFather = key; }); }
        }
    }
}
