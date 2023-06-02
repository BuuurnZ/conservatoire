using Connecte.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecte.Vue
{
    public partial class ModifProf : Form
    {
        Mgr monManager;

        List<Prof> profs = new List<Prof>();
        public ModifProf()
        {
            monManager = new Mgr();

            InitializeComponent();
        }

        public void affiche()

        {


            try
            {


                listProf.DataSource = null;
                listProf.DataSource = profs;
                listProf.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ModifProf_Load(object sender, EventArgs e)
        {
            profs = monManager.chargementProfBD();

            affiche();

            groupBox3.Visible = false;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            listProf.Enabled = false;
            Prof p = (Prof)listProf.SelectedItem;
            groupBox3.Visible = true;
            tNom.Text = p.Nom;
            tPrenom.Text = p.Prenom;
            tTelephone.Text = p.NumTel.ToString();
            tMail.Text = p.Mail;
            tAdresse.Text = p.Adresse;
            tSalaire.Text = p.Salaire.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prof p = (Prof)listProf.SelectedItem;
            p.Nom = tNom.Text;
            p.Prenom = tPrenom.Text;
            p.NumTel = Convert.ToInt32(tTelephone.Text);
            p.Mail = tMail.Text;
            p.Adresse = tAdresse.Text;
            p.Salaire = Convert.ToInt32(tSalaire.Text);
            p.Instrument = cInstrument.Text;


            monManager.updateProf(p);

            profs = monManager.chargementProfBD();


            affiche();

            groupBox3.Visible = false;

            listProf.Enabled = true; 

        }
    }
}
