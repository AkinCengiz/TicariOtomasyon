﻿namespace TicariOtomasyon
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbTowns = new System.Windows.Forms.ComboBox();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.mtxtTelephone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelephone1 = new System.Windows.Forms.MaskedTextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxAdminisration = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.mtxtIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAdminisration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbTowns);
            this.groupControl1.Controls.Add(this.cmbCities);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.mtxtTelephone2);
            this.groupControl1.Controls.Add(this.mtxtTelephone1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.rtxtAddress);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtTaxAdminisration);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.mtxtIdentityNumber);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtFirstName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtLastName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1604, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(306, 861);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Ürün Kontrol";
            // 
            // cmbTowns
            // 
            this.cmbTowns.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTowns.FormattingEnabled = true;
            this.cmbTowns.Location = new System.Drawing.Point(107, 411);
            this.cmbTowns.Name = "cmbTowns";
            this.cmbTowns.Size = new System.Drawing.Size(187, 26);
            this.cmbTowns.TabIndex = 9;
            // 
            // cmbCities
            // 
            this.cmbCities.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(107, 379);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(187, 26);
            this.cmbCities.TabIndex = 8;
            this.cmbCities.SelectedIndexChanged += new System.EventHandler(this.cmbCities_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(56, 382);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(41, 18);
            this.labelControl11.TabIndex = 30;
            this.labelControl11.Text = "Şehir :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(64, 414);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 18);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "İlçe :";
            // 
            // mtxtTelephone2
            // 
            this.mtxtTelephone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelephone2.Location = new System.Drawing.Point(107, 181);
            this.mtxtTelephone2.Mask = "(999) 000 00 00";
            this.mtxtTelephone2.Name = "mtxtTelephone2";
            this.mtxtTelephone2.Size = new System.Drawing.Size(187, 24);
            this.mtxtTelephone2.TabIndex = 4;
            this.mtxtTelephone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtxtTelephone1
            // 
            this.mtxtTelephone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtTelephone1.Location = new System.Drawing.Point(107, 149);
            this.mtxtTelephone1.Mask = "(999) 000 00 00";
            this.mtxtTelephone1.Name = "mtxtTelephone1";
            this.mtxtTelephone1.Size = new System.Drawing.Size(187, 24);
            this.mtxtTelephone1.TabIndex = 3;
            this.mtxtTelephone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnAdd);
            this.groupControl2.Controls.Add(this.btnClear);
            this.groupControl2.Controls.Add(this.btnUpdate);
            this.groupControl2.Controls.Add(this.btnDelete);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 705);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(302, 154);
            this.groupControl2.TabIndex = 24;
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
            this.btnAdd.Size = new System.Drawing.Size(135, 58);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "KAYDET";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(157, 84);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 57);
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
            this.btnUpdate.Location = new System.Drawing.Point(157, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 58);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(16, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 58);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "SİL";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtAddress.Location = new System.Drawing.Point(107, 277);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(187, 96);
            this.rtxtAddress.TabIndex = 7;
            this.rtxtAddress.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(50, 277);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Adres :";
            // 
            // txtTaxAdminisration
            // 
            this.txtTaxAdminisration.Location = new System.Drawing.Point(107, 443);
            this.txtTaxAdminisration.Name = "txtTaxAdminisration";
            this.txtTaxAdminisration.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaxAdminisration.Properties.Appearance.Options.UseFont = true;
            this.txtTaxAdminisration.Size = new System.Drawing.Size(187, 24);
            this.txtTaxAdminisration.TabIndex = 10;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(8, 446);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 18);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Vergi Dairesi :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(107, 245);
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            this.txtMail.Size = new System.Drawing.Size(187, 24);
            this.txtMail.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(63, 248);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Mail :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(29, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Kimlik No :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(25, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Telefon 2 :";
            // 
            // mtxtIdentityNumber
            // 
            this.mtxtIdentityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtxtIdentityNumber.Location = new System.Drawing.Point(107, 213);
            this.mtxtIdentityNumber.Mask = "00000000000";
            this.mtxtIdentityNumber.Name = "mtxtIdentityNumber";
            this.mtxtIdentityNumber.Size = new System.Drawing.Size(187, 24);
            this.mtxtIdentityNumber.TabIndex = 5;
            this.mtxtIdentityNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtIdentityNumber.ValidatingType = typeof(int);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(25, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefon 1 :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(107, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Size = new System.Drawing.Size(187, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Adı :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(107, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Size = new System.Drawing.Size(187, 24);
            this.txtLastName.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Soyadı :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(107, 59);
            this.txtId.Name = "txtId";
            this.txtId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Properties.Appearance.Options.UseFont = true;
            this.txtId.Size = new System.Drawing.Size(187, 24);
            this.txtId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(71, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(1598, 861);
            this.dgvCustomers.TabIndex = 4;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 861);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAdminisration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private RichTextBox rtxtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtTaxAdminisration;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private MaskedTextBox mtxtIdentityNumber;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MaskedTextBox mtxtTelephone2;
        private MaskedTextBox mtxtTelephone1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DataGridView dgvCustomers;
        private ComboBox cmbCities;
        private ComboBox cmbTowns;
    }
}