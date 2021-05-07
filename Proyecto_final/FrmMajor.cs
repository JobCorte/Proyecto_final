using Proyecto_final.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            pnlDatos.Enabled = false;
            Major major = majorBindingSource.Current as Major;
            if (major != null && Major.Photo != null)
                pctPhoto.Image = Image.FromFile(Major.Photo);
            else
                pctPhoto.Image = null;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
