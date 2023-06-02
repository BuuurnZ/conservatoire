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
    public partial class AjoutEleveToSeance : Form
    {
        Mgr monManager;
        Seance seance;
        List<Seance> lSeance = new List<Seance>();
        List<Eleve> lEleves = new List<Eleve>(); 
        List<Eleve> eleves = new List<Eleve>();
        List<int> idEleIndispo = new List<int>();

        public AjoutEleveToSeance(Seance s)
        {
            monManager = new Mgr();
            seance = s;
            InitializeComponent();
        }

        private void AjoutEleveToSeance_Load(object sender, EventArgs e)
        {
            bConfirmer.Visible= false;

            lEleves = monManager.chargementEleveBD();
            lSeance = monManager.chargementSeanceBD();
            eleves = lEleves;
           
            foreach (Seance s in lSeance)
            {
                if (s.Jour == seance.Jour && s.Tranche == seance.Tranche)
                {
                    foreach (int id in s.IdEleveList)
                    {
                        idEleIndispo.Add(id);
                    }
                }
            }
            foreach (Eleve eleve in lEleves.ToList())
            {
                foreach(int id in seance.IdEleveList)
                {
                    if(eleve.Id == id)
                    {
                        eleves.Remove(eleve);
                    }
                }

                foreach(int id in idEleIndispo)
                {
                    if (eleve.Id == id)
                    {
                        eleves.Remove(eleve);
                    }
                }

            }

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

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            bConfirmer.Visible = true;
            listBoxEleve.Enabled = false;
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            Eleve el = (Eleve)listBoxEleve.SelectedItem;
            monManager.insertEleveSeance(seance, el);
            this.Close();
        }
    }
}
