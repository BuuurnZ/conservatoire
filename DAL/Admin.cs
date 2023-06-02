using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.DAL
{
    public class Admin
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;



        // Récupération de la liste des employés
        public static bool checkAdmin(string pseudo, string password)
        {
            bool valid = false;

            if(password != null && pseudo != null) {

                valid = true;
                if(valid) {

                    try
                    {

                        maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                        maConnexionSql.openConnection();

                        string req = "Select mdp from administrateur where pseudo = ' " + pseudo + " ' ";
                        Ocom = maConnexionSql.reqExec(req);
                        MySqlDataReader reader = Ocom.ExecuteReader();

                        while (reader.Read())
                        {
                            if (password != (string)reader.GetValue(0))
                            {
                                valid = false;
                            }
                        }
                           


               

                        reader.Close();
                        maConnexionSql.closeConnection();

                    }

                    catch (Exception emp)
                    {

                        throw (emp);

                    }

                }

            }

            else
            {
                valid = false;
            }


            return valid; 
        }


    }
}
