using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Navigation;

namespace WinAdministrator.Views.ACNUREntitiesView
{
    public partial class ACNUREntitiesView : XtraUserControl
    {
        public ACNUREntitiesView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitializeNavigation();
        }
        void InitializeNavigation()
        {
            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            float fontSize = 10f;
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", fontSize);
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = new System.Drawing.Font("Segoe UI", fontSize);

            tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor;
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.ACNUREntitiesViewModel>();
            tileBar.SelectedItem = tileBarItemComponentsByModuleCollectionView;

            fluentAPI.BindCommand(tileBarItemComponentsByModuleCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
            fluentAPI.BindCommand(tileBarItemModulesCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
            fluentAPI.BindCommand(tileBarItemModuleUserCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
            fluentAPI.BindCommand(tileBarItemOperationsCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
            fluentAPI.BindCommand(tileBarItemOperationsModuleCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
            fluentAPI.BindCommand(tileBarItemOperationsModuleUserCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
            fluentAPI.BindCommand(tileBarItemParameterCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
            fluentAPI.BindCommand(tileBarItemParameterDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
            fluentAPI.BindCommand(tileBarItemStepsFlowCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
            fluentAPI.BindCommand(tileBarItemStepsFlowModuleCollectionView, (x, m) => x.Show(m), x => x.Modules[9]);
            fluentAPI.BindCommand(tileBarItemStepsFlowModuleUserCollectionView, (x, m) => x.Show(m), x => x.Modules[10]);
            fluentAPI.BindCommand(tileBarItemUsersCollectionView, (x, m) => x.Show(m), x => x.Modules[11]);
            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);

        }
    }
}
