using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.StepsFlowModuleView
{
    public partial class StepsFlowModuleView : XtraUserControl
    {
        public StepsFlowModuleView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.StepsFlowModuleViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                stepsFlowModuleViewBindingSource, x => x.Entity, x => x.Update());
            #region StepsFlowModuleUser Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StepsFlowModuleUserGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StepsFlowModuleStepsFlowModuleUserDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.StepsFlowModuleUser,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(StepsFlowModuleUserGridView, "RowClick")
                         .EventToCommand(
                             x => x.StepsFlowModuleStepsFlowModuleUserDetails.Edit(null), x => x.StepsFlowModuleStepsFlowModuleUserDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            StepsFlowModuleUserGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    StepsFlowModuleUserPopUpMenu.ShowPopup(StepsFlowModuleUserGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the StepsFlowModuleStepsFlowModuleUserDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(StepsFlowModuleUserGridControl, g => g.DataSource, x => x.StepsFlowModuleStepsFlowModuleUserDetails.Entities);

            fluentAPI.BindCommand(bbiStepsFlowModuleUserNew, x => x.StepsFlowModuleStepsFlowModuleUserDetails.New());
            fluentAPI.BindCommand(bbiStepsFlowModuleUserEdit, x => x.StepsFlowModuleStepsFlowModuleUserDetails.Edit(null), x => x.StepsFlowModuleStepsFlowModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleUserDelete, x => x.StepsFlowModuleStepsFlowModuleUserDetails.Delete(null), x => x.StepsFlowModuleStepsFlowModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleUserRefresh, x => x.StepsFlowModuleStepsFlowModuleUserDetails.Refresh());
            #endregion
            // Binding for Modules LookUp editor
            fluentAPI.SetBinding(ModulesLookUpEdit.Properties, p => p.DataSource, x => x.LookUpModules.Entities);
            // Binding for StepsFlow LookUp editor
            fluentAPI.SetBinding(StepsFlowLookUpEdit.Properties, p => p.DataSource, x => x.LookUpStepsFlow.Entities);
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());
        }
    }
}
