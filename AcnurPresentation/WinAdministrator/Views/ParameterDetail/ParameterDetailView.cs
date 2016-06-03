using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.ParameterDetailView
{
    public partial class ParameterDetailView : XtraUserControl
    {
        public ParameterDetailView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.ParameterDetailViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                parameterDetailViewBindingSource, x => x.Entity, x => x.Update());
            #region ParameterDetail1 Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ParameterDetail1GridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ParameterDetailParameterDetail1Details.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.ParameterDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(ParameterDetail1GridView, "RowClick")
                         .EventToCommand(
                             x => x.ParameterDetailParameterDetail1Details.Edit(null), x => x.ParameterDetailParameterDetail1Details.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            ParameterDetail1GridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ParameterDetail1PopUpMenu.ShowPopup(ParameterDetail1GridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the ParameterDetailParameterDetail1Details collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(ParameterDetail1GridControl, g => g.DataSource, x => x.ParameterDetailParameterDetail1Details.Entities);

            fluentAPI.BindCommand(bbiParameterDetail1New, x => x.ParameterDetailParameterDetail1Details.New());
            fluentAPI.BindCommand(bbiParameterDetail1Edit, x => x.ParameterDetailParameterDetail1Details.Edit(null), x => x.ParameterDetailParameterDetail1Details.SelectedEntity);
            fluentAPI.BindCommand(bbiParameterDetail1Delete, x => x.ParameterDetailParameterDetail1Details.Delete(null), x => x.ParameterDetailParameterDetail1Details.SelectedEntity);
            fluentAPI.BindCommand(bbiParameterDetail1Refresh, x => x.ParameterDetailParameterDetail1Details.Refresh());
            #endregion
            // Binding for Parameter LookUp editor
            fluentAPI.SetBinding(ParameterLookUpEdit.Properties, p => p.DataSource, x => x.LookUpParameter.Entities);
            // Binding for ParameterDetail2 LookUp editor
            fluentAPI.SetBinding(ParameterDetail2LookUpEdit.Properties, p => p.DataSource, x => x.LookUpParameterDetail.Entities);
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());
        }
    }
}
