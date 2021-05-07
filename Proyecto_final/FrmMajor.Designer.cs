
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.pctPhotoMajor = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblIdMajor = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblNameMajor = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumberMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblPhoneNumberMajor = new MetroFramework.Controls.MetroLabel();
            this.txtCellPhoneNumberMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblCellPhoneNumberMajor = new MetroFramework.Controls.MetroLabel();
            this.txtEmailMajor = new MetroFramework.Controls.MetroTextBox();
            this.lblEmailMajor = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionMajorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoMajor)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMajorDataGridViewTextBoxColumn,
            this.nameMajorDataGridViewTextBoxColumn,
            this.phoneNumberMajorDataGridViewTextBoxColumn,
            this.cellPhoneNumberMajorDataGridViewTextBoxColumn,
            this.photoMajorDataGridViewTextBoxColumn,
            this.emailMajorDataGridViewTextBoxColumn,
            this.descriptionMajorDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.majorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(422, 259);
            this.metroGrid1.TabIndex = 0;
            // 
            // pctPhotoMajor
            // 
            this.pctPhotoMajor.Location = new System.Drawing.Point(15, 18);
            this.pctPhotoMajor.Name = "pctPhotoMajor";
            this.pctPhotoMajor.Size = new System.Drawing.Size(126, 138);
            this.pctPhotoMajor.TabIndex = 3;
            this.pctPhotoMajor.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSearch);
            this.metroPanel1.Controls.Add(this.txtEmailMajor);
            this.metroPanel1.Controls.Add(this.lblEmailMajor);
            this.metroPanel1.Controls.Add(this.txtCellPhoneNumberMajor);
            this.metroPanel1.Controls.Add(this.lblCellPhoneNumberMajor);
            this.metroPanel1.Controls.Add(this.txtPhoneNumberMajor);
            this.metroPanel1.Controls.Add(this.lblPhoneNumberMajor);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.lblNameMajor);
            this.metroPanel1.Controls.Add(this.txtId);
            this.metroPanel1.Controls.Add(this.lblIdMajor);
            this.metroPanel1.Controls.Add(this.pctPhotoMajor);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(451, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(532, 230);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "IdMajor", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(339, 14);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(153, 23);
            this.txtId.TabIndex = 5;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "NameMajor", true));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(339, 42);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(153, 23);
            this.txtName.TabIndex = 7;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(25, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(695, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(634, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(573, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(512, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(451, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(Proyecto_final.Entidades.Major);
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
            // FrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 486);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmMajor";
            this.Text = "Majors";
            this.Load += new System.EventHandler(this.FrmMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoMajor)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.PictureBox pctPhotoMajor;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtEmailMajor;
        private MetroFramework.Controls.MetroLabel lblEmailMajor;
        private MetroFramework.Controls.MetroTextBox txtCellPhoneNumberMajor;
        private MetroFramework.Controls.MetroLabel lblCellPhoneNumberMajor;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumberMajor;
        private MetroFramework.Controls.MetroLabel lblPhoneNumberMajor;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblNameMajor;
        private MetroFramework.Controls.MetroTextBox txtId;
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