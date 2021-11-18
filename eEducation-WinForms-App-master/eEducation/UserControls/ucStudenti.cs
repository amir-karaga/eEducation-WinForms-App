using eEducation.Helpers;
using eEducation.MainClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eEducation.UserControls
{
    public partial class ucStudenti : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        public static List<Student> lstStudenti;
        private static ucStudenti _instance;
        public ucStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void ucStudenti_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        public static ucStudenti instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucStudenti();
                return _instance;

            }

        }
        public static List<Student> ListaStudenti
        {
            set
            {
                lstStudenti = value;
            }
        }
        public void UcitajStudente()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = baza.Studenti.ToList();
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            ucDodajStudenta dodajStudenta = new ucDodajStudenta();
            this.Controls.Add(dodajStudenta);
            dodajStudenta.Dock = DockStyle.Fill;
            dodajStudenta.BringToFront();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            if (student != null)
            {
                ucDodajStudenta dodajStudenta = new ucDodajStudenta(student);
                this.Controls.Add(dodajStudenta);
                dodajStudenta.Dock = DockStyle.Fill;
                dodajStudenta.BringToFront();
            }
        }
    }
}
