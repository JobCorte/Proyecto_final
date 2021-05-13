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
    public partial class frmInicio : MetroFramework.Forms.MetroForm
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void bttAdviser_Click(object sender, EventArgs e)
        {
            FrmAdviser frmAdviser = new FrmAdviser(); // Se crea el objeto frmAdviser mediante el constructor/clase FrmAdviser
            frmAdviser.Show();
        }

        private void bttCoach_Click(object sender, EventArgs e)
        {
            FrmCoach frmCoach = new FrmCoach();
            frmCoach.Show();
        }

        private void bttCompany_Click(object sender, EventArgs e)
        {
            FrmCompany frmCompany = new FrmCompany();
            frmCompany.Show();
        }

        private void bttContact_Click(object sender, EventArgs e)
        {
            FrmContact frmContact = new FrmContact();
            frmContact.Show();
        }

        private void bttCoordinator_Click(object sender, EventArgs e)
        {
            FrmCoordinator frmCoordinator = new FrmCoordinator();
            frmCoordinator.Show();
        }

        private void bttMajor_Click(object sender, EventArgs e)
        {
            FrmMajor frmMajor = new FrmMajor();
            frmMajor.Show();
        }

        private void bttStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
