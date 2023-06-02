using Connecte.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connecte.Vue
{
    public partial class Gestion : Form
    {

        Mgr monManager;

        List<Seance> seances = new List<Seance>();

        List<Prof> profs = new List<Prof>();
        public Gestion()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
         
           seances = monManager.chargementSeanceBD();
           profs = monManager.chargementProfBD();

           foreach (Seance s in seances)
            {
                foreach (Prof p in profs)
                {
                    if (s.IdProf == p.Id)
                    {
                        s.NomProf = p.Nom;
                    }
                }
            }
           afficheSeance();

        }

        public void afficheSeance()

        {


            try
            {


                listSeance.DataSource = null;
                listSeance.DataSource = seances;
                listSeance.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        

        private void profToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutProf form4 = new AjoutProf();
            form4.ShowDialog();
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifProf form5 = new ModifProf();
            form5.ShowDialog();
        }

        private void eleveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifEleve form3 = new ModifEleve();
            form3.ShowDialog();
        }

        private void eleveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteEleve form6 = new DeleteEleve();
            form6.ShowDialog();
        }

        private void profToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteProf form7 = new DeleteProf();
            form7.ShowDialog();

        }

        private void seanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteSeance form8 = new DeleteSeance();
            form8.ShowDialog();
        }

        private void séanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutSeance form9 = new AjoutSeance();
            form9.ShowDialog();
        }

        private void seanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifSeance form10 = new ModifSeance();
            form10.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Seance> sc = monManager.chargementSeanceBD();
            Seance s = (Seance)listSeance.SelectedItem;
            foreach (Seance seance in sc)
            {
                if (seance.IdSeance == s.IdSeance)
                {
                    DeleteEleveToSeance form11 = new DeleteEleveToSeance(seance);
                    form11.ShowDialog();
                }
            }
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Seance> sc = monManager.chargementSeanceBD();
            Seance s = (Seance)listSeance.SelectedItem;
            foreach (Seance seance in sc)
            {
                if (seance.IdSeance == s.IdSeance)
                {
                    AjoutEleveToSeance form12 = new AjoutEleveToSeance(seance);
                    form12.ShowDialog();
                }
            }
                
        }

        private void paiementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paiement form13 = new Paiement();
            form13.ShowDialog();
        }

      
        
    }
}
