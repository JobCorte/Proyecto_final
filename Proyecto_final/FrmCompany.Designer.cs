
namespace Proyecto_final
{
    partial class FrmCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatosCompany = new MetroFramework.Controls.MetroGrid();
            this.idCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webSiteCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatosCompany = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtEmailCompany = new MetroFramework.Controls.MetroTextBox();
            this.txtWebSiteCompany = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNumberCompany = new MetroFramework.Controls.MetroTextBox();
            this.txtPostalCodeCompany = new MetroFramework.Controls.MetroTextBox();
            this.txtAdressCompany = new MetroFramework.Controls.MetroTextBox();
            this.txtNameCompany = new MetroFramework.Controls.MetroTextBox();
            this.txtIdCompany = new MetroFramework.Controls.MetroTextBox();
            this.lblEmailCompany = new MetroFramework.Controls.MetroLabel();
            this.lblWebSiteCompany = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNumberCompany = new MetroFramework.Controls.MetroLabel();
            this.lblPostalCodeCompany = new MetroFramework.Controls.MetroLabel();
            this.lblAdressCompany = new MetroFramework.Controls.MetroLabel();
            this.lblNameCompany = new MetroFramework.Controls.MetroLabel();
            this.lblIdCompany = new MetroFramework.Controls.MetroLabel();
            this.pctPhotoCompany = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.pnlDatosCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosCompany
            // 
            this.grdDatosCompany.AllowUserToResizeRows = false;
            this.grdDatosCompany.AutoGenerateColumns = false;
            this.grdDatosCompany.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatosCompany.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatosCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatosCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompanyDataGridViewTextBoxColumn,
            this.nameCompanyDataGridViewTextBoxColumn,
            this.adressCompanyDataGridViewTextBoxColumn,
            this.postalCodeCompanyDataGridViewTextBoxColumn,
            this.phoneNumberCompanyDataGridViewTextBoxColumn,
            this.webSiteCompanyDataGridViewTextBoxColumn,
            this.emailCompanyDataGridViewTextBoxColumn,
            this.photoCompanyDataGridViewTextBoxColumn});
            this.grdDatosCompany.DataSource = this.companyBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatosCompany.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatosCompany.EnableHeadersVisualStyles = false;
            this.grdDatosCompany.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatosCompany.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosCompany.Location = new System.Drawing.Point(23, 63);
            this.grdDatosCompany.Name = "grdDatosCompany";
            this.grdDatosCompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosCompany.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatosCompany.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatosCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatosCompany.Size = new System.Drawing.Size(362, 282);
            this.grdDatosCompany.TabIndex = 0;
            this.grdDatosCompany.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosCompany_CellContentClick);
            // 
            // idCompanyDataGridViewTextBoxColumn
            // 
            this.idCompanyDataGridViewTextBoxColumn.DataPropertyName = "IdCompany";
            this.idCompanyDataGridViewTextBoxColumn.HeaderText = "IdCompany";
            this.idCompanyDataGridViewTextBoxColumn.Name = "idCompanyDataGridViewTextBoxColumn";
            // 
            // nameCompanyDataGridViewTextBoxColumn
            // 
            this.nameCompanyDataGridViewTextBoxColumn.DataPropertyName = "NameCompany";
            this.nameCompanyDataGridViewTextBoxColumn.HeaderText = "NameCompany";
            this.nameCompanyDataGridViewTextBoxColumn.Name = "nameCompanyDataGridViewTextBoxColumn";
            // 
            // adressCompanyDataGridViewTextBoxColumn
            // 
            this.adressCompanyDataGridViewTextBoxColumn.DataPropertyName = "AdressCompany";
            this.adressCompanyDataGridViewTextBoxColumn.HeaderText = "AdressCompany";
            this.adressCompanyDataGridViewTextBoxColumn.Name = "adressCompanyDataGridViewTextBoxColumn";
            // 
            // postalCodeCompanyDataGridViewTextBoxColumn
            // 
            this.postalCodeCompanyDataGridViewTextBoxColumn.DataPropertyName = "PostalCodeCompany";
            this.postalCodeCompanyDataGridViewTextBoxColumn.HeaderText = "PostalCodeCompany";
            this.postalCodeCompanyDataGridViewTextBoxColumn.Name = "postalCodeCompanyDataGridViewTextBoxColumn";
            // 
            // phoneNumberCompanyDataGridViewTextBoxColumn
            // 
            this.phoneNumberCompanyDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberCompany";
            this.phoneNumberCompanyDataGridViewTextBoxColumn.HeaderText = "PhoneNumberCompany";
            this.phoneNumberCompanyDataGridViewTextBoxColumn.Name = "phoneNumberCompanyDataGridViewTextBoxColumn";
            // 
            // webSiteCompanyDataGridViewTextBoxColumn
            // 
            this.webSiteCompanyDataGridViewTextBoxColumn.DataPropertyName = "WebSiteCompany";
            this.webSiteCompanyDataGridViewTextBoxColumn.HeaderText = "WebSiteCompany";
            this.webSiteCompanyDataGridViewTextBoxColumn.Name = "webSiteCompanyDataGridViewTextBoxColumn";
            // 
            // emailCompanyDataGridViewTextBoxColumn
            // 
            this.emailCompanyDataGridViewTextBoxColumn.DataPropertyName = "EmailCompany";
            this.emailCompanyDataGridViewTextBoxColumn.HeaderText = "EmailCompany";
            this.emailCompanyDataGridViewTextBoxColumn.Name = "emailCompanyDataGridViewTextBoxColumn";
            // 
            // photoCompanyDataGridViewTextBoxColumn
            // 
            this.photoCompanyDataGridViewTextBoxColumn.DataPropertyName = "PhotoCompany";
            this.photoCompanyDataGridViewTextBoxColumn.HeaderText = "PhotoCompany";
            this.photoCompanyDataGridViewTextBoxColumn.Name = "photoCompanyDataGridViewTextBoxColumn";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Proyecto_final.Entidades.Company);
            // 
            // pnlDatosCompany
            // 
            this.pnlDatosCompany.Controls.Add(this.btnSearch);
            this.pnlDatosCompany.Controls.Add(this.txtEmailCompany);
            this.pnlDatosCompany.Controls.Add(this.txtWebSiteCompany);
            this.pnlDatosCompany.Controls.Add(this.txtPhoneNumberCompany);
            this.pnlDatosCompany.Controls.Add(this.txtPostalCodeCompany);
            this.pnlDatosCompany.Controls.Add(this.txtAdressCompany);
            this.pnlDatosCompany.Controls.Add(this.txtNameCompany);
            this.pnlDatosCompany.Controls.Add(this.txtIdCompany);
            this.pnlDatosCompany.Controls.Add(this.lblEmailCompany);
            this.pnlDatosCompany.Controls.Add(this.lblWebSiteCompany);
            this.pnlDatosCompany.Controls.Add(this.lblPhoneNumberCompany);
            this.pnlDatosCompany.Controls.Add(this.lblPostalCodeCompany);
            this.pnlDatosCompany.Controls.Add(this.lblAdressCompany);
            this.pnlDatosCompany.Controls.Add(this.lblNameCompany);
            this.pnlDatosCompany.Controls.Add(this.lblIdCompany);
            this.pnlDatosCompany.Controls.Add(this.pctPhotoCompany);
            this.pnlDatosCompany.HorizontalScrollbarBarColor = true;
            this.pnlDatosCompany.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatosCompany.HorizontalScrollbarSize = 10;
            this.pnlDatosCompany.Location = new System.Drawing.Point(391, 63);
            this.pnlDatosCompany.Name = "pnlDatosCompany";
            this.pnlDatosCompany.Size = new System.Drawing.Size(529, 227);
            this.pnlDatosCompany.TabIndex = 1;
            this.pnlDatosCompany.VerticalScrollbarBarColor = true;
            this.pnlDatosCompany.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatosCompany.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmailCompany
            // 
            // 
            // 
            // 
            this.txtEmailCompany.CustomButton.Image = null;
            this.txtEmailCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtEmailCompany.CustomButton.Name = "";
            this.txtEmailCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailCompany.CustomButton.TabIndex = 1;
            this.txtEmailCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailCompany.CustomButton.UseSelectable = true;
            this.txtEmailCompany.CustomButton.Visible = false;
            this.txtEmailCompany.Lines = new string[0];
            this.txtEmailCompany.Location = new System.Drawing.Point(290, 183);
            this.txtEmailCompany.MaxLength = 32767;
            this.txtEmailCompany.Name = "txtEmailCompany";
            this.txtEmailCompany.PasswordChar = '\0';
            this.txtEmailCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailCompany.SelectedText = "";
            this.txtEmailCompany.SelectionLength = 0;
            this.txtEmailCompany.SelectionStart = 0;
            this.txtEmailCompany.ShortcutsEnabled = true;
            this.txtEmailCompany.Size = new System.Drawing.Size(210, 23);
            this.txtEmailCompany.TabIndex = 16;
            this.txtEmailCompany.UseSelectable = true;
            this.txtEmailCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWebSiteCompany
            // 
            // 
            // 
            // 
            this.txtWebSiteCompany.CustomButton.Image = null;
            this.txtWebSiteCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtWebSiteCompany.CustomButton.Name = "";
            this.txtWebSiteCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtWebSiteCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWebSiteCompany.CustomButton.TabIndex = 1;
            this.txtWebSiteCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWebSiteCompany.CustomButton.UseSelectable = true;
            this.txtWebSiteCompany.CustomButton.Visible = false;
            this.txtWebSiteCompany.Lines = new string[0];
            this.txtWebSiteCompany.Location = new System.Drawing.Point(290, 154);
            this.txtWebSiteCompany.MaxLength = 32767;
            this.txtWebSiteCompany.Name = "txtWebSiteCompany";
            this.txtWebSiteCompany.PasswordChar = '\0';
            this.txtWebSiteCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWebSiteCompany.SelectedText = "";
            this.txtWebSiteCompany.SelectionLength = 0;
            this.txtWebSiteCompany.SelectionStart = 0;
            this.txtWebSiteCompany.ShortcutsEnabled = true;
            this.txtWebSiteCompany.Size = new System.Drawing.Size(210, 23);
            this.txtWebSiteCompany.TabIndex = 15;
            this.txtWebSiteCompany.UseSelectable = true;
            this.txtWebSiteCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWebSiteCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNumberCompany
            // 
            // 
            // 
            // 
            this.txtPhoneNumberCompany.CustomButton.Image = null;
            this.txtPhoneNumberCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtPhoneNumberCompany.CustomButton.Name = "";
            this.txtPhoneNumberCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumberCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumberCompany.CustomButton.TabIndex = 1;
            this.txtPhoneNumberCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumberCompany.CustomButton.UseSelectable = true;
            this.txtPhoneNumberCompany.CustomButton.Visible = false;
            this.txtPhoneNumberCompany.Lines = new string[0];
            this.txtPhoneNumberCompany.Location = new System.Drawing.Point(290, 125);
            this.txtPhoneNumberCompany.MaxLength = 32767;
            this.txtPhoneNumberCompany.Name = "txtPhoneNumberCompany";
            this.txtPhoneNumberCompany.PasswordChar = '\0';
            this.txtPhoneNumberCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumberCompany.SelectedText = "";
            this.txtPhoneNumberCompany.SelectionLength = 0;
            this.txtPhoneNumberCompany.SelectionStart = 0;
            this.txtPhoneNumberCompany.ShortcutsEnabled = true;
            this.txtPhoneNumberCompany.Size = new System.Drawing.Size(210, 23);
            this.txtPhoneNumberCompany.TabIndex = 14;
            this.txtPhoneNumberCompany.UseSelectable = true;
            this.txtPhoneNumberCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumberCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPostalCodeCompany
            // 
            // 
            // 
            // 
            this.txtPostalCodeCompany.CustomButton.Image = null;
            this.txtPostalCodeCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtPostalCodeCompany.CustomButton.Name = "";
            this.txtPostalCodeCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPostalCodeCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPostalCodeCompany.CustomButton.TabIndex = 1;
            this.txtPostalCodeCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPostalCodeCompany.CustomButton.UseSelectable = true;
            this.txtPostalCodeCompany.CustomButton.Visible = false;
            this.txtPostalCodeCompany.Lines = new string[0];
            this.txtPostalCodeCompany.Location = new System.Drawing.Point(290, 96);
            this.txtPostalCodeCompany.MaxLength = 32767;
            this.txtPostalCodeCompany.Name = "txtPostalCodeCompany";
            this.txtPostalCodeCompany.PasswordChar = '\0';
            this.txtPostalCodeCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPostalCodeCompany.SelectedText = "";
            this.txtPostalCodeCompany.SelectionLength = 0;
            this.txtPostalCodeCompany.SelectionStart = 0;
            this.txtPostalCodeCompany.ShortcutsEnabled = true;
            this.txtPostalCodeCompany.Size = new System.Drawing.Size(210, 23);
            this.txtPostalCodeCompany.TabIndex = 13;
            this.txtPostalCodeCompany.UseSelectable = true;
            this.txtPostalCodeCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPostalCodeCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdressCompany
            // 
            // 
            // 
            // 
            this.txtAdressCompany.CustomButton.Image = null;
            this.txtAdressCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtAdressCompany.CustomButton.Name = "";
            this.txtAdressCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdressCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdressCompany.CustomButton.TabIndex = 1;
            this.txtAdressCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdressCompany.CustomButton.UseSelectable = true;
            this.txtAdressCompany.CustomButton.Visible = false;
            this.txtAdressCompany.Lines = new string[0];
            this.txtAdressCompany.Location = new System.Drawing.Point(290, 67);
            this.txtAdressCompany.MaxLength = 32767;
            this.txtAdressCompany.Name = "txtAdressCompany";
            this.txtAdressCompany.PasswordChar = '\0';
            this.txtAdressCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdressCompany.SelectedText = "";
            this.txtAdressCompany.SelectionLength = 0;
            this.txtAdressCompany.SelectionStart = 0;
            this.txtAdressCompany.ShortcutsEnabled = true;
            this.txtAdressCompany.Size = new System.Drawing.Size(210, 23);
            this.txtAdressCompany.TabIndex = 12;
            this.txtAdressCompany.UseSelectable = true;
            this.txtAdressCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdressCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameCompany
            // 
            // 
            // 
            // 
            this.txtNameCompany.CustomButton.Image = null;
            this.txtNameCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtNameCompany.CustomButton.Name = "";
            this.txtNameCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameCompany.CustomButton.TabIndex = 1;
            this.txtNameCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameCompany.CustomButton.UseSelectable = true;
            this.txtNameCompany.CustomButton.Visible = false;
            this.txtNameCompany.Lines = new string[0];
            this.txtNameCompany.Location = new System.Drawing.Point(290, 38);
            this.txtNameCompany.MaxLength = 32767;
            this.txtNameCompany.Name = "txtNameCompany";
            this.txtNameCompany.PasswordChar = '\0';
            this.txtNameCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameCompany.SelectedText = "";
            this.txtNameCompany.SelectionLength = 0;
            this.txtNameCompany.SelectionStart = 0;
            this.txtNameCompany.ShortcutsEnabled = true;
            this.txtNameCompany.Size = new System.Drawing.Size(210, 23);
            this.txtNameCompany.TabIndex = 11;
            this.txtNameCompany.UseSelectable = true;
            this.txtNameCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdCompany
            // 
            // 
            // 
            // 
            this.txtIdCompany.CustomButton.Image = null;
            this.txtIdCompany.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtIdCompany.CustomButton.Name = "";
            this.txtIdCompany.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdCompany.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdCompany.CustomButton.TabIndex = 1;
            this.txtIdCompany.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdCompany.CustomButton.UseSelectable = true;
            this.txtIdCompany.CustomButton.Visible = false;
            this.txtIdCompany.Lines = new string[0];
            this.txtIdCompany.Location = new System.Drawing.Point(290, 9);
            this.txtIdCompany.MaxLength = 32767;
            this.txtIdCompany.Name = "txtIdCompany";
            this.txtIdCompany.PasswordChar = '\0';
            this.txtIdCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdCompany.SelectedText = "";
            this.txtIdCompany.SelectionLength = 0;
            this.txtIdCompany.SelectionStart = 0;
            this.txtIdCompany.ShortcutsEnabled = true;
            this.txtIdCompany.Size = new System.Drawing.Size(210, 23);
            this.txtIdCompany.TabIndex = 10;
            this.txtIdCompany.UseSelectable = true;
            this.txtIdCompany.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdCompany.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmailCompany
            // 
            this.lblEmailCompany.AutoSize = true;
            this.lblEmailCompany.Location = new System.Drawing.Point(130, 183);
            this.lblEmailCompany.Name = "lblEmailCompany";
            this.lblEmailCompany.Size = new System.Drawing.Size(105, 19);
            this.lblEmailCompany.TabIndex = 9;
            this.lblEmailCompany.Text = "Email Company:";
            // 
            // lblWebSiteCompany
            // 
            this.lblWebSiteCompany.AutoSize = true;
            this.lblWebSiteCompany.Location = new System.Drawing.Point(130, 154);
            this.lblWebSiteCompany.Name = "lblWebSiteCompany";
            this.lblWebSiteCompany.Size = new System.Drawing.Size(121, 19);
            this.lblWebSiteCompany.TabIndex = 8;
            this.lblWebSiteCompany.Text = "WebSite Company:";
            // 
            // lblPhoneNumberCompany
            // 
            this.lblPhoneNumberCompany.AutoSize = true;
            this.lblPhoneNumberCompany.Location = new System.Drawing.Point(130, 125);
            this.lblPhoneNumberCompany.Name = "lblPhoneNumberCompany";
            this.lblPhoneNumberCompany.Size = new System.Drawing.Size(163, 19);
            this.lblPhoneNumberCompany.TabIndex = 7;
            this.lblPhoneNumberCompany.Text = "Phone Number Company:";
            // 
            // lblPostalCodeCompany
            // 
            this.lblPostalCodeCompany.AutoSize = true;
            this.lblPostalCodeCompany.Location = new System.Drawing.Point(130, 96);
            this.lblPostalCodeCompany.Name = "lblPostalCodeCompany";
            this.lblPostalCodeCompany.Size = new System.Drawing.Size(143, 19);
            this.lblPostalCodeCompany.TabIndex = 6;
            this.lblPostalCodeCompany.Text = "Postal Code Company:";
            // 
            // lblAdressCompany
            // 
            this.lblAdressCompany.AutoSize = true;
            this.lblAdressCompany.Location = new System.Drawing.Point(130, 67);
            this.lblAdressCompany.Name = "lblAdressCompany";
            this.lblAdressCompany.Size = new System.Drawing.Size(112, 19);
            this.lblAdressCompany.TabIndex = 5;
            this.lblAdressCompany.Text = "Adress Company:";
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Location = new System.Drawing.Point(130, 38);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(109, 19);
            this.lblNameCompany.TabIndex = 4;
            this.lblNameCompany.Text = "Name Company:";
            // 
            // lblIdCompany
            // 
            this.lblIdCompany.AutoSize = true;
            this.lblIdCompany.Location = new System.Drawing.Point(132, 9);
            this.lblIdCompany.Name = "lblIdCompany";
            this.lblIdCompany.Size = new System.Drawing.Size(84, 19);
            this.lblIdCompany.TabIndex = 3;
            this.lblIdCompany.Text = "Id Company:";
            // 
            // pctPhotoCompany
            // 
            this.pctPhotoCompany.Location = new System.Drawing.Point(14, 13);
            this.pctPhotoCompany.Name = "pctPhotoCompany";
            this.pctPhotoCompany.Size = new System.Drawing.Size(101, 133);
            this.pctPhotoCompany.TabIndex = 2;
            this.pctPhotoCompany.TabStop = false;
            this.pctPhotoCompany.Click += new System.EventHandler(this.pctPhotoCompany_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(536, 296);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(617, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(698, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(779, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 378);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlDatosCompany);
            this.Controls.Add(this.grdDatosCompany);
            this.Name = "FrmCompany";
            this.Text = "FrmCompany";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.pnlDatosCompany.ResumeLayout(false);
            this.pnlDatosCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatosCompany;
        private MetroFramework.Controls.MetroPanel pnlDatosCompany;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtEmailCompany;
        private MetroFramework.Controls.MetroTextBox txtWebSiteCompany;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumberCompany;
        private MetroFramework.Controls.MetroTextBox txtPostalCodeCompany;
        private MetroFramework.Controls.MetroTextBox txtAdressCompany;
        private MetroFramework.Controls.MetroTextBox txtNameCompany;
        private MetroFramework.Controls.MetroTextBox txtIdCompany;
        private MetroFramework.Controls.MetroLabel lblEmailCompany;
        private MetroFramework.Controls.MetroLabel lblWebSiteCompany;
        private MetroFramework.Controls.MetroLabel lblPhoneNumberCompany;
        private MetroFramework.Controls.MetroLabel lblPostalCodeCompany;
        private MetroFramework.Controls.MetroLabel lblAdressCompany;
        private MetroFramework.Controls.MetroLabel lblNameCompany;
        private MetroFramework.Controls.MetroLabel lblIdCompany;
        private System.Windows.Forms.PictureBox pctPhotoCompany;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webSiteCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoCompanyDataGridViewTextBoxColumn;
    }
}