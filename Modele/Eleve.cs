using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class Eleve
    {
        int id;
        string nom;
        string prenom;
        int numTel;
        string mail;
        string adresse;
        int bourse;
        int lastId;

        public Eleve(int unId, string unNom, string unPrenom, int unNumTel, string unMail, string uneAdresse, int uneBourse){

            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.mail = unMail;
            this.adresse = uneAdresse;
            this.numTel = unNumTel;
            this.bourse = uneBourse;

            if(id > lastId)
            {
                this.lastId = id;
            }

        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int NumTel { get => numTel; set => numTel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Bourse { get => bourse; set => bourse = value; }

        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom + " Prenom : " + this.prenom + " NumTel : " + this.numTel + " Mail : " + this.mail;
        }
        public int LastId { get => lastId; set => lastId = value; }
    }
}
