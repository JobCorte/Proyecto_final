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
    public partial class FrmMajor : MetroFramework.Forms.MetroForm
    {
        public FrmMajor()
        {
            InitializeComponent();
        }

        private void FrmMajor_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())

            {
                majorBindingSource.DataSource = dataContext.Major.ToList();
            }

            pnlDatosMajor.Enabled = false;
            Major major = majorBindingSource.Current as Major;
            if (major != null && major.PhotoMajor != null)
                pctPhotoMajor.Image = Image.FromFile(major.PhotoMajor);
            else
                pctPhotoMajor.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatosMajor.Enabled = true;

            pctPhotoMajor.Image = null;

            majorBindingSource.Add(new Major());

            majorBindingSource.MoveLast();

            txtNameMajor.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatosMajor.Enabled = true;

            txtNameMajor.Focus();

            Major major = majorBindingSource.Current as Major;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar a la compañia?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Major major = majorBindingSource.Current as Major;
                    if (major != null)
                    {
                        if (dataContext.Entry<Major>(major).State == EntityState.Detached)
                            dataContext.Set<Major>().Attach(major);
                        dataContext.Entry<Major>(major).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compañia eliminado");
                        majorBindingSource.RemoveCurrent();
                        pctPhotoMajor.Image = null;
                        pnlDatosMajor.Enabled = false;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatosMajor.Enabled = false;

            majorBindingSource.ResetBindings(false);

            FrmMajor_Load(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())

            {
                Major major = majorBindingSource.Current as Major;
                if (major != null)
                {
                    if (dataContext.Entry<Major>(major).State == EntityState.Detached)
                        dataContext.Set<Major>().Attach(major);
                    {
                        if (major.IdMajor == 0)
                            dataContext.Entry<Major>(major).State = EntityState.Added;
                        else
                            dataContext.Entry<Major>(major).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                        grdDatosMajor.Refresh();
                        pnlDatosMajor.Enabled = false;
                    }
                }
            }
        }

        private void pctPhotoMajor_Click(object sender, EventArgs e)
        {
            Major major = majorBindingSource.Current as Major;
            if (major != null && major.PhotoMajor != null)
                pctPhotoMajor.Image = Image.FromFile(major.PhotoMajor);
            else
                pctPhotoMajor.Image = null;
        }

        private void grdDatosMajor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Major major = majorBindingSource.Current as Major;
            if (major != null && major.PhotoMajor != null)
                pctPhotoMajor.Image = Image.FromFile(major.PhotoMajor);
            else
            {
                pctPhotoMajor.Image = null;
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

                    pctPhotoMajor.Image = Image.FromFile(ofd.FileName);
                Major major = majorBindingSource.Current as Major;
                if (major != null)
                    major.PhotoMajor = ofd.FileName;
            }
        }
    }
}
