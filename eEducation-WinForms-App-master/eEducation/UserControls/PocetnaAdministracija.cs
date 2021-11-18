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
    public partial class PocetnaAdministracija : UserControl
    {
        KonekcijaNaBazu baza = eEducationDataBase.Baza;
        public static List<Obavijest> lstObavijesti;
        private static PocetnaAdministracija _instance;
        Administrator administrator;
        public PocetnaAdministracija()
        {
            InitializeComponent();
            dgvObavjestenja.AutoGenerateColumns = false;
            lstObavijesti = baza.Obavijesti.ToList();
            Ucitaj();    
        }
       
        public static PocetnaAdministracija instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PocetnaAdministracija();
                return _instance;

            }

        }
        public void GenerisiAdministratora(Administrator administrator)
        {
            this.administrator = administrator;
        }
        public static List<Obavijest> ListaObavijesti
        {
            set
            {
                lstObavijesti = value;
            }
        }

        public void Ucitaj()
        {
            dgvObavjestenja.DataSource = null;
            dgvObavjestenja.DataSource = lstObavijesti;
        }
        private void PocetnaAdministracija_Load(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void btnDodajObavijest_Click(object sender, EventArgs e)
        {
            //frmDodajObavijest dodajObavijest = new frmDodajObavijest(administrator);
            //this.Hide();
            //dodajObavijest.ShowDialog();
            //this.Show();
            //if (!this.Controls.Contains(ucDodajObavijest.instance))
            //{
                //ucDodajObavijest.instance.GenerisiAdministratora(administrator);
                //this.Controls.Add(ucDodajObavijest.instance);
                //ucDodajObavijest.instance.Dock = DockStyle.Fill;
                //ucDodajObavijest.instance.BringToFront();
            ucDodajObavijest novaObavijest = new ucDodajObavijest(administrator);
            this.Controls.Add(novaObavijest);
            novaObavijest.Dock = DockStyle.Fill;
            novaObavijest.BringToFront();
            //}
            //else
            //{
            //    ucDodajObavijest.instance.GenerisiAdministratora(administrator);
            //    ucDodajObavijest.instance.Show();
            //    ucDodajObavijest.instance.BringToFront();
            //}
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
