using Proyecto_final.Entidades;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class FrmCoordinator : MetroFramework.Forms.MetroForm
    {
        public FrmCoordinator()
        {
            InitializeComponent();
        }

        private void FrmCoordinator_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())

            {
                coordinatorBindingSource.DataSource = dataContext.Coordinator.ToList();
            }

            pnlDatosCoordinator.Enabled = false;
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.PhotoCoordinator != null)
                pctPhotoCoordinator.Image = Image.FromFile(coordinator.PhotoCoordinator);
            else
                pctPhotoCoordinator.Image = null;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)

                    pctPhotoCoordinator.Image = Image.FromFile(ofd.FileName);
                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                if (coordinator != null)
                    coordinator.PhotoCoordinator = ofd.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatosCoordinator.Enabled = true;

            pctPhotoCoordinator.Image = null;

            coordinatorBindingSource.Add(new Coordinator());

            coordinatorBindingSource.MoveLast();

            txtFirstNameCoordinator.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatosCoordinator.Enabled = false;

            coordinatorBindingSource.ResetBindings(false);

            FrmCoordinator_Load(sender, e);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatosCoordinator.Enabled = true;

            txtFirstNameCoordinator.Focus();

            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar a la compañia?","Eliminar",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                    {
                        if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                            dataContext.Set<Coordinator>().Attach(coordinator);
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compañia eliminado");
                        coordinatorBindingSource.RemoveCurrent();
                        pctPhotoCoordinator.Image = null;
                        pnlDatosCoordinator.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())

            {
                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                if (coordinator != null)
                {
                    if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                        dataContext.Set<Coordinator>().Attach(coordinator);
                    {
                        if (coordinator.IdCoordinator == 0)
                            dataContext.Entry<Coordinator>(coordinator).State = EntityState.Added;
                        else
                            dataContext.Entry<Coordinator>(coordinator).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                        grdDatosCoordinator.Refresh();
                        pnlDatosCoordinator.Enabled = false;
                    }
                }
            }
        }

        private void pctPhotoCoordinator_Click(object sender, EventArgs e)
        {
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.PhotoCoordinator != null)
                pctPhotoCoordinator.Image = Image.FromFile(coordinator.PhotoCoordinator);
            else
                pctPhotoCoordinator.Image = null;
        }

        private void grdDatosCoordinator_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.PhotoCoordinator != null)
                pctPhotoCoordinator.Image = Image.FromFile(coordinator.PhotoCoordinator);
            else
            {
                pctPhotoCoordinator.Image = null;
            }

        }
    }
}
