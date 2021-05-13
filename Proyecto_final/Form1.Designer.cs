
namespace Proyecto_final
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.bttAdviser = new MetroFramework.Controls.MetroButton();
            this.bttCoach = new MetroFramework.Controls.MetroButton();
            this.bttCompany = new MetroFramework.Controls.MetroButton();
            this.bttContact = new MetroFramework.Controls.MetroButton();
            this.bttCoordinator = new MetroFramework.Controls.MetroButton();
            this.bttMajor = new MetroFramework.Controls.MetroButton();
            this.bttStudent = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblData.Location = new System.Drawing.Point(274, 178);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(191, 19);
            this.lblData.Style = MetroFramework.MetroColorStyle.Black;
            this.lblData.TabIndex = 0;
            this.lblData.Text = "What data do you want to see?";
            this.lblData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblData.UseCustomBackColor = true;
            this.lblData.UseStyleColors = true;
            // 
            // bttAdviser
            // 
            this.bttAdviser.Location = new System.Drawing.Point(52, 262);
            this.bttAdviser.Name = "bttAdviser";
            this.bttAdviser.Size = new System.Drawing.Size(89, 26);
            this.bttAdviser.TabIndex = 1;
            this.bttAdviser.Text = "Adviser";
            this.bttAdviser.UseSelectable = true;
            this.bttAdviser.Click += new System.EventHandler(this.bttAdviser_Click);
            // 
            // bttCoach
            // 
            this.bttCoach.Location = new System.Drawing.Point(147, 262);
            this.bttCoach.Name = "bttCoach";
            this.bttCoach.Size = new System.Drawing.Size(90, 26);
            this.bttCoach.TabIndex = 2;
            this.bttCoach.Text = "Coach";
            this.bttCoach.UseSelectable = true;
            this.bttCoach.Click += new System.EventHandler(this.bttCoach_Click);
            // 
            // bttCompany
            // 
            this.bttCompany.Location = new System.Drawing.Point(243, 262);
            this.bttCompany.Name = "bttCompany";
            this.bttCompany.Size = new System.Drawing.Size(90, 26);
            this.bttCompany.TabIndex = 3;
            this.bttCompany.Text = "Company";
            this.bttCompany.UseSelectable = true;
            this.bttCompany.Click += new System.EventHandler(this.bttCompany_Click);
            // 
            // bttContact
            // 
            this.bttContact.Location = new System.Drawing.Point(339, 262);
            this.bttContact.Name = "bttContact";
            this.bttContact.Size = new System.Drawing.Size(90, 26);
            this.bttContact.TabIndex = 4;
            this.bttContact.Text = "Contact";
            this.bttContact.UseSelectable = true;
            this.bttContact.Click += new System.EventHandler(this.bttContact_Click);
            // 
            // bttCoordinator
            // 
            this.bttCoordinator.Location = new System.Drawing.Point(435, 262);
            this.bttCoordinator.Name = "bttCoordinator";
            this.bttCoordinator.Size = new System.Drawing.Size(90, 26);
            this.bttCoordinator.TabIndex = 5;
            this.bttCoordinator.Text = "Coordinator";
            this.bttCoordinator.UseSelectable = true;
            this.bttCoordinator.Click += new System.EventHandler(this.bttCoordinator_Click);
            // 
            // bttMajor
            // 
            this.bttMajor.Location = new System.Drawing.Point(531, 262);
            this.bttMajor.Name = "bttMajor";
            this.bttMajor.Size = new System.Drawing.Size(90, 26);
            this.bttMajor.TabIndex = 6;
            this.bttMajor.Text = "Major";
            this.bttMajor.UseSelectable = true;
            this.bttMajor.Click += new System.EventHandler(this.bttMajor_Click);
            // 
            // bttStudent
            // 
            this.bttStudent.Location = new System.Drawing.Point(627, 262);
            this.bttStudent.Name = "bttStudent";
            this.bttStudent.Size = new System.Drawing.Size(89, 26);
            this.bttStudent.TabIndex = 7;
            this.bttStudent.Text = "Student";
            this.bttStudent.UseSelectable = true;
            this.bttStudent.Click += new System.EventHandler(this.bttStudent_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 487);
            this.Controls.Add(this.bttStudent);
            this.Controls.Add(this.bttMajor);
            this.Controls.Add(this.bttCoordinator);
            this.Controls.Add(this.bttContact);
            this.Controls.Add(this.bttCompany);
            this.Controls.Add(this.bttCoach);
            this.Controls.Add(this.bttAdviser);
            this.Controls.Add(this.lblData);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblData;
        private MetroFramework.Controls.MetroButton bttAdviser;
        private MetroFramework.Controls.MetroButton bttCoach;
        private MetroFramework.Controls.MetroButton bttCompany;
        private MetroFramework.Controls.MetroButton bttContact;
        private MetroFramework.Controls.MetroButton bttCoordinator;
        private MetroFramework.Controls.MetroButton bttMajor;
        private MetroFramework.Controls.MetroButton bttStudent;
    }
}

