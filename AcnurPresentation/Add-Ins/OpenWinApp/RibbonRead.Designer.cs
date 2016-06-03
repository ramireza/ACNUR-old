namespace OpenWinApp
{
    partial class RibbonRead : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonRead()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonRead));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.BtnOpenApp = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabReadMessage";
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabReadMessage";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.BtnOpenApp);
            this.group1.Label = "ACNUR";
            this.group1.Name = "group1";
            // 
            // BtnOpenApp
            // 
            this.BtnOpenApp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.BtnOpenApp.Description = "Link to the application of UNHCR";
            this.BtnOpenApp.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenApp.Image")));
            this.BtnOpenApp.Label = " ";
            this.BtnOpenApp.Name = "BtnOpenApp";
            this.BtnOpenApp.ShowImage = true;
            this.BtnOpenApp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnOpenApp_Click);
            // 
            // RibbonRead
            // 
            this.Name = "RibbonRead";
            this.RibbonType = "";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnOpenApp;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonRead RibbonRead
        {
            get { return this.GetRibbon<RibbonRead>(); }
        }
    }
}
