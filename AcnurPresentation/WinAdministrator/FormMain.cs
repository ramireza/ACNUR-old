using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinAdministrator.Views.ACNUREntitiesView;

namespace WinAdministrator
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public FormMain()
        {
            InitializeComponent();
            ACNUREntitiesView control = new ACNUREntitiesView();
            this.PnlAdministrator.Controls.Add(control);
        }
    }
}
