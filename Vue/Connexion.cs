using Connecte.Controleur;
using Connecte.Vue;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Connecte
{
    public partial class Connexion : Form
    {
        Mgr monManager;


        public Connexion()
        {
            InitializeComponent();
            monManager = new Mgr();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(monManager.loginAdmin(login.Text, password.Text) == true)
            {
                Gestion form2 = new Gestion();
                form2.ShowDialog();
            }
            this.Hide();

        }

       
    }


}










