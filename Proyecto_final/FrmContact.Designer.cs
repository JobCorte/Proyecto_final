
namespace Proyecto_final
{
    partial class FrmContact
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
            this.grdDatosContact = new MetroFramework.Controls.MetroGrid();
            this.idContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDatosContact = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtDepartmentContact = new MetroFramework.Controls.MetroTextBox();
            this.txtEmailContact = new MetroFramework.Controls.MetroTextBox();
            this.txtCellphoneContact = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNumberContact = new MetroFramework.Controls.MetroTextBox();
            this.txtLastNameContact = new MetroFramework.Controls.MetroTextBox();
            this.txtFirtsNameContact = new MetroFramework.Controls.MetroTextBox();
            this.txtIdContact = new MetroFramework.Controls.MetroTextBox();
            this.lblDepartmentContact = new MetroFramework.Controls.MetroLabel();
            this.lblEmailContact = new MetroFramework.Controls.MetroLabel();
            this.lblCellphoneContact = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNumberContact = new MetroFramework.Controls.MetroLabel();
            this.lblLastNameContact = new MetroFramework.Controls.MetroLabel();
            this.ldlFirstNameContact = new MetroFramework.Controls.MetroLabel();
            this.lblIdContact = new MetroFramework.Controls.MetroLabel();
            this.pctPhotoContact = new System.Windows.Forms.PictureBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.pnlDatosContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosContact
            // 
            this.grdDatosContact.AllowUserToResizeRows = false;
            this.grdDatosContact.AutoGenerateColumns = false;
            this.grdDatosContact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatosContact.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatosContact.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosContact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatosContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContactDataGridViewTextBoxColumn,
            this.fullnameContactDataGridViewTextBoxColumn,
            this.firstNameContactDataGridViewTextBoxColumn,
            this.lastNameContactDataGridViewTextBoxColumn,
            this.phoneNumberContactDataGridViewTextBoxColumn,
            this.cellphoneContactDataGridViewTextBoxColumn,
            this.photoContactDataGridViewTextBoxColumn,
            this.emailContactDataGridViewTextBoxColumn,
            this.departmentContactDataGridViewTextBoxColumn});
            this.grdDatosContact.DataSource = this.contactBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatosContact.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatosContact.EnableHeadersVisualStyles = false;
            this.grdDatosContact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatosContact.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosContact.Location = new System.Drawing.Point(23, 63);
            this.grdDatosContact.Name = "grdDatosContact";
            this.grdDatosContact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosContact.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatosContact.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatosContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatosContact.Size = new System.Drawing.Size(374, 342);
            this.grdDatosContact.TabIndex = 0;
            this.grdDatosContact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosContact_CellContentClick);
            // 
            // idContactDataGridViewTextBoxColumn
            // 
            this.idContactDataGridViewTextBoxColumn.DataPropertyName = "IdContact";
            this.idContactDataGridViewTextBoxColumn.HeaderText = "IdContact";
            this.idContactDataGridViewTextBoxColumn.Name = "idContactDataGridViewTextBoxColumn";
            // 
            // fullnameContactDataGridViewTextBoxColumn
            // 
            this.fullnameContactDataGridViewTextBoxColumn.DataPropertyName = "FullnameContact";
            this.fullnameContactDataGridViewTextBoxColumn.HeaderText = "FullnameContact";
            this.fullnameContactDataGridViewTextBoxColumn.Name = "fullnameContactDataGridViewTextBoxColumn";
            this.fullnameContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameContactDataGridViewTextBoxColumn
            // 
            this.firstNameContactDataGridViewTextBoxColumn.DataPropertyName = "FirstNameContact";
            this.firstNameContactDataGridViewTextBoxColumn.HeaderText = "FirstNameContact";
            this.firstNameContactDataGridViewTextBoxColumn.Name = "firstNameContactDataGridViewTextBoxColumn";
            // 
            // lastNameContactDataGridViewTextBoxColumn
            // 
            this.lastNameContactDataGridViewTextBoxColumn.DataPropertyName = "LastNameContact";
            this.lastNameContactDataGridViewTextBoxColumn.HeaderText = "LastNameContact";
            this.lastNameContactDataGridViewTextBoxColumn.Name = "lastNameContactDataGridViewTextBoxColumn";
            // 
            // phoneNumberContactDataGridViewTextBoxColumn
            // 
            this.phoneNumberContactDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberContact";
            this.phoneNumberContactDataGridViewTextBoxColumn.HeaderText = "PhoneNumberContact";
            this.phoneNumberContactDataGridViewTextBoxColumn.Name = "phoneNumberContactDataGridViewTextBoxColumn";
            // 
            // cellphoneContactDataGridViewTextBoxColumn
            // 
            this.cellphoneContactDataGridViewTextBoxColumn.DataPropertyName = "CellphoneContact";
            this.cellphoneContactDataGridViewTextBoxColumn.HeaderText = "CellphoneContact";
            this.cellphoneContactDataGridViewTextBoxColumn.Name = "cellphoneContactDataGridViewTextBoxColumn";
            // 
            // photoContactDataGridViewTextBoxColumn
            // 
            this.photoContactDataGridViewTextBoxColumn.DataPropertyName = "PhotoContact";
            this.photoContactDataGridViewTextBoxColumn.HeaderText = "PhotoContact";
            this.photoContactDataGridViewTextBoxColumn.Name = "photoContactDataGridViewTextBoxColumn";
            // 
            // emailContactDataGridViewTextBoxColumn
            // 
            this.emailContactDataGridViewTextBoxColumn.DataPropertyName = "EmailContact";
            this.emailContactDataGridViewTextBoxColumn.HeaderText = "EmailContact";
            this.emailContactDataGridViewTextBoxColumn.Name = "emailContactDataGridViewTextBoxColumn";
            // 
            // departmentContactDataGridViewTextBoxColumn
            // 
            this.departmentContactDataGridViewTextBoxColumn.DataPropertyName = "DepartmentContact";
            this.departmentContactDataGridViewTextBoxColumn.HeaderText = "DepartmentContact";
            this.departmentContactDataGridViewTextBoxColumn.Name = "departmentContactDataGridViewTextBoxColumn";
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(Proyecto_final.Entidades.Contact);
            // 
            // pnlDatosContact
            // 
            this.pnlDatosContact.Controls.Add(this.btnSearch);
            this.pnlDatosContact.Controls.Add(this.txtDepartmentContact);
            this.pnlDatosContact.Controls.Add(this.txtEmailContact);
            this.pnlDatosContact.Controls.Add(this.txtCellphoneContact);
            this.pnlDatosContact.Controls.Add(this.txtPhoneNumberContact);
            this.pnlDatosContact.Controls.Add(this.txtLastNameContact);
            this.pnlDatosContact.Controls.Add(this.txtFirtsNameContact);
            this.pnlDatosContact.Controls.Add(this.txtIdContact);
            this.pnlDatosContact.Controls.Add(this.lblDepartmentContact);
            this.pnlDatosContact.Controls.Add(this.lblEmailContact);
            this.pnlDatosContact.Controls.Add(this.lblCellphoneContact);
            this.pnlDatosContact.Controls.Add(this.lblPhoneNumberContact);
            this.pnlDatosContact.Controls.Add(this.lblLastNameContact);
            this.pnlDatosContact.Controls.Add(this.ldlFirstNameContact);
            this.pnlDatosContact.Controls.Add(this.lblIdContact);
            this.pnlDatosContact.Controls.Add(this.pctPhotoContact);
            this.pnlDatosContact.HorizontalScrollbarBarColor = true;
            this.pnlDatosContact.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatosContact.HorizontalScrollbarSize = 10;
            this.pnlDatosContact.Location = new System.Drawing.Point(403, 63);
            this.pnlDatosContact.Name = "pnlDatosContact";
            this.pnlDatosContact.Size = new System.Drawing.Size(524, 237);
            this.pnlDatosContact.TabIndex = 1;
            this.pnlDatosContact.VerticalScrollbarBarColor = true;
            this.pnlDatosContact.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatosContact.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDepartmentContact
            // 
            // 
            // 
            // 
            this.txtDepartmentContact.CustomButton.Image = null;
            this.txtDepartmentContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtDepartmentContact.CustomButton.Name = "";
            this.txtDepartmentContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDepartmentContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDepartmentContact.CustomButton.TabIndex = 1;
            this.txtDepartmentContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDepartmentContact.CustomButton.UseSelectable = true;
            this.txtDepartmentContact.CustomButton.Visible = false;
            this.txtDepartmentContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "DepartmentContact", true));
            this.txtDepartmentContact.Lines = new string[0];
            this.txtDepartmentContact.Location = new System.Drawing.Point(283, 193);
            this.txtDepartmentContact.MaxLength = 32767;
            this.txtDepartmentContact.Name = "txtDepartmentContact";
            this.txtDepartmentContact.PasswordChar = '\0';
            this.txtDepartmentContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDepartmentContact.SelectedText = "";
            this.txtDepartmentContact.SelectionLength = 0;
            this.txtDepartmentContact.SelectionStart = 0;
            this.txtDepartmentContact.ShortcutsEnabled = true;
            this.txtDepartmentContact.Size = new System.Drawing.Size(215, 23);
            this.txtDepartmentContact.TabIndex = 16;
            this.txtDepartmentContact.UseSelectable = true;
            this.txtDepartmentContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDepartmentContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmailContact
            // 
            // 
            // 
            // 
            this.txtEmailContact.CustomButton.Image = null;
            this.txtEmailContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtEmailContact.CustomButton.Name = "";
            this.txtEmailContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailContact.CustomButton.TabIndex = 1;
            this.txtEmailContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailContact.CustomButton.UseSelectable = true;
            this.txtEmailContact.CustomButton.Visible = false;
            this.txtEmailContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "EmailContact", true));
            this.txtEmailContact.Lines = new string[0];
            this.txtEmailContact.Location = new System.Drawing.Point(283, 165);
            this.txtEmailContact.MaxLength = 32767;
            this.txtEmailContact.Name = "txtEmailContact";
            this.txtEmailContact.PasswordChar = '\0';
            this.txtEmailContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailContact.SelectedText = "";
            this.txtEmailContact.SelectionLength = 0;
            this.txtEmailContact.SelectionStart = 0;
            this.txtEmailContact.ShortcutsEnabled = true;
            this.txtEmailContact.Size = new System.Drawing.Size(215, 23);
            this.txtEmailContact.TabIndex = 15;
            this.txtEmailContact.UseSelectable = true;
            this.txtEmailContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCellphoneContact
            // 
            // 
            // 
            // 
            this.txtCellphoneContact.CustomButton.Image = null;
            this.txtCellphoneContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtCellphoneContact.CustomButton.Name = "";
            this.txtCellphoneContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellphoneContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellphoneContact.CustomButton.TabIndex = 1;
            this.txtCellphoneContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellphoneContact.CustomButton.UseSelectable = true;
            this.txtCellphoneContact.CustomButton.Visible = false;
            this.txtCellphoneContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "CellphoneContact", true));
            this.txtCellphoneContact.Lines = new string[0];
            this.txtCellphoneContact.Location = new System.Drawing.Point(283, 135);
            this.txtCellphoneContact.MaxLength = 32767;
            this.txtCellphoneContact.Name = "txtCellphoneContact";
            this.txtCellphoneContact.PasswordChar = '\0';
            this.txtCellphoneContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellphoneContact.SelectedText = "";
            this.txtCellphoneContact.SelectionLength = 0;
            this.txtCellphoneContact.SelectionStart = 0;
            this.txtCellphoneContact.ShortcutsEnabled = true;
            this.txtCellphoneContact.Size = new System.Drawing.Size(215, 23);
            this.txtCellphoneContact.TabIndex = 14;
            this.txtCellphoneContact.UseSelectable = true;
            this.txtCellphoneContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellphoneContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNumberContact
            // 
            // 
            // 
            // 
            this.txtPhoneNumberContact.CustomButton.Image = null;
            this.txtPhoneNumberContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtPhoneNumberContact.CustomButton.Name = "";
            this.txtPhoneNumberContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumberContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumberContact.CustomButton.TabIndex = 1;
            this.txtPhoneNumberContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumberContact.CustomButton.UseSelectable = true;
            this.txtPhoneNumberContact.CustomButton.Visible = false;
            this.txtPhoneNumberContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "PhoneNumberContact", true));
            this.txtPhoneNumberContact.Lines = new string[0];
            this.txtPhoneNumberContact.Location = new System.Drawing.Point(283, 101);
            this.txtPhoneNumberContact.MaxLength = 32767;
            this.txtPhoneNumberContact.Name = "txtPhoneNumberContact";
            this.txtPhoneNumberContact.PasswordChar = '\0';
            this.txtPhoneNumberContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumberContact.SelectedText = "";
            this.txtPhoneNumberContact.SelectionLength = 0;
            this.txtPhoneNumberContact.SelectionStart = 0;
            this.txtPhoneNumberContact.ShortcutsEnabled = true;
            this.txtPhoneNumberContact.Size = new System.Drawing.Size(215, 23);
            this.txtPhoneNumberContact.TabIndex = 13;
            this.txtPhoneNumberContact.UseSelectable = true;
            this.txtPhoneNumberContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumberContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastNameContact
            // 
            // 
            // 
            // 
            this.txtLastNameContact.CustomButton.Image = null;
            this.txtLastNameContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtLastNameContact.CustomButton.Name = "";
            this.txtLastNameContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastNameContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastNameContact.CustomButton.TabIndex = 1;
            this.txtLastNameContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastNameContact.CustomButton.UseSelectable = true;
            this.txtLastNameContact.CustomButton.Visible = false;
            this.txtLastNameContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "LastNameContact", true));
            this.txtLastNameContact.Lines = new string[0];
            this.txtLastNameContact.Location = new System.Drawing.Point(283, 72);
            this.txtLastNameContact.MaxLength = 32767;
            this.txtLastNameContact.Name = "txtLastNameContact";
            this.txtLastNameContact.PasswordChar = '\0';
            this.txtLastNameContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastNameContact.SelectedText = "";
            this.txtLastNameContact.SelectionLength = 0;
            this.txtLastNameContact.SelectionStart = 0;
            this.txtLastNameContact.ShortcutsEnabled = true;
            this.txtLastNameContact.Size = new System.Drawing.Size(215, 23);
            this.txtLastNameContact.TabIndex = 12;
            this.txtLastNameContact.UseSelectable = true;
            this.txtLastNameContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastNameContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirtsNameContact
            // 
            // 
            // 
            // 
            this.txtFirtsNameContact.CustomButton.Image = null;
            this.txtFirtsNameContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtFirtsNameContact.CustomButton.Name = "";
            this.txtFirtsNameContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirtsNameContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirtsNameContact.CustomButton.TabIndex = 1;
            this.txtFirtsNameContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirtsNameContact.CustomButton.UseSelectable = true;
            this.txtFirtsNameContact.CustomButton.Visible = false;
            this.txtFirtsNameContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "FirstNameContact", true));
            this.txtFirtsNameContact.Lines = new string[0];
            this.txtFirtsNameContact.Location = new System.Drawing.Point(283, 42);
            this.txtFirtsNameContact.MaxLength = 32767;
            this.txtFirtsNameContact.Name = "txtFirtsNameContact";
            this.txtFirtsNameContact.PasswordChar = '\0';
            this.txtFirtsNameContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirtsNameContact.SelectedText = "";
            this.txtFirtsNameContact.SelectionLength = 0;
            this.txtFirtsNameContact.SelectionStart = 0;
            this.txtFirtsNameContact.ShortcutsEnabled = true;
            this.txtFirtsNameContact.Size = new System.Drawing.Size(215, 23);
            this.txtFirtsNameContact.TabIndex = 11;
            this.txtFirtsNameContact.UseSelectable = true;
            this.txtFirtsNameContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirtsNameContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIdContact
            // 
            // 
            // 
            // 
            this.txtIdContact.CustomButton.Image = null;
            this.txtIdContact.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtIdContact.CustomButton.Name = "";
            this.txtIdContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdContact.CustomButton.TabIndex = 1;
            this.txtIdContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdContact.CustomButton.UseSelectable = true;
            this.txtIdContact.CustomButton.Visible = false;
            this.txtIdContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "IdContact", true));
            this.txtIdContact.Lines = new string[0];
            this.txtIdContact.Location = new System.Drawing.Point(283, 13);
            this.txtIdContact.MaxLength = 32767;
            this.txtIdContact.Name = "txtIdContact";
            this.txtIdContact.PasswordChar = '\0';
            this.txtIdContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdContact.SelectedText = "";
            this.txtIdContact.SelectionLength = 0;
            this.txtIdContact.SelectionStart = 0;
            this.txtIdContact.ShortcutsEnabled = true;
            this.txtIdContact.Size = new System.Drawing.Size(215, 23);
            this.txtIdContact.TabIndex = 10;
            this.txtIdContact.UseSelectable = true;
            this.txtIdContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDepartmentContact
            // 
            this.lblDepartmentContact.AutoSize = true;
            this.lblDepartmentContact.Location = new System.Drawing.Point(120, 193);
            this.lblDepartmentContact.Name = "lblDepartmentContact";
            this.lblDepartmentContact.Size = new System.Drawing.Size(132, 19);
            this.lblDepartmentContact.TabIndex = 9;
            this.lblDepartmentContact.Text = "Department Contact:";
            // 
            // lblEmailContact
            // 
            this.lblEmailContact.AutoSize = true;
            this.lblEmailContact.Location = new System.Drawing.Point(120, 165);
            this.lblEmailContact.Name = "lblEmailContact";
            this.lblEmailContact.Size = new System.Drawing.Size(93, 19);
            this.lblEmailContact.TabIndex = 8;
            this.lblEmailContact.Text = "Email Contact:";
            // 
            // lblCellphoneContact
            // 
            this.lblCellphoneContact.AutoSize = true;
            this.lblCellphoneContact.Location = new System.Drawing.Point(120, 135);
            this.lblCellphoneContact.Name = "lblCellphoneContact";
            this.lblCellphoneContact.Size = new System.Drawing.Size(120, 19);
            this.lblCellphoneContact.TabIndex = 7;
            this.lblCellphoneContact.Text = "Cellphone Contact:";
            // 
            // lblPhoneNumberContact
            // 
            this.lblPhoneNumberContact.AutoSize = true;
            this.lblPhoneNumberContact.Location = new System.Drawing.Point(120, 101);
            this.lblPhoneNumberContact.Name = "lblPhoneNumberContact";
            this.lblPhoneNumberContact.Size = new System.Drawing.Size(151, 19);
            this.lblPhoneNumberContact.TabIndex = 6;
            this.lblPhoneNumberContact.Text = "Phone Number Contact:";
            // 
            // lblLastNameContact
            // 
            this.lblLastNameContact.AutoSize = true;
            this.lblLastNameContact.Location = new System.Drawing.Point(120, 72);
            this.lblLastNameContact.Name = "lblLastNameContact";
            this.lblLastNameContact.Size = new System.Drawing.Size(123, 19);
            this.lblLastNameContact.TabIndex = 5;
            this.lblLastNameContact.Text = "Last Name Contact:";
            // 
            // ldlFirstNameContact
            // 
            this.ldlFirstNameContact.AutoSize = true;
            this.ldlFirstNameContact.Location = new System.Drawing.Point(120, 42);
            this.ldlFirstNameContact.Name = "ldlFirstNameContact";
            this.ldlFirstNameContact.Size = new System.Drawing.Size(125, 19);
            this.ldlFirstNameContact.TabIndex = 4;
            this.ldlFirstNameContact.Text = "First Name Contact:";
            // 
            // lblIdContact
            // 
            this.lblIdContact.AutoSize = true;
            this.lblIdContact.Location = new System.Drawing.Point(120, 13);
            this.lblIdContact.Name = "lblIdContact";
            this.lblIdContact.Size = new System.Drawing.Size(72, 19);
            this.lblIdContact.TabIndex = 3;
            this.lblIdContact.Text = "Id Contact:";
            // 
            // pctPhotoContact
            // 
            this.pctPhotoContact.Location = new System.Drawing.Point(16, 13);
            this.pctPhotoContact.Name = "pctPhotoContact";
            this.pctPhotoContact.Size = new System.Drawing.Size(98, 118);
            this.pctPhotoContact.TabIndex = 2;
            this.pctPhotoContact.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(467, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(548, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(629, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(710, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(791, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 430);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlDatosContact);
            this.Controls.Add(this.grdDatosContact);
            this.Name = "FrmContact";
            this.Text = "FrmContact";
            this.Load += new System.EventHandler(this.FrmContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.pnlDatosContact.ResumeLayout(false);
            this.pnlDatosContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoContact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatosContact;
        private MetroFramework.Controls.MetroPanel pnlDatosContact;
        private MetroFramework.Controls.MetroTextBox txtIdContact;
        private MetroFramework.Controls.MetroLabel lblDepartmentContact;
        private MetroFramework.Controls.MetroLabel lblEmailContact;
        private MetroFramework.Controls.MetroLabel lblCellphoneContact;
        private MetroFramework.Controls.MetroLabel lblPhoneNumberContact;
        private MetroFramework.Controls.MetroLabel lblLastNameContact;
        private MetroFramework.Controls.MetroLabel ldlFirstNameContact;
        private MetroFramework.Controls.MetroLabel lblIdContact;
        private System.Windows.Forms.PictureBox pctPhotoContact;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtDepartmentContact;
        private MetroFramework.Controls.MetroTextBox txtEmailContact;
        private MetroFramework.Controls.MetroTextBox txtCellphoneContact;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumberContact;
        private MetroFramework.Controls.MetroTextBox txtLastNameContact;
        private MetroFramework.Controls.MetroTextBox txtFirtsNameContact;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentContactDataGridViewTextBoxColumn;
    }
}