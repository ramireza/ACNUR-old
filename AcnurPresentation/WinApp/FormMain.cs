using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WinApp
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        public PanelControl Panel { get { return this.PnlMain; } }

        public FormMain()
        {
            InitializeComponent();
        }
    }
}