using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.StepsFlowView
{
    public partial class StepsFlowView : XtraUserControl
    {
        public StepsFlowView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.StepsFlowViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                stepsFlowViewBindingSource, x => x.Entity, x => x.Update());
            #region StepsFlowModule Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StepsFlowModuleGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.StepsFlowStepsFlowModuleDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.StepsFlowModule,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(StepsFlowModuleGridView, "RowClick")
                         .EventToCommand(
                             x => x.StepsFlowStepsFlowModuleDetails.Edit(null), x => x.StepsFlowStepsFlowModuleDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            StepsFlowModuleGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    StepsFlowModulePopUpMenu.ShowPopup(StepsFlowModuleGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the StepsFlowStepsFlowModuleDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(StepsFlowModuleGridControl, g => g.DataSource, x => x.StepsFlowStepsFlowModuleDetails.Entities);

            fluentAPI.BindCommand(bbiStepsFlowModuleNew, x => x.StepsFlowStepsFlowModuleDetails.New());
            fluentAPI.BindCommand(bbiStepsFlowModuleEdit, x => x.StepsFlowStepsFlowModuleDetails.Edit(null), x => x.StepsFlowStepsFlowModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleDelete, x => x.StepsFlowStepsFlowModuleDetails.Delete(null), x => x.StepsFlowStepsFlowModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleRefresh, x => x.StepsFlowStepsFlowModuleDetails.Refresh());
            #endregion
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());
        }
    }
}
