using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class Seance
    {
        int idProf;
        int idSeance;
        string tranche;
        string jour;
        int niveau;
        int capacite;
        List<int> idEleveList = new List<int>();
        string nomProf;

        public Seance(int idProf, int idSeance, string tranche, string jour, int niveau, int capacite, List<int> idEleve)
        {
            this.idProf = idProf;
            this.idSeance = idSeance;
            this.tranche = tranche;
            this.jour = jour;
            this.niveau = niveau;
            this.capacite = capacite;
            this.idEleveList = idEleve;
        }

        public Seance(int idProf, string tranche, string jour, int niveau, int capacite)
        {
            this.idProf = idProf;
            this.tranche = tranche;
            this.jour = jour;
            this.niveau = niveau;
            this.capacite = capacite;
        }

        public int IdProf { get => idProf; set => idProf = value; }
        public int IdSeance { get => idSeance; set => idSeance = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public string Jour { get => jour; set => jour = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Capacite { get => capacite; set => capacite = value; }
        public List<int> IdEleveList { get => idEleveList; set => idEleveList = value; }

        public string Description
        {
            get => "Id : " + this.idSeance + "Prof : " + this.nomProf + " Tranche :" + this.Tranche + " Capacité : " + this.Capacite + " Jour : " + this.Jour ;
        }
        public string NomProf { get => nomProf; set => nomProf = value; }
    }
}
