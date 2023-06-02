using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceEnvoiMail
{
    public class PayerDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        public static List<Payer> getAll()
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from payer;");

            MySqlDataReader reader = connect.queryExec(request);

            List<Payer> listPaiements = new List<Payer>();

            while (reader.Read())
            {
                int idProf = (int)reader[0];
                int idEleve = (int)reader[1];
                int numSeance = (int)reader[2];
                string libelle = (string)reader[3];
                DateTime datePaiement = (DateTime)reader[4];
                int paye = (int)reader[5];

                Payer paiement = new Payer(idProf, idEleve, numSeance, libelle, datePaiement, paye);
                listPaiements.Add(paiement);

            }

            reader.Close();
            connect.closeConnection();

            return listPaiements;
        }
    }
}
