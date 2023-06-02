using Connecte.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecte
{
    public partial class ModifEleve : Form
    {
        Mgr monManager;

        List<Eleve> eleves = new List<Eleve>();

       
        public ModifEleve()
        {
            monManager = new Mgr();

            InitializeComponent();
        }

        private void AjoutEleve_Load(object sender, EventArgs e)
        {
            eleves = monManager.chargementEleveBD();

            affiche();

            groupBox3.Visible = false;
        }

        public void affiche()

        {


            try
            {


                listBoxEleve.DataSource = null;
                listBoxEleve.DataSource = eleves;
                listBoxEleve.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void listBoxEleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrenom_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eleve ele = (Eleve)listBoxEleve.SelectedItem;

            ele.Nom = tNom.Text;
            ele.Prenom = tPrenom.Text;
            ele.NumTel= Convert.ToInt32(tTelephone.Text);
            ele.Mail = tMail.Text;
            ele.Adresse = tAdresse.Text;
            ele.Bourse = Convert.ToInt32(tBourse.Text);


            monManager.updateEleve(ele);

            eleves = monManager.chargementEleveBD();


            affiche();

            groupBox3.Visible = false;

            listBoxEleve.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            Eleve ele = (Eleve)listBoxEleve.SelectedItem;
            groupBox3.Visible = true;
            tNom.Text = ele.Nom;
            tPrenom.Text = ele.Prenom;
            tTelephone.Text = ele.NumTel.ToString();
            tMail.Text = ele.Mail;
            tAdresse.Text = ele.Adresse;
            tBourse.Text = ele.Bourse.ToString();
            listBoxEleve.Enabled = false;


        }
    }
}
