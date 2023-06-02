using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class EleveDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;
        public static List<Eleve> getEleve()
        {
            List<Eleve> lc = new List<Eleve>();
            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT ID, NOM, PRENOM,  TEL, MAIL,  ADRESSE, BOURSE FROM personne INNER JOIN eleve ON personne.ID = eleve.IDELEVE; ");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve e;

                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    int numTel = (int)reader.GetValue(3);
                    string mail = (string)reader.GetValue(4);
                    string adresse = (string)reader.GetValue(5);
                    int bourse = (int)reader.GetValue(6);


                    //Instanciation d'un Emplye
                    e = new Eleve(id, nom, prenom, numTel, mail, adresse, bourse);

                    // Ajout de cet employe à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static void updateEleve(Eleve e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update eleve set bourse = '" + e.Bourse + "' where idEleve = " + e.Id);

                int i = Ocom.ExecuteNonQuery();


                Ocom = maConnexionSql.reqExec("update personne set nom = '" + e.Nom + "', prenom = '" + e.Prenom + "', tel = '" + e.NumTel + "', mail = '" + e.Mail + "', adresse = '" + e.Adresse + "' where id = " + e.Id);

                int j = Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public static void deleteEleve(Eleve e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from payer where ideleve = " + e.Id);

                int m = Ocom.ExecuteNonQuery();


                Ocom = maConnexionSql.reqExec("delete from inscription where ideleve = " + e.Id);

                int k = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("delete from eleve where ideleve = " + e.Id);


                int i = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("delete from personne where id = " + e.Id);

                int j = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }

        public static void insertEleve(Eleve e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("insert into personne (nom, prenom, tel, mail, adresse) values (' " + e.Nom + " ', ' " + e.Prenom + " ',  " + e.NumTel + " , '" + e.Mail + "', '" + e.Adresse + "')");


                int i = Ocom.ExecuteNonQuery();


                Ocom = maConnexionSql.reqExec("insert into eleve (ideleve, bourse) values (" +e.LastId +", " + e.Bourse + ")");

                int j = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }
    }
}
