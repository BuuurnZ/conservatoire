using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class Prof
    {
        int id;
        string nom;
        string prenom;
        int numTel;
        string mail;
        string adresse;
        string instrument;
        int salaire;
        int lastId;

        public Prof(int unId, string unNom, string unPrenom, int unNumTel, string unMail, string uneAdresse, string unInstrument, int unSalaire)
        {

            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.mail = unMail;
            this.adresse = uneAdresse;
            this.numTel = unNumTel;
            this.instrument = unInstrument;
            this.salaire = unSalaire;
            if (id > lastId)
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
        public string Instrument { get => instrument; set => instrument = value; }
        public int Salaire { get => salaire; set => salaire = value; }
        public int LastId { get => lastId; set => lastId = value; }

        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom + " Prenom : " + this.prenom + " NumTel : " + this.numTel + " Mail : " + this.mail;
        }

        public string DescNom
        {
            get => this.nom ;
        }
    }
}
