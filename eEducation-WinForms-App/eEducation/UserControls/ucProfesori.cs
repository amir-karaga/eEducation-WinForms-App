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
    public partial class ucProfesori : UserControl
    {
        private static ucProfesori _instance;
        public static List<Profesor> lstProfesori;
        KonekcijaNaBazu baza = eEducationDataBase.Baza; 
        public ucProfesori()
        {
            InitializeComponent();
            dgvProfesori.AutoGenerateColumns = false;
            lstProfesori = baza.Profesori.ToList();
        }
        public static ucProfesori instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucProfesori();
                return _instance;

            }

        }
        public static List<Profesor> ListaProfesori
        {
            set
            {
                lstProfesori = value;
            }
        }

        public void Ucitaj()
        {
            dgvProfesori.DataSource = null;
            dgvProfesori.DataSource = baza.Profesori.ToList();
        }
        private void ucProfesori_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvProfesori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var profesor = dgvProfesori.SelectedRows[0].DataBoundItem as Profesor;
            if (profesor != null)
            {
                ucDodajProfesora dodajProfesora = new ucDodajProfesora(profesor);
                this.Controls.Add(dodajProfesora);
                dodajProfesora.Dock = DockStyle.Fill;
                dodajProfesora.BringToFront();
            }
        }

        private void btnDodajProfesora_Click(object sender, EventArgs e)
        {
            ucDodajProfesora dodajProfesora = new ucDodajProfesora();
            this.Controls.Add(dodajProfesora);
            dodajProfesora.Dock = DockStyle.Fill;
            dodajProfesora.BringToFront();
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text;
            if (filter.ToString() != "")
                UcitajPodatkeOStudentima(baza.Profesori.Where(s => s.Ime.ToLower().Contains(filter) ||
                    s.Prezime.ToLower().Contains(filter)).ToList());
            else
                UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Profesor> profesori=null)
        {
            dgvProfesori.DataSource = null;
            dgvProfesori.DataSource= profesori??baza.Profesori.ToList();
        }
    }
}
