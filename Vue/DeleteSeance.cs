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

    public partial class DeleteSeance : Form
    {

        Mgr monManager;

        List<Seance> seances = new List<Seance>();

        public DeleteSeance()
        {
            monManager = new Mgr();

            InitializeComponent();
        }

        public void affiche()

        {


            try
            {


                listBoxSeance.DataSource = null;
                listBoxSeance.DataSource = seances;
                listBoxSeance.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteSeance_Load(object sender, EventArgs e)
        {
            seances = monManager.chargementSeanceBD();

            affiche();

            bValider.Visible = false;
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            Seance s = (Seance)listBoxSeance.SelectedItem;

            monManager.supprSeance(s);

            seances = monManager.chargementSeanceBD();


            affiche();

            bValider.Visible = false;
            listBoxSeance.Enabled = true;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            bValider.Visible = true;
            listBoxSeance.Enabled = false;  
        }
    }

}
