using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eEducation.Forme
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmLoginStudent loginStudent = new frmLoginStudent();
            loginStudent.ShowDialog();
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            frmLoginAdministracija administracija = new frmLoginAdministracija();
            administracija.ShowDialog();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {

        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            frmLoginProfesor Loginprofesor = new frmLoginProfesor();
            Loginprofesor.ShowDialog();
        }
    }
}
