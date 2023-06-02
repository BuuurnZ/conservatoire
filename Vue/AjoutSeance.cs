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
    public partial class AjoutSeance : Form
    {
        Mgr monManager;

        List<string> seanceDispo = new List<string>();
        List<Prof> lp = new List<Prof>();
        public AjoutSeance()
        {
            monManager = new Mgr();

            InitializeComponent();
        }

        private void AjoutSeance_Load(object sender, EventArgs e)
        {
            lp = monManager.chargementProfBD();

            cTranche.Visible = false;
            seanceDispo.Clear();
            
            for(int i = 8; i <= 17; i++) {
                int res = i + 1;
                if(i != 12)
                {
                    string se = i.ToString() + "h00 - " + res.ToString() + "h00";
                    seanceDispo.Add(se);
                }
              
            }


            foreach(Prof p in lp)
            {
                cProf.Items.Add(p.Nom);
            }
            affiche();

           
        }
        public void affiche()

        {


            try
            {

                cProf.DataSource = null;
                cProf.DataSource = lp;
                cProf.DisplayMember = "DescNom";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void checkInfo()
        {
            if(cProf.SelectedIndex != -1  && cJour.SelectedIndex != -1) {

                
                List<string> trancheIndispo = monManager.trancheIndisponibe((Prof)cProf.SelectedItem , cJour.SelectedItem.ToString());

                List<string> seance = seanceDispo;

                foreach(string t in seanceDispo.ToList())
                {
                    foreach(string tp in trancheIndispo)
                    {
                        if(t == tp)
                        {
                           seance.Remove(tp);
                        }
                    }
                }


                foreach (string se in seance)
                {
                    cTranche.Items.Add(se);
                }

                cTranche.Visible = true;
                cProf.Enabled = false;
                cJour.Enabled = false;

            }
        }

        private void cProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkInfo();
        }

        private void cJour_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkInfo();

        }

        private void bValider_Click(object sender, EventArgs e)
        {
            Prof p = (Prof)cProf.SelectedItem;
            Seance s = new Seance(p.Id, cTranche.SelectedItem.ToString(), cJour.SelectedItem.ToString(), Convert.ToInt32(cNiveau.SelectedItem.ToString()), Convert.ToInt32(cCapacite.SelectedItem.ToString()));
            monManager.insertSeance(s);
            Form.ActiveForm.Close();

        }
    }
}
