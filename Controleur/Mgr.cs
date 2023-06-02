using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;


namespace Connecte.Controleur
{
  public  class Mgr
    {


        EleveDAO eleveDAO = new EleveDAO();

        ProfDAO profDAO = new ProfDAO();

        SeanceDAO seanceDAO = new SeanceDAO();


        List<Eleve> maListeEleve;

        List<Prof> maListeProf;

        List<Seance> maListeSeance;

        List<string> maListeTranche;

        public Mgr()
        {
  
            maListeEleve = new List<Eleve>();
            maListeProf = new List<Prof>();
            maListeSeance = new List<Seance>();
            maListeTranche = new List<string>();
        }

        public bool loginAdmin(string pseudo, string password)
        {
            return Admin.checkAdmin(pseudo, password);
        }


        
        // Récupération de la liste des employés à partir de la DAL
        public List<Eleve> chargementEleveBD()
        {

            maListeEleve = EleveDAO.getEleve();

            return (maListeEleve);
        }

        // Mise à jour d'un employé  dans la DAL
        public void updateEleve(Eleve e)
        {

            EleveDAO.updateEleve(e);

        }

        public void insertEleve(Eleve e)
        {
            EleveDAO.insertEleve(e);
        }

        public void supprEleve(Eleve e)
        {
            EleveDAO.deleteEleve(e);
        }

        // Récupération de la liste des employés à partir de la DAL
        public List<Prof> chargementProfBD()
        {

            maListeProf = ProfDAO.getProf();

            return (maListeProf);
        }

        // Mise à jour d'un employé  dans la DAL
        public void updateProf(Prof p)
        {

            ProfDAO.updateProf(p);

        }

        public void insertProfleve(Prof p)
        {
            ProfDAO.insertProf(p);
        }

        public void supprProf(Prof p)
        {
            ProfDAO.deleteProf(p);
        }

        public List<Seance> chargementSeanceBD()
        {

            maListeSeance= SeanceDAO.getSeance();

            return (maListeSeance);
        }

        // Mise à jour d'un employé  dans la DAL
        public void updateSeance(Seance s)
        {

            SeanceDAO.updateSeance(s);

        }

        public void insertSeance(Seance s)
        {
            SeanceDAO.insertSeance(s);
        }

        public void supprSeance(Seance s)
        {
            SeanceDAO.deleteSeance(s);
        }

        public void deleteEleveSeance(Seance s, Eleve e)
        {
            SeanceDAO.deleteEleveToSeance(s, e);
        }

        public void insertEleveSeance(Seance s, Eleve e)
        {
            SeanceDAO.insertEleveToSeance(s, e);
        }

        public List<string> trancheIndisponibe(Prof p, string jour)
        {
            maListeTranche = SeanceDAO.getTranche(p, jour);
            return maListeTranche;
        }

        public List<string> trancheIndisponibe(int id, string jour)
        {
            maListeTranche = SeanceDAO.getTranche(id, jour);
            return maListeTranche;
        }

        public List<Trimestre> recupTrimestre(int idEleve)
        {
            List<Trimestre> listTrimestres = TrimestreDAO.recupTrimestre();
            List<Trimestre> listTrimestresGlobale = new List<Trimestre>();
            foreach (Trimestre unTrimestre in listTrimestres)
            {
                string libelleTrimestre = unTrimestre.getLIBELLE;
                bool paiementTrimestre = TrimestreDAO.recupPaiement(idEleve, libelleTrimestre);

                if (paiementTrimestre == true)
                {
                    Trimestre infosPaiementTrimestre = TrimestreDAO.infosPaiement(idEleve, libelleTrimestre);
                    listTrimestresGlobale.Add(infosPaiementTrimestre);
                }
                else
                {
                    listTrimestresGlobale.Add(unTrimestre);
                }
            }


            return listTrimestresGlobale;
        }
    }
}
