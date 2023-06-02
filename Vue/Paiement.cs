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

namespace Connecte
{
    public partial class Paiement : Form
    {
        Mgr monManager;
        List<Trimestre> listTrimestresEleve = new List<Trimestre>();
        List<Eleve> eleves = new List<Eleve>();
        public Paiement()
        {
            InitializeComponent();
            monManager = new Mgr();

        }

        private void Paiement_Load(object sender, EventArgs e)
        {
            eleves = monManager.chargementEleveBD();
            affiche();

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

        private void modifier_Click(object sender, EventArgs e)
        {
            Eleve el = (Eleve)listBoxEleve.SelectedItem;

            List<Trimestre> listTrimestresEleve = monManager.recupTrimestre(el.Id);

            listBoxPaiement.DataSource = null;
            listBoxPaiement.DataSource = listTrimestresEleve;
        }

       
    }
}
