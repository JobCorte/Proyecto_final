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
    public partial class FrmCompany : MetroFramework.Forms.MetroForm
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Company company = companyBindingSource.Current as Company;
                if (company != null)
                {
                    if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                        dataContext.Set<Company>().Attach(company);
                    if (company.IdCompany == 0)
                        dataContext.Entry<Company>(company).State = EntityState.Added;
                    else
                        dataContext.Entry<Company>(company).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Compañia guardado");
                    grdDatosCompany.Refresh();
                    pnlDatosCompany.Enabled = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatosCompany.Enabled = true;
            pctPhotoCompany.Image = null;
            companyBindingSource.Add(new Company());
            companyBindingSource.MoveLast();
            txtNameCompany.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatosCompany.Enabled = true;
            txtNameCompany.Focus();
            Company company = companyBindingSource.Current as Company;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar a lacompañia?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Company company = companyBindingSource.Current as Company;
                    if (company != null)
                    {
                        if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                            dataContext.Set<Company>().Attach(company);
                        dataContext.Entry<Company>(company).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compañia eliminado");
                        companyBindingSource.RemoveCurrent();
                        pctPhotoCompany.Image = null;
                        pnlDatosCompany.Enabled = false;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatosCompany.Enabled = false;
            companyBindingSource.ResetBindings(false);
            FrmCompany_Load(sender, e);
        }

        private void grdDatosCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Company company = companyBindingSource.Current as Company;
            if (company != null && company.PhotoCompany != null)
                pctPhotoCompany.Image = Image.FromFile(company.PhotoCompany);
            else
            {
                pctPhotoCompany.Image = null;
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

                    pctPhotoCompany.Image = Image.FromFile(ofd.FileName);
                Company company = companyBindingSource.Current as Company;
                if (company != null)
                    company.PhotoCompany = ofd.FileName;
            }
        }
    }
}