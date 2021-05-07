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
    public partial class FrmContact : MetroFramework.Forms.MetroForm
    {
        public FrmContact()
        {
            InitializeComponent();
        }

        private void FrmContact_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatosContact.Enabled = true;
            pctPhotoContact.Image = null;
            contactBindingSource.Add(new Contact());
            contactBindingSource.MoveLast();
            txtFirtsNameContact.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatosContact.Enabled = true;
            txtFirtsNameContact.Focus();
            Contact contact = contactBindingSource.Current as Contact;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar al contacto?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Student student = contactBindingSource.Current as Student;
                    if (student != null)
                    {
                        if (dataContext.Entry<Student>(student).State == EntityState.Detached)
                            dataContext.Set<Student>().Attach(student);
                        dataContext.Entry<Student>(student).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Contacto eliminado");
                        contactBindingSource.RemoveCurrent();
                        pctPhotoContact.Image = null;
                        pnlDatosContact.Enabled = false;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Contact contact = contactBindingSource.Current as Contact;
                if (contact != null)
                {
                    if (dataContext.Entry<Contact>(contact).State == EntityState.Detached)
                        dataContext.Set<Contact>().Attach(contact);
                    if (contact.IdContact == 0)
                        dataContext.Entry<Contact>(contact).State = EntityState.Added;
                    else
                        dataContext.Entry<Contact>(contact).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Contacto guardado");
                    grdDatosContact.Refresh();
                    pnlDatosContact.Enabled = false;
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatosContact.Enabled = false;
            contactBindingSource.ResetBindings(false);
            FrmContact_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)

                    pctPhotoContact.Image = Image.FromFile(ofd.FileName);
                Contact contact = contactBindingSource.Current as Contact;
                if (contact != null)
                    contact.PhotoContact = ofd.FileName;
            }

        }

        private void grdDatosContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact contact = contactBindingSource.Current as Contact;
            if (contact != null && contact.PhotoContact != null)
                pctPhotoContact.Image = Image.FromFile(contact.PhotoContact);
            else
            {
                pctPhotoContact.Image = null;
            }

        }
    }
}