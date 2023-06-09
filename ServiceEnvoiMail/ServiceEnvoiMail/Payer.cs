﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceEnvoiMail
{
    public class Payer
    {
        private int idProf;
        private int idEleve;
        private int numSeance;
        private string libelle;
        private DateTime datePaiement;
        private int paye;

        public Payer(int idProf, int idEleve, int numSeance, string libelle, DateTime datePaiement, int paye)
        {
            this.idProf = idProf;
            this.idEleve = idEleve;
            this.numSeance = numSeance;
            this.libelle = libelle;
            this.datePaiement = datePaiement;
            this.paye = paye;
        }

        public int IdProf { get => idProf; set => idProf = value; }
        public int IdEleve { get => idEleve; set => idEleve = value; }
        public int NumSeance { get => numSeance; set => numSeance = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DatePaiement { get => datePaiement; set => datePaiement = value; }
        public int Paye { get => paye; set => paye = value; }
    }
}
