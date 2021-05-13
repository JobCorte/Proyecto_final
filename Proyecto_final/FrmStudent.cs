using Proyecto_final.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class FrmStudent : MetroFramework.Forms.MetroForm
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Student student = studentBindingSource.Current as Student;
                if (student != null)
                {
                    if (dataContext.Entry<Student>(student).State == EntityState.Detached)
                    dataContext.Set<Student>().Attach(student);
                    if (student.Id == 0)
                    {
                        dataContext.Entry<Student>(student).State = EntityState.Added;
                    }
                    else
                        dataContext.Entry<Student>(student).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Estudiante guardado");
                    grdStudent.Refresh();
                    pnlStudent.Enabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlStudent.Enabled = true;
            pctPhotoStudent.Image = null;
            studentBindingSource.Add(new Company());
            studentBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlStudent.Enabled = true;
            txtFirstName.Focus();
            Company company = studentBindingSource.Current as Company;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al estudiante?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Company company = studentBindingSource.Current as Company;
                    if (company != null)
                    {
                        if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                            dataContext.Set<Company>().Attach(company);
                        dataContext.Entry<Company>(company).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compañia eliminado");
                        studentBindingSource.RemoveCurrent();
                        pctPhotoStudent.Image = null;
                        pnlStudent.Enabled = false;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlStudent.Enabled = false;
            studentBindingSource.ResetBindings(false);
            FrmStudent_Load(sender, e);
        }

        private void grdDatosCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Company company = studentBindingSource.Current as Company;
            if (company != null && company.PhotoCompany != null)
                pctPhotoStudent.Image = Image.FromFile(company.PhotoCompany);
            else
            {
                pctPhotoStudent.Image = null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)

                    pctPhotoStudent.Image = Image.FromFile(ofd.FileName);
                Company company = studentBindingSource.Current as Company;
                if (company != null)
                    company.PhotoCompany = ofd.FileName;
            }
        }
    }
}
