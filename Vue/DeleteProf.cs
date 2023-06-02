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
    public partial class DeleteProf : Form
    {

        Mgr monManager;

        List<Prof> profs = new List<Prof>();

        public DeleteProf()
        {
            monManager = new Mgr();

            InitializeComponent();
        }

        public void affiche()

        {


            try
            {


                listBoxProf.DataSource = null;
                listBoxProf.DataSource = profs;
                listBoxProf.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteProf_Load(object sender, EventArgs e)
        {
            profs = monManager.chargementProfBD();

            affiche();

            bValider.Visible = false;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            bValider.Visible = true;
            listBoxProf.Enabled = false;
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            Prof p = (Prof)listBoxProf.SelectedItem;

            monManager.supprProf(p);

            profs = monManager.chargementProfBD();


            affiche();

            bValider.Visible = false;
            listBoxProf.Enabled=true;
        }
    }
}
