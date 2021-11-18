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
    public partial class frmLoginProfesor : Form
    {
        public frmLoginProfesor()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmProfilProfesor profilProfesor = new frmProfilProfesor();
            this.Hide();
            profilProfesor.ShowDialog();
            this.Show();
        }
    }
}
