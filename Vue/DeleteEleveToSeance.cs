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
    public partial class DeleteEleveToSeance : Form
    {
        Mgr monManager;

        List<Eleve> eleves = new List<Eleve>();

        Seance seances;
        public DeleteEleveToSeance(Seance s)
        {
            seances = s;
            monManager = new Mgr();

            InitializeComponent();
        }

        private void DeleteEleveToSeance_Load(object sender, EventArgs e)
        {
            bConfirmer.Visible = false;

            List<Eleve> listEleve = monManager.chargementEleveBD();

            
            foreach (Eleve eleve in listEleve)
            {
               foreach (int id in seances.IdEleveList)
                {
                    if(eleve.Id == id)
                    {
                        eleves.Add(eleve);
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
            Eleve ele = (Eleve)listBoxEleve.SelectedItem;
            monManager.deleteEleveSeance(seances, ele);
            this.Close();


        }
    }
}
