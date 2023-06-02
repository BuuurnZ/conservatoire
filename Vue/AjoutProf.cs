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
    public partial class AjoutProf : Form
    {
        Mgr monManager;
        public AjoutProf()
        {
            monManager = new Mgr();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insérer_Click(object sender, EventArgs e)
        {
            Prof p = new Prof(1, tNom.Text, tPrenom.Text, Convert.ToInt32(tTelophone.Text),tMail.Text, tAdresse
                .Text, comboBox1.Text, Convert.ToInt32(tSalaire.Text));

            monManager.insertProfleve(p);
            Form.ActiveForm.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
