using Connecte.Controleur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Connecte.Vue
{
    public partial class ModifSeance : Form
    {
        Mgr monManager;

        List<Seance> seances = new List<Seance>();

        List<Prof> profs = new List<Prof>();

        List<string> seanceDispo = new List<string>();

        public ModifSeance()
        {
            monManager = new Mgr();

            InitializeComponent();
        }

        public void affiche()

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

        private void ModifSeance_Load(object sender, EventArgs e)
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

            foreach (Prof p in profs)
            {
                cProf.Items.Add(p.Nom);
            }


            affiche();

            groupBox3.Visible = false;
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            listSeance.Enabled = false;
            groupBox3.Visible = true;
            Seance s = (Seance)listSeance.SelectedItem;
            cProf.Text = s.NomProf.ToString();

            cTranche.Items.Clear();

            seanceDispo.Clear();

            for (int i = 8; i <= 17; i++)
            {
                int res = i + 1;
                if (i != 12)
                {
                    string se = i.ToString() + "h00 - " + res.ToString() + "h00";
                    seanceDispo.Add(se);
                }

            }

            List<string> trancheIndispo = monManager.trancheIndisponibe(s.IdProf, s.Jour);


            List<string> seanceC = seanceDispo;

            foreach (string t in seanceDispo.ToList())
            {
                foreach (string tp in trancheIndispo)
                {
                    if (t == tp && t != s.Tranche.ToString())
                    {
                        seanceC.Remove(tp);
                    }
                }
            }

           

            foreach (string se in seanceC)
            {
                cTranche.Items.Add(se);
            }



        }

        private void cJour_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            Seance s = (Seance)listSeance.SelectedItem;
            cTranche.Items.Clear();

            seanceDispo.Clear();

            for (int i = 8; i <= 17; i++)
            {
                int res = i + 1;
                if (i != 12)
                {
                    string se = i.ToString() + "h00 - " + res.ToString() + "h00";
                    seanceDispo.Add(se);
                }

            }

            List<string> trancheIndispo = monManager.trancheIndisponibe(s.IdProf, cJour.Text);


            List<string> seanceC = seanceDispo;

            foreach (string t in seanceDispo.ToList())
            {
                foreach (string tp in trancheIndispo)
                {
                    if (t == tp)
                    {
                        seanceC.Remove(tp);
                    }
                }
            }

            foreach (string se in seanceC)
            {
                cTranche.Items.Add(se);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seance se = (Seance)listSeance.SelectedItem;

            se.Tranche = cTranche.SelectedItem.ToString();
            se.Jour = cJour.SelectedItem.ToString();
            se.NomProf = cProf.SelectedItem.ToString();

           
                foreach (Prof p in profs)
                {
                    if (se.NomProf == p.Nom)
                    {
                        se.IdProf = p.Id;
                    }
                }


            monManager.updateSeance(se);

            affiche();

            groupBox3.Visible = false;

            listSeance.Enabled = true;
        }
    }
}
