namespace TicariOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.TİCARİ = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnStocks = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCompaniesForm = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployeesForm = new DevExpress.XtraBars.BarButtonItem();
            this.btnExpensesForm = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotes = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanks = new DevExpress.XtraBars.BarButtonItem();
            this.btnContact = new DevExpress.XtraBars.BarButtonItem();
            this.btnInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.btnMovement = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // TİCARİ
            // 
            this.TİCARİ.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.TİCARİ.Name = "TİCARİ";
            this.TİCARİ.Text = "Kontrol Ekranı";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStocks, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCompaniesForm, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEmployeesForm, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExpensesForm, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotes, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanks, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnContact, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnInvoice, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMovement, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSettings, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "ANA SAYFA";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem5.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "ÜRÜNLER";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnStocks
            // 
            this.btnStocks.Caption = "STOKLAR";
            this.btnStocks.Id = 2;
            this.btnStocks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.ImageOptions.Image")));
            this.btnStocks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStocks.ImageOptions.LargeImage")));
            this.btnStocks.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStocks.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnStocks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStocks.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStocks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStocks_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "MÜŞTERİLER";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnCompaniesForm
            // 
            this.btnCompaniesForm.Caption = "FİRMALAR";
            this.btnCompaniesForm.Id = 4;
            this.btnCompaniesForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCompaniesForm.ImageOptions.Image")));
            this.btnCompaniesForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCompaniesForm.ImageOptions.LargeImage")));
            this.btnCompaniesForm.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompaniesForm.ItemAppearance.Normal.Options.UseFont = true;
            this.btnCompaniesForm.Name = "btnCompaniesForm";
            this.btnCompaniesForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCompaniesForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompaniesForm_ItemClick);
            // 
            // btnEmployeesForm
            // 
            this.btnEmployeesForm.Caption = "PERSONELLER";
            this.btnEmployeesForm.Id = 6;
            this.btnEmployeesForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeesForm.ImageOptions.Image")));
            this.btnEmployeesForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeesForm.ImageOptions.LargeImage")));
            this.btnEmployeesForm.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmployeesForm.ItemAppearance.Normal.Options.UseFont = true;
            this.btnEmployeesForm.Name = "btnEmployeesForm";
            this.btnEmployeesForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEmployeesForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployeesForm_ItemClick);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.Caption = "GİDERLER";
            this.btnExpensesForm.Id = 7;
            this.btnExpensesForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpensesForm.ImageOptions.Image")));
            this.btnExpensesForm.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExpensesForm.ImageOptions.LargeImage")));
            this.btnExpensesForm.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExpensesForm.ItemAppearance.Normal.Options.UseFont = true;
            this.btnExpensesForm.Name = "btnExpensesForm";
            this.btnExpensesForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExpensesForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpensesForm_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "KASA";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem8.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // btnNotes
            // 
            this.btnNotes.Caption = "NOTLAR";
            this.btnNotes.Id = 9;
            this.btnNotes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.ImageOptions.Image")));
            this.btnNotes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNotes.ImageOptions.LargeImage")));
            this.btnNotes.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotes.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotes_ItemClick);
            // 
            // btnBanks
            // 
            this.btnBanks.Caption = "BANKALAR";
            this.btnBanks.Id = 10;
            this.btnBanks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanks.ImageOptions.Image")));
            this.btnBanks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBanks.ImageOptions.LargeImage")));
            this.btnBanks.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBanks.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanks_ItemClick);
            // 
            // btnContact
            // 
            this.btnContact.Caption = "REHBER";
            this.btnContact.Id = 11;
            this.btnContact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContact.ImageOptions.Image")));
            this.btnContact.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnContact.ImageOptions.LargeImage")));
            this.btnContact.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContact.ItemAppearance.Normal.Options.UseFont = true;
            this.btnContact.Name = "btnContact";
            this.btnContact.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnContact.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContact_ItemClick);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Caption = "FATURALAR";
            this.btnInvoice.Id = 12;
            this.btnInvoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.ImageOptions.Image")));
            this.btnInvoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInvoice.ImageOptions.LargeImage")));
            this.btnInvoice.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInvoice.ItemAppearance.Normal.Options.UseFont = true;
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInvoice_ItemClick);
            // 
            // btnMovement
            // 
            this.btnMovement.Caption = "HAREKETLER";
            this.btnMovement.Id = 15;
            this.btnMovement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMovement.ImageOptions.Image")));
            this.btnMovement.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMovement.ImageOptions.LargeImage")));
            this.btnMovement.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMovement.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMovement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMovement_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "RAPORLAR";
            this.btnReport.Id = 16;
            this.btnReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.Image")));
            this.btnReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReport.ImageOptions.LargeImage")));
            this.btnReport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReport.ItemAppearance.Normal.Options.UseFont = true;
            this.btnReport.Name = "btnReport";
            this.btnReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "AYARLAR";
            this.btnSettings.Id = 14;
            this.btnSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.Image")));
            this.btnSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.LargeImage")));
            this.btnSettings.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "barButtonItem13";
            this.barButtonItem13.Id = 13;
            this.barButtonItem13.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barButtonItem13.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.btnStocks,
            this.barButtonItem3,
            this.btnCompaniesForm,
            this.barButtonItem5,
            this.btnEmployeesForm,
            this.btnExpensesForm,
            this.barButtonItem8,
            this.btnNotes,
            this.btnBanks,
            this.btnContact,
            this.btnInvoice,
            this.barButtonItem13,
            this.btnSettings,
            this.btnMovement,
            this.btnReport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.TİCARİ});
            this.ribbonControl1.Size = new System.Drawing.Size(1912, 150);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1912, 1029);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Ticari Otomasyon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnStocks;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem btnCompaniesForm;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnEmployeesForm;
        private DevExpress.XtraBars.BarButtonItem btnExpensesForm;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem btnNotes;
        private DevExpress.XtraBars.BarButtonItem btnBanks;
        private DevExpress.XtraBars.BarButtonItem btnContact;
        private DevExpress.XtraBars.BarButtonItem btnInvoice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPage TİCARİ;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnMovement;
        private DevExpress.XtraBars.BarButtonItem btnReport;
    }
}