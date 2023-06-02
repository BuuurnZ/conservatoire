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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Connecte.Vue
{
    public partial class DeleteEleve : Form
    {
        Mgr monManager;

        List<Eleve> eleves = new List<Eleve>();

        public DeleteEleve()
        {
            monManager = new Mgr();

            InitializeComponent();
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

        private void DeleteEleve_Load(object sender, EventArgs e)
        {
            eleves = monManager.chargementEleveBD();

            affiche();

            bValider.Visible = false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            bValider.Visible = true;
            listBoxEleve.Enabled = false;
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            Eleve ele = (Eleve)listBoxEleve.SelectedItem;

            monManager.supprEleve(ele);

            eleves = monManager.chargementEleveBD();


            affiche();

            bValider.Visible = false;
            listBoxEleve.Enabled = true;
        }
    }
}
