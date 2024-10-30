namespace ARCHON_SYSTEM
{
    partial class motherFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(motherFORM));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pstCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.printMessageFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pstExit = new System.Windows.Forms.ToolStripMenuItem();
            this.printerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pstMessageUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.pstICVodeView = new System.Windows.Forms.ToolStripMenuItem();
            this.pstProdLineCode = new System.Windows.Forms.ToolStripMenuItem();
            this.pstPlantCodeMan = new System.Windows.Forms.ToolStripMenuItem();
            this.pstInteCodeManager = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pstUserSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.pstUserLogMan = new System.Windows.Forms.ToolStripMenuItem();
            this.pstArchonOption = new System.Windows.Forms.ToolStripMenuItem();
            this.pstPrintSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pstGeneralInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_SYSTEM_MENU = new System.Windows.Forms.ToolStrip();
            this.sep0 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdsNEWFORMAT = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdsNEWITEMCODE = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdsPRINTUPLOAD = new System.Windows.Forms.ToolStripButton();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdsCHANGELINECODE = new System.Windows.Forms.ToolStripButton();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdsEXIT = new System.Windows.Forms.ToolStripButton();
            this.sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.ts_SYSTEM_MENU.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.printerMenu,
            this.settingsMenu,
            this.aboutMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1473, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pstCreate,
            this.toolStripSeparator5,
            this.pstExit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // pstCreate
            // 
            this.pstCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printMessageFormatToolStripMenuItem,
            this.itemCodeToolStripMenuItem});
            this.pstCreate.Name = "pstCreate";
            this.pstCreate.Size = new System.Drawing.Size(108, 22);
            this.pstCreate.Text = "&Create";
            // 
            // printMessageFormatToolStripMenuItem
            // 
            this.printMessageFormatToolStripMenuItem.Name = "printMessageFormatToolStripMenuItem";
            this.printMessageFormatToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.printMessageFormatToolStripMenuItem.Text = "Print Message Format";
            // 
            // itemCodeToolStripMenuItem
            // 
            this.itemCodeToolStripMenuItem.Name = "itemCodeToolStripMenuItem";
            this.itemCodeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.itemCodeToolStripMenuItem.Text = "Item Code";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(105, 6);
            // 
            // pstExit
            // 
            this.pstExit.Name = "pstExit";
            this.pstExit.Size = new System.Drawing.Size(108, 22);
            this.pstExit.Text = "E&xit";
            // 
            // printerMenu
            // 
            this.printerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pstMessageUpload,
            this.pstProdLineCode,
            this.pstPlantCodeMan,
            this.pstInteCodeManager});
            this.printerMenu.Name = "printerMenu";
            this.printerMenu.Size = new System.Drawing.Size(54, 20);
            this.printerMenu.Text = "&Printer";
            // 
            // pstMessageUpload
            // 
            this.pstMessageUpload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pstICVodeView});
            this.pstMessageUpload.Image = ((System.Drawing.Image)(resources.GetObject("pstMessageUpload.Image")));
            this.pstMessageUpload.ImageTransparentColor = System.Drawing.Color.Black;
            this.pstMessageUpload.Name = "pstMessageUpload";
            this.pstMessageUpload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.pstMessageUpload.Size = new System.Drawing.Size(230, 22);
            this.pstMessageUpload.Text = "Message &Upload";
            // 
            // pstICVodeView
            // 
            this.pstICVodeView.Name = "pstICVodeView";
            this.pstICVodeView.Size = new System.Drawing.Size(263, 22);
            this.pstICVodeView.Text = "Item/Customer Code View / Upload";
            // 
            // pstProdLineCode
            // 
            this.pstProdLineCode.Image = ((System.Drawing.Image)(resources.GetObject("pstProdLineCode.Image")));
            this.pstProdLineCode.ImageTransparentColor = System.Drawing.Color.Black;
            this.pstProdLineCode.Name = "pstProdLineCode";
            this.pstProdLineCode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.pstProdLineCode.Size = new System.Drawing.Size(230, 22);
            this.pstProdLineCode.Text = "Production &Line Code";
            // 
            // pstPlantCodeMan
            // 
            this.pstPlantCodeMan.Image = ((System.Drawing.Image)(resources.GetObject("pstPlantCodeMan.Image")));
            this.pstPlantCodeMan.ImageTransparentColor = System.Drawing.Color.Black;
            this.pstPlantCodeMan.Name = "pstPlantCodeMan";
            this.pstPlantCodeMan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.pstPlantCodeMan.Size = new System.Drawing.Size(230, 22);
            this.pstPlantCodeMan.Text = "&Plant Code";
            // 
            // pstInteCodeManager
            // 
            this.pstInteCodeManager.Image = ((System.Drawing.Image)(resources.GetObject("pstInteCodeManager.Image")));
            this.pstInteCodeManager.ImageTransparentColor = System.Drawing.Color.Black;
            this.pstInteCodeManager.Name = "pstInteCodeManager";
            this.pstInteCodeManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.pstInteCodeManager.Size = new System.Drawing.Size(230, 22);
            this.pstInteCodeManager.Text = "&Interim Code";
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pstUserSettings,
            this.pstUserLogMan,
            this.pstArchonOption,
            this.pstPrintSetup});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(61, 20);
            this.settingsMenu.Text = "&Settings";
            // 
            // pstUserSettings
            // 
            this.pstUserSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pstUserSettings.AutoToolTip = true;
            this.pstUserSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstUserSettings.ImageTransparentColor = System.Drawing.Color.White;
            this.pstUserSettings.Name = "pstUserSettings";
            this.pstUserSettings.Size = new System.Drawing.Size(209, 22);
            this.pstUserSettings.Text = "User Settings";
            this.pstUserSettings.Click += new System.EventHandler(this.pstUserSettings_Click);
            // 
            // pstUserLogMan
            // 
            this.pstUserLogMan.AutoToolTip = true;
            this.pstUserLogMan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstUserLogMan.ImageTransparentColor = System.Drawing.Color.White;
            this.pstUserLogMan.Name = "pstUserLogMan";
            this.pstUserLogMan.Size = new System.Drawing.Size(209, 22);
            this.pstUserLogMan.Text = "User Log Management";
            // 
            // pstArchonOption
            // 
            this.pstArchonOption.AutoToolTip = true;
            this.pstArchonOption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstArchonOption.ImageTransparentColor = System.Drawing.Color.White;
            this.pstArchonOption.Name = "pstArchonOption";
            this.pstArchonOption.Size = new System.Drawing.Size(209, 22);
            this.pstArchonOption.Text = "Archon Options";
            // 
            // pstPrintSetup
            // 
            this.pstPrintSetup.AutoToolTip = true;
            this.pstPrintSetup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstPrintSetup.ImageTransparentColor = System.Drawing.Color.White;
            this.pstPrintSetup.Name = "pstPrintSetup";
            this.pstPrintSetup.Size = new System.Drawing.Size(209, 22);
            this.pstPrintSetup.Text = "Print Setup";
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pstGeneralInformation});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "&About";
            // 
            // pstGeneralInformation
            // 
            this.pstGeneralInformation.Name = "pstGeneralInformation";
            this.pstGeneralInformation.Size = new System.Drawing.Size(180, 22);
            this.pstGeneralInformation.Text = "General Information";
            // 
            // ts_SYSTEM_MENU
            // 
            this.ts_SYSTEM_MENU.AutoSize = false;
            this.ts_SYSTEM_MENU.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.ts_SYSTEM_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sep0,
            this.cmdsNEWFORMAT,
            this.sep1,
            this.cmdsNEWITEMCODE,
            this.sep2,
            this.cmdsPRINTUPLOAD,
            this.sep3,
            this.cmdsCHANGELINECODE,
            this.sep4,
            this.cmdsEXIT,
            this.sep5});
            this.ts_SYSTEM_MENU.Location = new System.Drawing.Point(0, 24);
            this.ts_SYSTEM_MENU.Name = "ts_SYSTEM_MENU";
            this.ts_SYSTEM_MENU.Size = new System.Drawing.Size(1473, 60);
            this.ts_SYSTEM_MENU.TabIndex = 1;
            this.ts_SYSTEM_MENU.Text = "ToolStrip";
            // 
            // sep0
            // 
            this.sep0.Name = "sep0";
            this.sep0.Size = new System.Drawing.Size(6, 60);
            // 
            // cmdsNEWFORMAT
            // 
            this.cmdsNEWFORMAT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdsNEWFORMAT.Image = ((System.Drawing.Image)(resources.GetObject("cmdsNEWFORMAT.Image")));
            this.cmdsNEWFORMAT.ImageTransparentColor = System.Drawing.Color.Black;
            this.cmdsNEWFORMAT.Name = "cmdsNEWFORMAT";
            this.cmdsNEWFORMAT.Size = new System.Drawing.Size(64, 57);
            this.cmdsNEWFORMAT.Text = "New Format";
            this.cmdsNEWFORMAT.ToolTipText = "New Code Format";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 60);
            // 
            // cmdsNEWITEMCODE
            // 
            this.cmdsNEWITEMCODE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdsNEWITEMCODE.Image = ((System.Drawing.Image)(resources.GetObject("cmdsNEWITEMCODE.Image")));
            this.cmdsNEWITEMCODE.ImageTransparentColor = System.Drawing.Color.Black;
            this.cmdsNEWITEMCODE.Name = "cmdsNEWITEMCODE";
            this.cmdsNEWITEMCODE.Size = new System.Drawing.Size(64, 57);
            this.cmdsNEWITEMCODE.Text = "Open";
            this.cmdsNEWITEMCODE.ToolTipText = "New Item Code";
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 60);
            // 
            // cmdsPRINTUPLOAD
            // 
            this.cmdsPRINTUPLOAD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdsPRINTUPLOAD.Image = ((System.Drawing.Image)(resources.GetObject("cmdsPRINTUPLOAD.Image")));
            this.cmdsPRINTUPLOAD.ImageTransparentColor = System.Drawing.Color.Black;
            this.cmdsPRINTUPLOAD.Name = "cmdsPRINTUPLOAD";
            this.cmdsPRINTUPLOAD.Size = new System.Drawing.Size(64, 57);
            this.cmdsPRINTUPLOAD.Text = "Save";
            this.cmdsPRINTUPLOAD.ToolTipText = "Print Message";
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 60);
            // 
            // cmdsCHANGELINECODE
            // 
            this.cmdsCHANGELINECODE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdsCHANGELINECODE.Image = ((System.Drawing.Image)(resources.GetObject("cmdsCHANGELINECODE.Image")));
            this.cmdsCHANGELINECODE.ImageTransparentColor = System.Drawing.Color.Black;
            this.cmdsCHANGELINECODE.Name = "cmdsCHANGELINECODE";
            this.cmdsCHANGELINECODE.Size = new System.Drawing.Size(64, 57);
            this.cmdsCHANGELINECODE.Text = "Print";
            this.cmdsCHANGELINECODE.ToolTipText = "Edit Line Code";
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(6, 60);
            // 
            // cmdsEXIT
            // 
            this.cmdsEXIT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdsEXIT.Image = ((System.Drawing.Image)(resources.GetObject("cmdsEXIT.Image")));
            this.cmdsEXIT.ImageTransparentColor = System.Drawing.Color.Black;
            this.cmdsEXIT.Name = "cmdsEXIT";
            this.cmdsEXIT.Size = new System.Drawing.Size(64, 57);
            this.cmdsEXIT.Text = "Print Preview";
            this.cmdsEXIT.ToolTipText = "Exit";
            this.cmdsEXIT.Click += new System.EventHandler(this.cmdsEXIT_Click);
            // 
            // sep5
            // 
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(6, 60);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 743);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1473, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // motherFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 765);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ts_SYSTEM_MENU);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "motherFORM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARCHON SYSTEMS FOR DOLE PHILIPPINES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.motherFORM_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ts_SYSTEM_MENU.ResumeLayout(false);
            this.ts_SYSTEM_MENU.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip ts_SYSTEM_MENU;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem pstCreate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem pstExit;
        private System.Windows.Forms.ToolStripMenuItem printerMenu;
        private System.Windows.Forms.ToolStripMenuItem pstMessageUpload;
        private System.Windows.Forms.ToolStripMenuItem pstProdLineCode;
        private System.Windows.Forms.ToolStripMenuItem pstPlantCodeMan;
        private System.Windows.Forms.ToolStripMenuItem pstInteCodeManager;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem pstUserSettings;
        private System.Windows.Forms.ToolStripMenuItem pstUserLogMan;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem pstGeneralInformation;
        private System.Windows.Forms.ToolStripButton cmdsNEWFORMAT;
        private System.Windows.Forms.ToolStripButton cmdsNEWITEMCODE;
        private System.Windows.Forms.ToolStripButton cmdsPRINTUPLOAD;
        private System.Windows.Forms.ToolStripButton cmdsCHANGELINECODE;
        private System.Windows.Forms.ToolStripButton cmdsEXIT;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripSeparator sep0;
        private System.Windows.Forms.ToolStripSeparator sep5;
        private System.Windows.Forms.ToolStripMenuItem printMessageFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pstICVodeView;
        private System.Windows.Forms.ToolStripMenuItem pstArchonOption;
        private System.Windows.Forms.ToolStripMenuItem pstPrintSetup;
    }
}



