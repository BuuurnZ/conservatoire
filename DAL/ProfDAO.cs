using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    public class ProfDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static Prof getLastId(Prof p) {

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT ID FROM personne WHERE TEL = '"+ p.NumTel+"' ");


                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {

                    p.Id = (int)reader.GetValue(0);


                }

                reader.Close();

                maConnexionSql.closeConnection();


            }
            catch (Exception emp)
            {

                throw (emp);

            }

            return p;

        }
        public static List<Prof> getProf()
        {
            List<Prof> lc = new List<Prof>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT ID, PRENOM, NOM, TEL, MAIL, ADRESSE, INSTRUMENT, SALAIRE FROM personne INNER JOIN prof ON personne.ID = prof.IDPROF; ");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Prof e;

                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string prenom = (string)reader.GetValue(1);
                    string nom = (string)reader.GetValue(2);
                    int numTel = (int)reader.GetValue(3);
                    string mail = (string)reader.GetValue(4);
                    string adresse = (string)reader.GetValue(5);
                    string instrument = (string)reader.GetValue(6);
                    int salaire = (int)reader.GetValue(7);


                    //Instanciation d'un Emplye
                    e = new Prof(id, nom, prenom, numTel, mail, adresse, instrument, salaire);

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

        public static void updateProf(Prof p)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update prof set instrument = '" + p.Instrument + "', salaire = '" + p.Salaire + "' where idProf = " + p.Id);

                int i = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("update personne set nom = '" + p.Nom + "', prenom = '" + p.Prenom + "', tel = '" + p.NumTel + "', mail = '" + p.Mail + "', adresse = '" + p.Adresse + "' where id = " + p.Id);

                int j = Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        public static void deleteProf(Prof p)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from inscription where idprof = " + p.Id);


                int k = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("delete from seance where idprof = " + p.Id);


                int m = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("delete from prof where idprof = " + p.Id);


                int i = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("delete from personne where id = " + p.Id);

                int j = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }

        public static void insertProf(Prof p)
        {


            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("insert into personne (nom, prenom, tel, mail, adresse) values (' " + p.Nom + " ', ' " + p.Prenom + " ',  " + p.NumTel + " , '" + p.Mail + "', '" + p.Adresse + "')");


                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

                p = ProfDAO.getLastId(p);

                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("insert into prof (idprof, instrument, salaire) values (" + p.Id
                    + ",  '" + p.Instrument + "', " + p.Salaire + ")");

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
