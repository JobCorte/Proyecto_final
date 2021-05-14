
namespace Proyecto_final
{
    partial class FrmMajor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatosMajor = new MetroFramework.Controls.MetroGrid();
            this.idMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pctPhotoMajor = new System.Windows.Forms.PictureBox();
            this.pnlDatosMajor = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtEmailMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblEmailMajor = new MetroFramework.Controls.MetroLabel();
            this.txtCellPhoneNumberMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblCellPhoneNumberMajor = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumberMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblPhoneNumberMajor = new MetroFramework.Controls.MetroLabel();
            this.txtNameMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblNameMajor = new MetroFramework.Controls.MetroLabel();
            this.txtIdMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblIdMajor = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoMajor)).BeginInit();
            this.pnlDatosMajor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatosMajor
            // 
            this.grdDatosMajor.AllowUserToResizeRows = false;
            this.grdDatosMajor.AutoGenerateColumns = false;
            this.grdDatosMajor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosMajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatosMajor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatosMajor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosMajor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatosMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMajor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMajorDataGridViewTextBoxColumn,
            this.nameMajorDataGridViewTextBoxColumn,
            this.phoneNumberMajorDataGridViewTextBoxColumn,
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn,
            this.photoMajorDataGridViewTextBoxColumn,
            this.emailMajorDataGridViewTextBoxColumn,
            this.descriptionMajorDataGridViewTextBoxColumn});
            this.grdDatosMajor.DataSource = this.majorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatosMajor.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatosMajor.EnableHeadersVisualStyles = false;
            this.grdDatosMajor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatosMajor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosMajor.Location = new System.Drawing.Point(23, 63);
            this.grdDatosMajor.Name = "grdDatosMajor";
            this.grdDatosMajor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosMajor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatosMajor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatosMajor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatosMajor.Size = new System.Drawing.Size(422, 259);
            this.grdDatosMajor.TabIndex = 0;
            this.grdDatosMajor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosMajor_CellContentClick);
            // 
            // idMajorDataGridViewTextBoxColumn
            // 
            this.idMajorDataGridViewTextBoxColumn.DataPropertyName = "IdMajor";
            this.idMajorDataGridViewTextBoxColumn.HeaderText = "IdMajor";
            this.idMajorDataGridViewTextBoxColumn.Name = "idMajorDataGridViewTextBoxColumn";
            // 
            // nameMajorDataGridViewTextBoxColumn
            // 
            this.nameMajorDataGridViewTextBoxColumn.DataPropertyName = "NameMajor";
            this.nameMajorDataGridViewTextBoxColumn.HeaderText = "NameMajor";
            this.nameMajorDataGridViewTextBoxColumn.Name = "nameMajorDataGridViewTextBoxColumn";
            // 
            // phoneNumberMajorDataGridViewTextBoxColumn
            // 
            this.phoneNumberMajorDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumberMajor";
            this.phoneNumberMajorDataGridViewTextBoxColumn.HeaderText = "PhoneNumberMajor";
            this.phoneNumberMajorDataGridViewTextBoxColumn.Name = "phoneNumberMajorDataGridViewTextBoxColumn";
            // 
            // cellPhoneNumberMajorDataGridViewTextBoxColumn
            // 
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn.DataPropertyName = "CellPhoneNumberMajor";
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn.HeaderText = "CellPhoneNumberMajor";
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn.Name = "cellPhoneNumberMajorDataGridViewTextBoxColumn";
            // 
            // photoMajorDataGridViewTextBoxColumn
            // 
            this.photoMajorDataGridViewTextBoxColumn.DataPropertyName = "PhotoMajor";
            this.photoMajorDataGridViewTextBoxColumn.HeaderText = "PhotoMajor";
            this.photoMajorDataGridViewTextBoxColumn.Name = "photoMajorDataGridViewTextBoxColumn";
            // 
            // emailMajorDataGridViewTextBoxColumn
            // 
            this.emailMajorDataGridViewTextBoxColumn.DataPropertyName = "EmailMajor";
            this.emailMajorDataGridViewTextBoxColumn.HeaderText = "EmailMajor";
            this.emailMajorDataGridViewTextBoxColumn.Name = "emailMajorDataGridViewTextBoxColumn";
            // 
            // descriptionMajorDataGridViewTextBoxColumn
            // 
            this.descriptionMajorDataGridViewTextBoxColumn.DataPropertyName = "DescriptionMajor";
            this.descriptionMajorDataGridViewTextBoxColumn.HeaderText = "DescriptionMajor";
            this.descriptionMajorDataGridViewTextBoxColumn.Name = "descriptionMajorDataGridViewTextBoxColumn";
            this.descriptionMajorDataGridViewTextBoxColumn.Visible = false;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(Proyecto_final.Entidades.Major);
            // 
            // pctPhotoMajor
            // 
            this.pctPhotoMajor.Location = new System.Drawing.Point(15, 18);
            this.pctPhotoMajor.Name = "pctPhotoMajor";
            this.pctPhotoMajor.Size = new System.Drawing.Size(126, 138);
            this.pctPhotoMajor.TabIndex = 3;
            this.pctPhotoMajor.TabStop = false;
            this.pctPhotoMajor.Click += new System.EventHandler(this.pctPhotoMajor_Click);
            // 
            // pnlDatosMajor
            // 
            this.pnlDatosMajor.Controls.Add(this.btnSearch);
            this.pnlDatosMajor.Controls.Add(this.txtEmailMajor);
            this.pnlDatosMajor.Controls.Add(this.lblEmailMajor);
            this.pnlDatosMajor.Controls.Add(this.txtCellPhoneNumberMajor);
            this.pnlDatosMajor.Controls.Add(this.lblCellPhoneNumberMajor);
            this.pnlDatosMajor.Controls.Add(this.txtPhoneNumberMajor);
            this.pnlDatosMajor.Controls.Add(this.lblPhoneNumberMajor);
            this.pnlDatosMajor.Controls.Add(this.txtNameMajor);
            this.pnlDatosMajor.Controls.Add(this.lblNameMajor);
            this.pnlDatosMajor.Controls.Add(this.txtIdMajor);
            this.pnlDatosMajor.Controls.Add(this.lblIdMajor);
            this.pnlDatosMajor.Controls.Add(this.pctPhotoMajor);
            this.pnlDatosMajor.HorizontalScrollbarBarColor = true;
            this.pnlDatosMajor.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatosMajor.HorizontalScrollbarSize = 10;
            this.pnlDatosMajor.Location = new System.Drawing.Point(451, 63);
            this.pnlDatosMajor.Name = "pnlDatosMajor";
            this.pnlDatosMajor.Size = new System.Drawing.Size(532, 230);
            this.pnlDatosMajor.TabIndex = 4;
            this.pnlDatosMajor.VerticalScrollbarBarColor = true;
            this.pnlDatosMajor.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatosMajor.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(25, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmailMajor
            // 
            // 
            // 
            // 
            this.txtEmailMajor.CustomButton.Image = null;
            this.txtEmailMajor.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtEmailMajor.CustomButton.Name = "";
            this.txtEmailMajor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailMajor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailMajor.CustomButton.TabIndex = 1;
            this.txtEmailMajor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailMajor.CustomButton.UseSelectable = true;
            this.txtEmailMajor.CustomButton.Visible = false;
            this.txtEmailMajor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "EmailMajor", true));
            this.txtEmailMajor.Lines = new string[0];
            this.txtEmailMajor.Location = new System.Drawing.Point(339, 133);
            this.txtEmailMajor.MaxLength = 32767;
            this.txtEmailMajor.Name = "txtEmailMajor";
            this.txtEmailMajor.PasswordChar = '\0';
            this.txtEmailMajor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailMajor.SelectedText = "";
            this.txtEmailMajor.SelectionLength = 0;
            this.txtEmailMajor.SelectionStart = 0;
            this.txtEmailMajor.ShortcutsEnabled = true;
            this.txtEmailMajor.Size = new System.Drawing.Size(153, 23);
            this.txtEmailMajor.TabIndex = 13;
            this.txtEmailMajor.UseSelectable = true;
            this.txtEmailMajor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailMajor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmailMajor
            // 
            this.lblEmailMajor.AutoSize = true;
            this.lblEmailMajor.Location = new System.Drawing.Point(160, 131);
            this.lblEmailMajor.Name = "lblEmailMajor";
            this.lblEmailMajor.Size = new System.Drawing.Size(80, 19);
            this.lblEmailMajor.TabIndex = 12;
            this.lblEmailMajor.Text = "Email Major";
            // 
            // txtCellPhoneNumberMajor
            // 
            // 
            // 
            // 
            this.txtCellPhoneNumberMajor.CustomButton.Image = null;
            this.txtCellPhoneNumberMajor.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtCellPhoneNumberMajor.CustomButton.Name = "";
            this.txtCellPhoneNumberMajor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellPhoneNumberMajor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellPhoneNumberMajor.CustomButton.TabIndex = 1;
            this.txtCellPhoneNumberMajor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellPhoneNumberMajor.CustomButton.UseSelectable = true;
            this.txtCellPhoneNumberMajor.CustomButton.Visible = false;
            this.txtCellPhoneNumberMajor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "CellPhoneNumberMajor", true));
            this.txtCellPhoneNumberMajor.Lines = new string[0];
            this.txtCellPhoneNumberMajor.Location = new System.Drawing.Point(339, 103);
            this.txtCellPhoneNumberMajor.MaxLength = 32767;
            this.txtCellPhoneNumberMajor.Name = "txtCellPhoneNumberMajor";
            this.txtCellPhoneNumberMajor.PasswordChar = '\0';
            this.txtCellPhoneNumberMajor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellPhoneNumberMajor.SelectedText = "";
            this.txtCellPhoneNumberMajor.SelectionLength = 0;
            this.txtCellPhoneNumberMajor.SelectionStart = 0;
            this.txtCellPhoneNumberMajor.ShortcutsEnabled = true;
            this.txtCellPhoneNumberMajor.Size = new System.Drawing.Size(153, 23);
            this.txtCellPhoneNumberMajor.TabIndex = 11;
            this.txtCellPhoneNumberMajor.UseSelectable = true;
            this.txtCellPhoneNumberMajor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellPhoneNumberMajor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCellPhoneNumberMajor
            // 
            this.lblCellPhoneNumberMajor.AutoSize = true;
            this.lblCellPhoneNumberMajor.Location = new System.Drawing.Point(160, 101);
            this.lblCellPhoneNumberMajor.Name = "lblCellPhoneNumberMajor";
            this.lblCellPhoneNumberMajor.Size = new System.Drawing.Size(160, 19);
            this.lblCellPhoneNumberMajor.TabIndex = 10;
            this.lblCellPhoneNumberMajor.Text = "CellPhone Number Major";
            // 
            // txtPhoneNumberMajor
            // 
            // 
            // 
            // 
            this.txtPhoneNumberMajor.CustomButton.Image = null;
            this.txtPhoneNumberMajor.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtPhoneNumberMajor.CustomButton.Name = "";
            this.txtPhoneNumberMajor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumberMajor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumberMajor.CustomButton.TabIndex = 1;
            this.txtPhoneNumberMajor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumberMajor.CustomButton.UseSelectable = true;
            this.txtPhoneNumberMajor.CustomButton.Visible = false;
            this.txtPhoneNumberMajor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "PhoneNumberMajor", true));
            this.txtPhoneNumberMajor.Lines = new string[0];
            this.txtPhoneNumberMajor.Location = new System.Drawing.Point(339, 72);
            this.txtPhoneNumberMajor.MaxLength = 32767;
            this.txtPhoneNumberMajor.Name = "txtPhoneNumberMajor";
            this.txtPhoneNumberMajor.PasswordChar = '\0';
            this.txtPhoneNumberMajor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumberMajor.SelectedText = "";
            this.txtPhoneNumberMajor.SelectionLength = 0;
            this.txtPhoneNumberMajor.SelectionStart = 0;
            this.txtPhoneNumberMajor.ShortcutsEnabled = true;
            this.txtPhoneNumberMajor.Size = new System.Drawing.Size(153, 23);
            this.txtPhoneNumberMajor.TabIndex = 9;
            this.txtPhoneNumberMajor.UseSelectable = true;
            this.txtPhoneNumberMajor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumberMajor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPhoneNumberMajor
            // 
            this.lblPhoneNumberMajor.AutoSize = true;
            this.lblPhoneNumberMajor.Location = new System.Drawing.Point(160, 70);
            this.lblPhoneNumberMajor.Name = "lblPhoneNumberMajor";
            this.lblPhoneNumberMajor.Size = new System.Drawing.Size(138, 19);
            this.lblPhoneNumberMajor.TabIndex = 8;
            this.lblPhoneNumberMajor.Text = "Phone Number Major";
            // 
            // txtNameMajor
            // 
            // 
            // 
            // 
            this.txtNameMajor.CustomButton.Image = null;
            this.txtNameMajor.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtNameMajor.CustomButton.Name = "";
            this.txtNameMajor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameMajor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameMajor.CustomButton.TabIndex = 1;
            this.txtNameMajor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameMajor.CustomButton.UseSelectable = true;
            this.txtNameMajor.CustomButton.Visible = false;
            this.txtNameMajor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "NameMajor", true));
            this.txtNameMajor.Lines = new string[0];
            this.txtNameMajor.Location = new System.Drawing.Point(339, 42);
            this.txtNameMajor.MaxLength = 32767;
            this.txtNameMajor.Name = "txtNameMajor";
            this.txtNameMajor.PasswordChar = '\0';
            this.txtNameMajor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameMajor.SelectedText = "";
            this.txtNameMajor.SelectionLength = 0;
            this.txtNameMajor.SelectionStart = 0;
            this.txtNameMajor.ShortcutsEnabled = true;
            this.txtNameMajor.Size = new System.Drawing.Size(153, 23);
            this.txtNameMajor.TabIndex = 7;
            this.txtNameMajor.UseSelectable = true;
            this.txtNameMajor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameMajor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNameMajor
            // 
            this.lblNameMajor.AutoSize = true;
            this.lblNameMajor.Location = new System.Drawing.Point(160, 40);
            this.lblNameMajor.Name = "lblNameMajor";
            this.lblNameMajor.Size = new System.Drawing.Size(84, 19);
            this.lblNameMajor.TabIndex = 6;
            this.lblNameMajor.Text = "Name Major";
            // 
            // txtIdMajor
            // 
            // 
            // 
            // 
            this.txtIdMajor.CustomButton.Image = null;
            this.txtIdMajor.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtIdMajor.CustomButton.Name = "";
            this.txtIdMajor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdMajor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdMajor.CustomButton.TabIndex = 1;
            this.txtIdMajor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdMajor.CustomButton.UseSelectable = true;
            this.txtIdMajor.CustomButton.Visible = false;
            this.txtIdMajor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "IdMajor", true));
            this.txtIdMajor.Lines = new string[0];
            this.txtIdMajor.Location = new System.Drawing.Point(339, 14);
            this.txtIdMajor.MaxLength = 32767;
            this.txtIdMajor.Name = "txtIdMajor";
            this.txtIdMajor.PasswordChar = '\0';
            this.txtIdMajor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdMajor.SelectedText = "";
            this.txtIdMajor.SelectionLength = 0;
            this.txtIdMajor.SelectionStart = 0;
            this.txtIdMajor.ShortcutsEnabled = true;
            this.txtIdMajor.Size = new System.Drawing.Size(153, 23);
            this.txtIdMajor.TabIndex = 5;
            this.txtIdMajor.UseSelectable = true;
            this.txtIdMajor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdMajor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIdMajor
            // 
            this.lblIdMajor.AutoSize = true;
            this.lblIdMajor.Location = new System.Drawing.Point(160, 14);
            this.lblIdMajor.Name = "lblIdMajor";
            this.lblIdMajor.Size = new System.Drawing.Size(59, 19);
            this.lblIdMajor.TabIndex = 4;
            this.lblIdMajor.Text = "Id Major";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(695, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(634, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(512, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(451, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 351);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdDatosMajor);
            this.Controls.Add(this.pnlDatosMajor);
            this.Name = "FrmMajor";
            this.Text = "Majors";
            this.Load += new System.EventHandler(this.FrmMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoMajor)).EndInit();
            this.pnlDatosMajor.ResumeLayout(false);
            this.pnlDatosMajor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatosMajor;
        private System.Windows.Forms.PictureBox pctPhotoMajor;
        private MetroFramework.Controls.MetroPanel pnlDatosMajor;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtEmailMajor;
        private MetroFramework.Controls.MetroLabel lblEmailMajor;
        private MetroFramework.Controls.MetroTextBox txtCellPhoneNumberMajor;
        private MetroFramework.Controls.MetroLabel lblCellPhoneNumberMajor;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumberMajor;
        private MetroFramework.Controls.MetroLabel lblPhoneNumberMajor;
        private MetroFramework.Controls.MetroTextBox txtNameMajor;
        private MetroFramework.Controls.MetroLabel lblNameMajor;
        private MetroFramework.Controls.MetroTextBox txtIdMajor;
        private MetroFramework.Controls.MetroLabel lblIdMajor;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneNumberMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailMajorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionMajorDataGridViewTextBoxColumn;
    }
}