using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte
{
    internal class SeanceDAO
    {
        
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        public static List<string> getTranche(Prof p, string joure)
        {
            List<string> tranche = new List<string>();

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT tranche FROM seance WHERE jour = '" +joure+ "' and idprof = " +p.Id+ " ");


                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    string t = (string)reader.GetValue(0);

                    // Ajout de cet employe à la liste 
                    tranche.Add(t);


                }



                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

            return tranche;

        }

        public static List<string> getTranche(int id, string joure)
        {
            List<string> tranche = new List<string>();

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT tranche FROM seance WHERE jour = '" + joure + "' and idprof = " + id + " ");


                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    string t = (string)reader.GetValue(0);

                    // Ajout de cet employe à la liste 
                    tranche.Add(t);


                }



                reader.Close();

                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);

            }

            return tranche;

        }

        public static void deleteSeance(Seance s)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from Inscription where numseance = " + s.IdSeance);

                int j = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("delete from Seance where numseance = " + s.IdSeance);

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }

        public static void deleteEleveToSeance(Seance s, Eleve e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("delete from Inscription where numseance = " + s.IdSeance + " and ideleve = "+e.Id );
                int j = Ocom.ExecuteNonQuery();
                




                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }

        public static void insertSeance(Seance s)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO `seance`(`IDPROF`, `TRANCHE`, `JOUR`, `NIVEAU`, `CAPACITE`) VALUES(" + s.IdProf + ", '" + s.Tranche + "', '" + s.Jour + "'," + s.Niveau + " , " + s.Capacite + ")");


                int i = Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }

        public static void insertEleveToSeance(Seance s, Eleve e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                
                    Ocom = maConnexionSql.reqExec("insert into inscription (`IDPROF`, `IDELEVE`, `NUMSEANCE`) values ( " + s.IdProf + " ,  " + e.Id + ", " + s.IdSeance + " )");


                    int i = Ocom.ExecuteNonQuery();

                
                


                maConnexionSql.closeConnection();


            }

            catch (Exception em)
            {

                throw (em);
            }


        }

        public static List<Seance> getSeance()
        {
            List<Seance> lc = new List<Seance>();
            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT * FROM seance; ");

                
                MySqlDataReader reader = Ocom.ExecuteReader();

                Seance s;


                while (reader.Read())
                {
                    int idProf = (int)reader.GetValue(0);
                    int numSeance = (int)reader.GetValue(1);
                    string tranche = (string)reader.GetValue(2);
                    string jour = (string)reader.GetValue(3);
                    int niveau = (int)reader.GetValue(4);
                    int capacite = (int)reader.GetValue(5);
                    List<int> idEleves = new List<int>();


                    //Instanciation d'un Emplye
                    s = new Seance(idProf, numSeance, tranche, jour, niveau, capacite, idEleves);

                    // Ajout de cet employe à la liste 
                    lc.Add(s);


                }



                reader.Close();

                maConnexionSql.closeConnection();

               

            }

            catch (Exception emp)
            {

                throw (emp);

            }

            try
            {
                foreach (Seance c in lc)
                {
                    List<int> idEleves = new List<int>();

                    maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                    maConnexionSql.openConnection();


                    Ocom = maConnexionSql.reqExec("SELECT ideleve FROM inscription WHERE numseance = " +
                    c.IdSeance + "; ");
                    MySqlDataReader reader = Ocom.ExecuteReader();

                    while (reader.Read())
                    {
                        idEleves.Add((int)reader.GetValue(0));
                    }

                    reader.Close();

                    maConnexionSql.closeConnection();

                    c.IdEleveList = idEleves;
                }
            }

            catch (Exception emp)
            {

                throw (emp);

            }


            return (lc);

        }

        public static void updateSeance(Seance s)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update seance set idprof = " + s.IdProf + ", numseance = " + s.IdSeance + ", tranche = '" + s.Tranche + "', jour = '" + s.Jour + "', niveau = " + s.Niveau + ", capacite = " + s.Capacite + " where numseance = " + s.IdSeance);


                int i = Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("update inscription set idprof = " + s.IdProf + ", numseance = " + s.IdSeance + " where numseance = " + s.IdSeance);


                int j = Ocom.ExecuteNonQuery();


                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

    }
}
