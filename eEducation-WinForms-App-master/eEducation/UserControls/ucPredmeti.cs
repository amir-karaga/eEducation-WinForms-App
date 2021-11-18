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
    public partial class ucPredmeti : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        private static ucPredmeti _instance;
        public static List<Predmet> lstPredmeti;
        public ucPredmeti()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }
        public static ucPredmeti instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPredmeti();
                return _instance;

            }

        }
        public static List<Predmet> ListaPredmeti
        {
            set
            {
                lstPredmeti = value;
            }
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ucPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        public void UcitajPredmete()
        {
            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = baza.Predmeti.ToList();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            ucDodajPredmet dodajPredmet = new ucDodajPredmet();
            this.Controls.Add(dodajPredmet);
            dodajPredmet.Dock = DockStyle.Fill;
            dodajPredmet.BringToFront();
        }

        private void dgvPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var predmet = dgvPredmeti.SelectedRows[0].DataBoundItem as Predmet;
            if(predmet!=null)
            {
                ucDodajPredmet pregled = new ucDodajPredmet(predmet);
                this.Controls.Add(pregled);
                pregled.Dock = DockStyle.Fill;
                pregled.BringToFront();
            }
        }
    }
}
