namespace TicariOtomasyon
{
    partial class FrmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.panelInvoice = new DevExpress.XtraTab.XtraTabControl();
            this.tabPnInvoice = new DevExpress.XtraTab.XtraTabPage();
            this.chkCancel = new System.Windows.Forms.CheckBox();
            this.rdbIndividual = new System.Windows.Forms.RadioButton();
            this.rdbCorporate = new System.Windows.Forms.RadioButton();
            this.dtpHours = new System.Windows.Forms.DateTimePicker();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSerial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.txtInvoiceNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPnInvoiceDetails = new DevExpress.XtraTab.XtraTabPage();
            this.txtInvoice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtInvoiceDetailId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDetailClear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tabPnSales = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xTabPnInvoiceInfo = new DevExpress.XtraTab.XtraTabPage();
            this.xTabInvoiceDetail = new DevExpress.XtraTab.XtraTabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInvoice)).BeginInit();
            this.panelInvoice.SuspendLayout();
            this.tabPnInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.tabPnInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDetailId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xTabPnInvoiceInfo.SuspendLayout();
            this.xTabInvoiceDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowTemplate.Height = 25;
            this.dgvInvoice.Size = new System.Drawing.Size(1507, 836);
            this.dgvInvoice.TabIndex = 8;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellDoubleClick);
            // 
            // panelInvoice
            // 
            this.panelInvoice.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInvoice.Location = new System.Drawing.Point(1514, 0);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.SelectedTabPage = this.tabPnInvoice;
            this.panelInvoice.Size = new System.Drawing.Size(396, 861);
            this.panelInvoice.TabIndex = 9;
            this.panelInvoice.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPnInvoice,
            this.tabPnInvoiceDetails,
            this.tabPnSales});
            // 
            // tabPnInvoice
            // 
            this.tabPnInvoice.Controls.Add(this.chkCancel);
            this.tabPnInvoice.Controls.Add(this.rdbIndividual);
            this.tabPnInvoice.Controls.Add(this.rdbCorporate);
            this.tabPnInvoice.Controls.Add(this.dtpHours);
            this.tabPnInvoice.Controls.Add(this.labelControl16);
            this.tabPnInvoice.Controls.Add(this.dtpDate);
            this.tabPnInvoice.Controls.Add(this.txtSerial);
            this.tabPnInvoice.Controls.Add(this.labelControl15);
            this.tabPnInvoice.Controls.Add(this.cmbEmployees);
            this.tabPnInvoice.Controls.Add(this.cmbCustomers);
            this.tabPnInvoice.Controls.Add(this.labelControl11);
            this.tabPnInvoice.Controls.Add(this.labelControl10);
            this.tabPnInvoice.Controls.Add(this.groupControl2);
            this.tabPnInvoice.Controls.Add(this.txtInvoiceNumber);
            this.tabPnInvoice.Controls.Add(this.labelControl3);
            this.tabPnInvoice.Controls.Add(this.labelControl2);
            this.tabPnInvoice.Controls.Add(this.txtId);
            this.tabPnInvoice.Controls.Add(this.labelControl1);
            this.tabPnInvoice.Name = "tabPnInvoice";
            this.tabPnInvoice.Size = new System.Drawing.Size(394, 836);
            this.tabPnInvoice.Text = "Fatura Bilgileri";
            // 
            // chkCancel
            // 
            this.chkCancel.AutoSize = true;
            this.chkCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCancel.Location = new System.Drawing.Point(107, 276);
            this.chkCancel.Name = "chkCancel";
            this.chkCancel.Size = new System.Drawing.Size(103, 22);
            this.chkCancel.TabIndex = 9;
            this.chkCancel.Text = "Fatura İptal";
            this.chkCancel.UseVisualStyleBackColor = true;
            // 
            // rdbIndividual
            // 
            this.rdbIndividual.AutoSize = true;
            this.rdbIndividual.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbIndividual.Location = new System.Drawing.Point(219, 184);
            this.rdbIndividual.Name = "rdbIndividual";
            this.rdbIndividual.Size = new System.Drawing.Size(75, 22);
            this.rdbIndividual.TabIndex = 6;
            this.rdbIndividual.Text = "Bireysel";
            this.rdbIndividual.UseVisualStyleBackColor = true;
            this.rdbIndividual.CheckedChanged += new System.EventHandler(this.rdbIndividual_CheckedChanged);
            // 
            // rdbCorporate
            // 
            this.rdbCorporate.AutoSize = true;
            this.rdbCorporate.Checked = true;
            this.rdbCorporate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCorporate.Location = new System.Drawing.Point(107, 184);
            this.rdbCorporate.Name = "rdbCorporate";
            this.rdbCorporate.Size = new System.Drawing.Size(86, 22);
            this.rdbCorporate.TabIndex = 5;
            this.rdbCorporate.TabStop = true;
            this.rdbCorporate.Text = "Kurumsal";
            this.rdbCorporate.UseVisualStyleBackColor = true;
            this.rdbCorporate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dtpHours
            // 
            this.dtpHours.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHours.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHours.Location = new System.Drawing.Point(107, 152);
            this.dtpHours.Name = "dtpHours";
            this.dtpHours.Size = new System.Drawing.Size(276, 26);
            this.dtpHours.TabIndex = 4;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(62, 158);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(39, 18);
            this.labelControl16.TabIndex = 75;
            this.labelControl16.Text = "Saat :";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(107, 120);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(276, 26);
            this.dtpDate.TabIndex = 3;
            // 
            // txtSerial
            // 
            this.txtSerial.Enabled = false;
            this.txtSerial.Location = new System.Drawing.Point(107, 60);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSerial.Properties.Appearance.Options.UseFont = true;
            this.txtSerial.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtSerial.Properties.MaskSettings.Set("mask", "[A-Z]");
            this.txtSerial.Size = new System.Drawing.Size(276, 24);
            this.txtSerial.TabIndex = 1;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(21, 63);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(80, 18);
            this.labelControl15.TabIndex = 71;
            this.labelControl15.Text = "Fatura Seri :";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(107, 244);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(276, 26);
            this.cmbEmployees.TabIndex = 8;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(107, 212);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(276, 26);
            this.cmbCustomers.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(69, 215);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 18);
            this.labelControl11.TabIndex = 61;
            this.labelControl11.Text = "Alıcı :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(37, 247);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 18);
            this.labelControl10.TabIndex = 60;
            this.labelControl10.Text = "Personel :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Controls.Add(this.btnClear);
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnAddProduct);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 682);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(394, 154);
            this.groupControl2.TabIndex = 59;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(16, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 58);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "FATURA GİR";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(219, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 57);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(219, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 58);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Appearance.Options.UseBackColor = true;
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.ImageOptions.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(16, 83);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(163, 58);
            this.btnAddProduct.TabIndex = 22;
            this.btnAddProduct.Text = "ÜRÜN EKLE";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Enabled = false;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(107, 90);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInvoiceNumber.Properties.Appearance.Options.UseFont = true;
            this.txtInvoiceNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtInvoiceNumber.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtInvoiceNumber.Properties.MaskSettings.Set("mask", "0");
            this.txtInvoiceNumber.Size = new System.Drawing.Size(276, 24);
            this.txtInvoiceNumber.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 48;
            this.labelControl3.Text = "Fatura No :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 18);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Tarih :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(107, 30);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(276, 24);
            this.txtId.TabIndex = 100;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(75, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "ID :";
            // 
            // tabPnInvoiceDetails
            // 
            this.tabPnInvoiceDetails.Controls.Add(this.txtInvoice);
            this.tabPnInvoiceDetails.Controls.Add(this.labelControl17);
            this.tabPnInvoiceDetails.Controls.Add(this.txtUnitPrice);
            this.tabPnInvoiceDetails.Controls.Add(this.labelControl9);
            this.tabPnInvoiceDetails.Controls.Add(this.txtTotalPrice);
            this.tabPnInvoiceDetails.Controls.Add(this.labelControl8);
            this.tabPnInvoiceDetails.Controls.Add(this.cmbProducts);
            this.tabPnInvoiceDetails.Controls.Add(this.labelControl5);
            this.tabPnInvoiceDetails.Controls.Add(this.txtInvoiceDetailId);
            this.tabPnInvoiceDetails.Controls.Add(this.labelControl4);
            this.tabPnInvoiceDetails.Controls.Add(this.groupControl1);
            this.tabPnInvoiceDetails.Controls.Add(this.txtAmount);
            this.tabPnInvoiceDetails.Controls.Add(this.labelControl7);
            this.tabPnInvoiceDetails.Name = "tabPnInvoiceDetails";
            this.tabPnInvoiceDetails.Size = new System.Drawing.Size(394, 836);
            this.tabPnInvoiceDetails.Text = "Fatura Detayları";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Enabled = false;
            this.txtInvoice.Location = new System.Drawing.Point(105, 195);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInvoice.Properties.Appearance.Options.UseFont = true;
            this.txtInvoice.Size = new System.Drawing.Size(278, 24);
            this.txtInvoice.TabIndex = 5;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(23, 198);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(75, 18);
            this.labelControl17.TabIndex = 97;
            this.labelControl17.Text = "Fatura No :";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(104, 135);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.txtUnitPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtUnitPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtUnitPrice.Size = new System.Drawing.Size(278, 24);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(21, 138);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(77, 18);
            this.labelControl9.TabIndex = 96;
            this.labelControl9.Text = "Birim Fiyat :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(104, 165);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.txtTotalPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTotalPrice.Properties.MaskSettings.Set("mask", "c");
            this.txtTotalPrice.Size = new System.Drawing.Size(278, 24);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(52, 168);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(46, 18);
            this.labelControl8.TabIndex = 94;
            this.labelControl8.Text = "Tutar :";
            // 
            // cmbProducts
            // 
            this.cmbProducts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(104, 73);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(278, 26);
            this.cmbProducts.TabIndex = 1;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(33, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 18);
            this.labelControl5.TabIndex = 92;
            this.labelControl5.Text = "Ürün Adı :";
            // 
            // txtInvoiceDetailId
            // 
            this.txtInvoiceDetailId.Enabled = false;
            this.txtInvoiceDetailId.Location = new System.Drawing.Point(104, 43);
            this.txtInvoiceDetailId.Name = "txtInvoiceDetailId";
            this.txtInvoiceDetailId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInvoiceDetailId.Properties.Appearance.Options.UseFont = true;
            this.txtInvoiceDetailId.Size = new System.Drawing.Size(278, 24);
            this.txtInvoiceDetailId.TabIndex = 90;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(72, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 18);
            this.labelControl4.TabIndex = 89;
            this.labelControl4.Text = "ID :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnDetailClear);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 682);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(394, 154);
            this.groupControl1.TabIndex = 88;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Lime;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(16, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 58);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnDetailClear
            // 
            this.btnDetailClear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnDetailClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetailClear.Appearance.Options.UseBackColor = true;
            this.btnDetailClear.Appearance.Options.UseFont = true;
            this.btnDetailClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailClear.ImageOptions.Image")));
            this.btnDetailClear.Location = new System.Drawing.Point(210, 84);
            this.btnDetailClear.Name = "btnDetailClear";
            this.btnDetailClear.Size = new System.Drawing.Size(172, 57);
            this.btnDetailClear.TabIndex = 23;
            this.btnDetailClear.Text = "TEMİZLE";
            this.btnDetailClear.Click += new System.EventHandler(this.btnDetailClear_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(210, 19);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(172, 58);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.Red;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(16, 83);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(172, 58);
            this.simpleButton4.TabIndex = 22;
            this.simpleButton4.Text = "TAMAMLA";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(104, 105);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAmount.Properties.MaskSettings.Set("mask", "n");
            this.txtAmount.Size = new System.Drawing.Size(278, 24);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(49, 108);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 18);
            this.labelControl7.TabIndex = 86;
            this.labelControl7.Text = "Miktar :";
            // 
            // tabPnSales
            // 
            this.tabPnSales.Name = "tabPnSales";
            this.tabPnSales.Size = new System.Drawing.Size(394, 836);
            this.tabPnSales.Text = "Satış İşlemleri";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xTabPnInvoiceInfo;
            this.xtraTabControl1.Size = new System.Drawing.Size(1509, 861);
            this.xtraTabControl1.TabIndex = 10;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabPnInvoiceInfo,
            this.xTabInvoiceDetail});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xTabPnInvoiceInfo
            // 
            this.xTabPnInvoiceInfo.Controls.Add(this.dgvInvoice);
            this.xTabPnInvoiceInfo.Name = "xTabPnInvoiceInfo";
            this.xTabPnInvoiceInfo.Size = new System.Drawing.Size(1507, 836);
            this.xTabPnInvoiceInfo.Text = "Faturalar";
            // 
            // xTabInvoiceDetail
            // 
            this.xTabInvoiceDetail.Controls.Add(this.dgvProducts);
            this.xTabInvoiceDetail.Name = "xTabInvoiceDetail";
            this.xTabInvoiceDetail.Size = new System.Drawing.Size(1507, 836);
            this.xTabInvoiceDetail.Text = "Fatura Detayları";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(1507, 836);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 861);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelInvoice);
            this.Name = "FrmInvoice";
            this.Text = "Fatura Ekranı";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelInvoice)).EndInit();
            this.panelInvoice.ResumeLayout(false);
            this.tabPnInvoice.ResumeLayout(false);
            this.tabPnInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.tabPnInvoiceDetails.ResumeLayout(false);
            this.tabPnInvoiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDetailId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xTabPnInvoiceInfo.ResumeLayout(false);
            this.xTabInvoiceDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvInvoice;
        private DevExpress.XtraTab.XtraTabControl panelInvoice;
        private DevExpress.XtraTab.XtraTabPage tabPnInvoice;
        private DevExpress.XtraTab.XtraTabPage tabPnInvoiceDetails;
        private DevExpress.XtraEditors.TextEdit txtSerial;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private ComboBox cmbEmployees;
        private ComboBox cmbCustomers;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.TextEdit txtInvoiceNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage tabPnSales;
        private RadioButton rdbIndividual;
        private RadioButton rdbCorporate;
        private DateTimePicker dtpHours;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DateTimePicker dtpDate;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDetailClear;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private CheckBox chkCancel;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xTabPnInvoiceInfo;
        private DevExpress.XtraTab.XtraTabPage xTabInvoiceDetail;
        private DevExpress.XtraEditors.TextEdit txtInvoice;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private ComboBox cmbProducts;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtInvoiceDetailId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DataGridView dgvProducts;
    }
}