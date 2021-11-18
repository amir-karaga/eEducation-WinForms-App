using eEducation.Forme;
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
    public partial class Pocetna : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        public static List<Obavijest> lstObavijesti;
        private static Pocetna _instance;
        public static Pocetna instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Pocetna();
                return _instance;

            }

        }
        public static List<Obavijest> ListaObavijesti
        {
            set
            {
                lstObavijesti = value;
            }
        }
        public Pocetna()
        {
            InitializeComponent();
            dgvObavjestenja.AutoGenerateColumns = false;
            //lstObavijesti = baza.Obavijesti.ToList();
            //Ucitaj();

        }

        public void Ucitaj()
        {
            dgvObavjestenja.DataSource = null;
            dgvObavjestenja.DataSource = lstObavijesti;
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            Ucitaj();
            lblDatum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void dgvObavjestenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var obavijest = dgvObavjestenja.SelectedRows[0].DataBoundItem as Obavijest;
            if (obavijest != null)
            {
                if (!this.Controls.Contains(ucDodajObavijest.instance))
                {
                    ucDodajObavijest.instance.GenerisiObavijest(obavijest);
                    this.Controls.Add(ucDodajObavijest.instance);
                    ucDodajObavijest.instance.Dock = DockStyle.Fill;
                    ucDodajObavijest.instance.BringToFront();
                }
                else
                {
                    ucDodajObavijest.instance.GenerisiObavijest(obavijest);
                    ucDodajObavijest.instance.BringToFront();
                    ucDodajObavijest.instance.Show();
                }

                //frmDodajObavijest pregled = new frmDodajObavijest(obavijest);
                //this.Hide();
                //pregled.ShowDialog();
                //this.Show();
            }
        }
    }
}
