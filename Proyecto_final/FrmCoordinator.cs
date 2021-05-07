using Proyecto_final.Entidades;
using System;
using System.Data.Entity;
using System.Linq;

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

            pnlDatos.Enabled = false;
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && Coordinator.Photo != null)
                pctPhotoCoordinator.Image = Image.FromFile(Coordinator.Photo);
            else
                pctPhotoCoordinator.Image = null;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;

            pctPhotoCoordinator.Image = null;

            coordinatorBindingSource.Add(new Coordinator());

            coordinatorBindingSource.MoveLast();

            txtFirstNameCoordinator.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;

            coordinatorBindingSource.ResetBindings(false);

            FrmCoordinator_Load(sender, e);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;

            txtFirstNameCoordinator.Focus();

            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this,"¿Quieres Eliminar Los Datos ? ") == DialogResult.OK)

            {
                using (DataContext dataContext = new DataContext())
                {
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                    {
                        if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                        {
                            dataContext.Set<Coordinator>().Attach(coordinator);
                            dataContext.Entry<Coordinator>(coordinator).State = EntityState.Deleted;
                            dataContext.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Datos Eliminados");
                            coordinatorBindingSource.RemoveCurrent();
                            pctPhotoCoordinator.Image = null;
                            pnlDatos.Enabled = false;
                        }
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
                    if (coordinator.IdCoordinator == 0)
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Added;
                    else
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Datos Guardados");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void pctPhoto_Click(object sender, EventArgs e)
        {
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.Photo != null)
                pctPhotoCoordinator.Image = Image.FromFile(coordinator.Photo);
            else
                pctPhotoCoordinator.Image = null;
        }

        private void grdDatos_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Coordinator coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && Coordinator.Photo != null)
                pctPhotoCoordinator.Image = Image.FromFile(Coordinator.Photo);
            else
                pctPhotoCoordinator.Image = null;

        }
    }
}
