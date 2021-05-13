
namespace Proyecto_final
{
    partial class FrmCoordinator
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
            this.grdDatosCoordinator = new MetroFramework.Controls.MetroGrid();
            this.idCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneNumberCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionCoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.pnlDatosCoordinator = new MetroFramework.Controls.MetroPanel();
            this.txtDescripcionCoordinator = new MetroFramework.Controls.MetroTextBox();
            this.lblDescripcionCoordinator = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtEmailCoordinator = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCellPhoneNumberCoordinator = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtLastNameCoordinator = new MetroFramework.Controls.MetroTextBox();
            this.lblLastNameCoordinator = new MetroFramework.Controls.MetroLabel();
            this.txtFirstNameCoordinator = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pctPhotoCoordinator = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosCoordinator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).BeginInit();
            this.pnlDatosCoordinator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoCoordinator)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatosCoordinator
            // 
            this.grdDatosCoordinator.AllowUserToResizeRows = false;
            this.grdDatosCoordinator.AutoGenerateColumns = false;
            this.grdDatosCoordinator.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosCoordinator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatosCoordinator.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatosCoordinator.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosCoordinator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDatosCoordinator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosCoordinator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCoordinatorDataGridViewTextBoxColumn,
            this.firstNameCoordinatorDataGridViewTextBoxColumn,
            this.lastNameCoordinatorDataGridViewTextBoxColumn,
            this.cellPhoneNumberCoordinatorDataGridViewTextBoxColumn,
            this.emailCoordinatorDataGridViewTextBoxColumn,
            this.photoCoordinatorDataGridViewTextBoxColumn,
            this.descriptionCoordinatorDataGridViewTextBoxColumn});
            this.grdDatosCoordinator.DataSource = this.coordinatorBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatosCoordinator.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDatosCoordinator.EnableHeadersVisualStyles = false;
            this.grdDatosCoordinator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatosCoordinator.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatosCoordinator.Location = new System.Drawing.Point(16, 63);
            this.grdDatosCoordinator.Name = "grdDatosCoordinator";
            this.grdDatosCoordinator.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatosCoordinator.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDatosCoordinator.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatosCoordinator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatosCoordinator.Size = new System.Drawing.Size(455, 259);
            this.grdDatosCoordinator.TabIndex = 10;
            this.grdDatosCoordinator.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosCoordinator_CellContentClick);
            // 
            // idCoordinatorDataGridViewTextBoxColumn
            // 
            this.idCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "IdCoordinator";
            this.idCoordinatorDataGridViewTextBoxColumn.HeaderText = "IdCoordinator";
            this.idCoordinatorDataGridViewTextBoxColumn.Name = "idCoordinatorDataGridViewTextBoxColumn";
            // 
            // firstNameCoordinatorDataGridViewTextBoxColumn
            // 
            this.firstNameCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "FirstNameCoordinator";
            this.firstNameCoordinatorDataGridViewTextBoxColumn.HeaderText = "FirstNameCoordinator";
            this.firstNameCoordinatorDataGridViewTextBoxColumn.Name = "firstNameCoordinatorDataGridViewTextBoxColumn";
            // 
            // lastNameCoordinatorDataGridViewTextBoxColumn
            // 
            this.lastNameCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "LastNameCoordinator";
            this.lastNameCoordinatorDataGridViewTextBoxColumn.HeaderText = "LastNameCoordinator";
            this.lastNameCoordinatorDataGridViewTextBoxColumn.Name = "lastNameCoordinatorDataGridViewTextBoxColumn";
            // 
            // cellPhoneNumberCoordinatorDataGridViewTextBoxColumn
            // 
            this.cellPhoneNumberCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "CellPhoneNumberCoordinator";
            this.cellPhoneNumberCoordinatorDataGridViewTextBoxColumn.HeaderText = "CellPhoneNumberCoordinator";
            this.cellPhoneNumberCoordinatorDataGridViewTextBoxColumn.Name = "cellPhoneNumberCoordinatorDataGridViewTextBoxColumn";
            // 
            // emailCoordinatorDataGridViewTextBoxColumn
            // 
            this.emailCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "EmailCoordinator";
            this.emailCoordinatorDataGridViewTextBoxColumn.HeaderText = "EmailCoordinator";
            this.emailCoordinatorDataGridViewTextBoxColumn.Name = "emailCoordinatorDataGridViewTextBoxColumn";
            // 
            // photoCoordinatorDataGridViewTextBoxColumn
            // 
            this.photoCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "PhotoCoordinator";
            this.photoCoordinatorDataGridViewTextBoxColumn.HeaderText = "PhotoCoordinator";
            this.photoCoordinatorDataGridViewTextBoxColumn.Name = "photoCoordinatorDataGridViewTextBoxColumn";
            // 
            // descriptionCoordinatorDataGridViewTextBoxColumn
            // 
            this.descriptionCoordinatorDataGridViewTextBoxColumn.DataPropertyName = "DescriptionCoordinator";
            this.descriptionCoordinatorDataGridViewTextBoxColumn.HeaderText = "DescriptionCoordinator";
            this.descriptionCoordinatorDataGridViewTextBoxColumn.Name = "descriptionCoordinatorDataGridViewTextBoxColumn";
            // 
            // coordinatorBindingSource
            // 
            this.coordinatorBindingSource.DataSource = typeof(Proyecto_final.Entidades.Coordinator);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(721, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(660, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(55, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(538, 299);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(477, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlDatosCoordinator
            // 
            this.pnlDatosCoordinator.Controls.Add(this.txtDescripcionCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.lblDescripcionCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.btnSearch);
            this.pnlDatosCoordinator.Controls.Add(this.txtEmailCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.metroLabel5);
            this.pnlDatosCoordinator.Controls.Add(this.txtCellPhoneNumberCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.metroLabel4);
            this.pnlDatosCoordinator.Controls.Add(this.txtLastNameCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.lblLastNameCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.txtFirstNameCoordinator);
            this.pnlDatosCoordinator.Controls.Add(this.lblName);
            this.pnlDatosCoordinator.Controls.Add(this.txtId);
            this.pnlDatosCoordinator.Controls.Add(this.lblId);
            this.pnlDatosCoordinator.Controls.Add(this.pctPhotoCoordinator);
            this.pnlDatosCoordinator.HorizontalScrollbarBarColor = true;
            this.pnlDatosCoordinator.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatosCoordinator.HorizontalScrollbarSize = 10;
            this.pnlDatosCoordinator.Location = new System.Drawing.Point(477, 63);
            this.pnlDatosCoordinator.Name = "pnlDatosCoordinator";
            this.pnlDatosCoordinator.Size = new System.Drawing.Size(547, 230);
            this.pnlDatosCoordinator.TabIndex = 11;
            this.pnlDatosCoordinator.VerticalScrollbarBarColor = true;
            this.pnlDatosCoordinator.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatosCoordinator.VerticalScrollbarSize = 10;
            // 
            // txtDescripcionCoordinator
            // 
            // 
            // 
            // 
            this.txtDescripcionCoordinator.CustomButton.Image = null;
            this.txtDescripcionCoordinator.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtDescripcionCoordinator.CustomButton.Name = "";
            this.txtDescripcionCoordinator.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcionCoordinator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcionCoordinator.CustomButton.TabIndex = 1;
            this.txtDescripcionCoordinator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcionCoordinator.CustomButton.UseSelectable = true;
            this.txtDescripcionCoordinator.CustomButton.Visible = false;
            this.txtDescripcionCoordinator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "DescriptionCoordinator", true));
            this.txtDescripcionCoordinator.Lines = new string[0];
            this.txtDescripcionCoordinator.Location = new System.Drawing.Point(358, 162);
            this.txtDescripcionCoordinator.MaxLength = 32767;
            this.txtDescripcionCoordinator.Name = "txtDescripcionCoordinator";
            this.txtDescripcionCoordinator.PasswordChar = '\0';
            this.txtDescripcionCoordinator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionCoordinator.SelectedText = "";
            this.txtDescripcionCoordinator.SelectionLength = 0;
            this.txtDescripcionCoordinator.SelectionStart = 0;
            this.txtDescripcionCoordinator.ShortcutsEnabled = true;
            this.txtDescripcionCoordinator.Size = new System.Drawing.Size(169, 23);
            this.txtDescripcionCoordinator.TabIndex = 20;
            this.txtDescripcionCoordinator.UseSelectable = true;
            this.txtDescripcionCoordinator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcionCoordinator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDescripcionCoordinator
            // 
            this.lblDescripcionCoordinator.AutoSize = true;
            this.lblDescripcionCoordinator.Location = new System.Drawing.Point(160, 162);
            this.lblDescripcionCoordinator.Name = "lblDescripcionCoordinator";
            this.lblDescripcionCoordinator.Size = new System.Drawing.Size(152, 19);
            this.lblDescripcionCoordinator.TabIndex = 19;
            this.lblDescripcionCoordinator.Text = "Descripcion Coordinator";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(28, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEmailCoordinator
            // 
            // 
            // 
            // 
            this.txtEmailCoordinator.CustomButton.Image = null;
            this.txtEmailCoordinator.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtEmailCoordinator.CustomButton.Name = "";
            this.txtEmailCoordinator.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailCoordinator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailCoordinator.CustomButton.TabIndex = 1;
            this.txtEmailCoordinator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailCoordinator.CustomButton.UseSelectable = true;
            this.txtEmailCoordinator.CustomButton.Visible = false;
            this.txtEmailCoordinator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "EmailCoordinator", true));
            this.txtEmailCoordinator.Lines = new string[0];
            this.txtEmailCoordinator.Location = new System.Drawing.Point(358, 131);
            this.txtEmailCoordinator.MaxLength = 32767;
            this.txtEmailCoordinator.Name = "txtEmailCoordinator";
            this.txtEmailCoordinator.PasswordChar = '\0';
            this.txtEmailCoordinator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailCoordinator.SelectedText = "";
            this.txtEmailCoordinator.SelectionLength = 0;
            this.txtEmailCoordinator.SelectionStart = 0;
            this.txtEmailCoordinator.ShortcutsEnabled = true;
            this.txtEmailCoordinator.Size = new System.Drawing.Size(169, 23);
            this.txtEmailCoordinator.TabIndex = 13;
            this.txtEmailCoordinator.UseSelectable = true;
            this.txtEmailCoordinator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailCoordinator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(160, 131);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Email Coordinator";
            // 
            // txtCellPhoneNumberCoordinator
            // 
            // 
            // 
            // 
            this.txtCellPhoneNumberCoordinator.CustomButton.Image = null;
            this.txtCellPhoneNumberCoordinator.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtCellPhoneNumberCoordinator.CustomButton.Name = "";
            this.txtCellPhoneNumberCoordinator.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellPhoneNumberCoordinator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellPhoneNumberCoordinator.CustomButton.TabIndex = 1;
            this.txtCellPhoneNumberCoordinator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellPhoneNumberCoordinator.CustomButton.UseSelectable = true;
            this.txtCellPhoneNumberCoordinator.CustomButton.Visible = false;
            this.txtCellPhoneNumberCoordinator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "CellPhoneNumberCoordinator", true));
            this.txtCellPhoneNumberCoordinator.Lines = new string[0];
            this.txtCellPhoneNumberCoordinator.Location = new System.Drawing.Point(358, 101);
            this.txtCellPhoneNumberCoordinator.MaxLength = 32767;
            this.txtCellPhoneNumberCoordinator.Name = "txtCellPhoneNumberCoordinator";
            this.txtCellPhoneNumberCoordinator.PasswordChar = '\0';
            this.txtCellPhoneNumberCoordinator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellPhoneNumberCoordinator.SelectedText = "";
            this.txtCellPhoneNumberCoordinator.SelectionLength = 0;
            this.txtCellPhoneNumberCoordinator.SelectionStart = 0;
            this.txtCellPhoneNumberCoordinator.ShortcutsEnabled = true;
            this.txtCellPhoneNumberCoordinator.Size = new System.Drawing.Size(169, 23);
            this.txtCellPhoneNumberCoordinator.TabIndex = 11;
            this.txtCellPhoneNumberCoordinator.UseSelectable = true;
            this.txtCellPhoneNumberCoordinator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellPhoneNumberCoordinator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(160, 101);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(197, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "CellPhone Number Coordinator";
            // 
            // txtLastNameCoordinator
            // 
            // 
            // 
            // 
            this.txtLastNameCoordinator.CustomButton.Image = null;
            this.txtLastNameCoordinator.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtLastNameCoordinator.CustomButton.Name = "";
            this.txtLastNameCoordinator.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastNameCoordinator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastNameCoordinator.CustomButton.TabIndex = 1;
            this.txtLastNameCoordinator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastNameCoordinator.CustomButton.UseSelectable = true;
            this.txtLastNameCoordinator.CustomButton.Visible = false;
            this.txtLastNameCoordinator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "LastNameCoordinator", true));
            this.txtLastNameCoordinator.Lines = new string[0];
            this.txtLastNameCoordinator.Location = new System.Drawing.Point(358, 70);
            this.txtLastNameCoordinator.MaxLength = 32767;
            this.txtLastNameCoordinator.Name = "txtLastNameCoordinator";
            this.txtLastNameCoordinator.PasswordChar = '\0';
            this.txtLastNameCoordinator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastNameCoordinator.SelectedText = "";
            this.txtLastNameCoordinator.SelectionLength = 0;
            this.txtLastNameCoordinator.SelectionStart = 0;
            this.txtLastNameCoordinator.ShortcutsEnabled = true;
            this.txtLastNameCoordinator.Size = new System.Drawing.Size(169, 23);
            this.txtLastNameCoordinator.TabIndex = 9;
            this.txtLastNameCoordinator.UseSelectable = true;
            this.txtLastNameCoordinator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastNameCoordinator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLastNameCoordinator
            // 
            this.lblLastNameCoordinator.AutoSize = true;
            this.lblLastNameCoordinator.Location = new System.Drawing.Point(160, 70);
            this.lblLastNameCoordinator.Name = "lblLastNameCoordinator";
            this.lblLastNameCoordinator.Size = new System.Drawing.Size(147, 19);
            this.lblLastNameCoordinator.TabIndex = 8;
            this.lblLastNameCoordinator.Text = "Last Name Coordinator";
            // 
            // txtFirstNameCoordinator
            // 
            // 
            // 
            // 
            this.txtFirstNameCoordinator.CustomButton.Image = null;
            this.txtFirstNameCoordinator.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtFirstNameCoordinator.CustomButton.Name = "";
            this.txtFirstNameCoordinator.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstNameCoordinator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstNameCoordinator.CustomButton.TabIndex = 1;
            this.txtFirstNameCoordinator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstNameCoordinator.CustomButton.UseSelectable = true;
            this.txtFirstNameCoordinator.CustomButton.Visible = false;
            this.txtFirstNameCoordinator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "FirstNameCoordinator", true));
            this.txtFirstNameCoordinator.Lines = new string[0];
            this.txtFirstNameCoordinator.Location = new System.Drawing.Point(358, 40);
            this.txtFirstNameCoordinator.MaxLength = 32767;
            this.txtFirstNameCoordinator.Name = "txtFirstNameCoordinator";
            this.txtFirstNameCoordinator.PasswordChar = '\0';
            this.txtFirstNameCoordinator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstNameCoordinator.SelectedText = "";
            this.txtFirstNameCoordinator.SelectionLength = 0;
            this.txtFirstNameCoordinator.SelectionStart = 0;
            this.txtFirstNameCoordinator.ShortcutsEnabled = true;
            this.txtFirstNameCoordinator.Size = new System.Drawing.Size(169, 23);
            this.txtFirstNameCoordinator.TabIndex = 7;
            this.txtFirstNameCoordinator.UseSelectable = true;
            this.txtFirstNameCoordinator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstNameCoordinator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(160, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 19);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "First Name Coordinator";
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "IdCoordinator", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(358, 12);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(169, 23);
            this.txtId.TabIndex = 5;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(160, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(96, 19);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id Coordinator";
            // 
            // pctPhotoCoordinator
            // 
            this.pctPhotoCoordinator.Location = new System.Drawing.Point(15, 18);
            this.pctPhotoCoordinator.Name = "pctPhotoCoordinator";
            this.pctPhotoCoordinator.Size = new System.Drawing.Size(126, 138);
            this.pctPhotoCoordinator.TabIndex = 3;
            this.pctPhotoCoordinator.TabStop = false;
            this.pctPhotoCoordinator.Click += new System.EventHandler(this.pctPhotoCoordinator_Click);
            // 
            // FrmCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 362);
            this.Controls.Add(this.grdDatosCoordinator);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlDatosCoordinator);
            this.Name = "FrmCoordinator";
            this.Text = "Coordinators";
            this.Load += new System.EventHandler(this.FrmCoordinator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosCoordinator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).EndInit();
            this.pnlDatosCoordinator.ResumeLayout(false);
            this.pnlDatosCoordinator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhotoCoordinator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatosCoordinator;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroPanel pnlDatosCoordinator;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtEmailCoordinator;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtCellPhoneNumberCoordinator;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtLastNameCoordinator;
        private MetroFramework.Controls.MetroLabel lblLastNameCoordinator;
        private MetroFramework.Controls.MetroTextBox txtFirstNameCoordinator;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.PictureBox pctPhotoCoordinator;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneNumberCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionCoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource coordinatorBindingSource;
        private MetroFramework.Controls.MetroTextBox txtDescripcionCoordinator;
        private MetroFramework.Controls.MetroLabel lblDescripcionCoordinator;
    }
}