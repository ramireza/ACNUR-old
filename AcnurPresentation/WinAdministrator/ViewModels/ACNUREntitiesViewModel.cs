using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using WinAdministrator.Common.DataModel;
using WinAdministrator.Common.ViewModel;
using WinAdministrator.ACNUREntitiesDataModel;
using Acnur.App.Repository.Data;

namespace WinAdministrator.ViewModels
{
    /// <summary>
    /// Represents the root POCO view model for the ACNUREntities data model.
    /// </summary>
    public partial class ACNUREntitiesViewModel : DocumentsViewModel<ACNUREntitiesModuleDescription, IACNUREntitiesUnitOfWork>
    {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";
        INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        /// <summary>
        /// Creates a new instance of ACNUREntitiesViewModel as a POCO view model.
        /// </summary>
        public static ACNUREntitiesViewModel Create()
        {
            return ViewModelSource.Create(() => new ACNUREntitiesViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the ACNUREntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ACNUREntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected ACNUREntitiesViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
        }

        protected override ACNUREntitiesModuleDescription[] CreateModules()
        {
            return new ACNUREntitiesModuleDescription[] {
                new ACNUREntitiesModuleDescription("Components By Module", "ComponentsByModuleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ComponentsByModule)),
                new ACNUREntitiesModuleDescription("Modules", "ModulesCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Modules)),
                new ACNUREntitiesModuleDescription("Module User", "ModuleUserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ModuleUser)),
                new ACNUREntitiesModuleDescription("Operations", "OperationsCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Operations)),
                new ACNUREntitiesModuleDescription("Operations Module", "OperationsModuleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.OperationsModule)),
                new ACNUREntitiesModuleDescription("Operations Module User", "OperationsModuleUserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.OperationsModuleUser)),
                new ACNUREntitiesModuleDescription("Parameter", "ParameterCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Parameter)),
                new ACNUREntitiesModuleDescription("Parameter Detail", "ParameterDetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ParameterDetail)),
                new ACNUREntitiesModuleDescription("Steps Flow", "StepsFlowCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.StepsFlow)),
                new ACNUREntitiesModuleDescription("Steps Flow Module", "StepsFlowModuleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.StepsFlowModule)),
                new ACNUREntitiesModuleDescription("Steps Flow Module User", "StepsFlowModuleUserCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.StepsFlowModuleUser)),
                new ACNUREntitiesModuleDescription("Users", "UsersCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Users)),
			};
        }



        protected override void OnActiveModuleChanged(ACNUREntitiesModuleDescription oldModule)
        {
            if (ActiveModule != null && NavigationService != null)
            {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
    }

    public partial class ACNUREntitiesModuleDescription : ModuleDescription<ACNUREntitiesModuleDescription>
    {
        public ACNUREntitiesModuleDescription(string title, string documentType, string group, Func<ACNUREntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory)
        {
        }
    }
}