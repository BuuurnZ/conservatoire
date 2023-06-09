﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceEnvoiMail
{
    public class EleveDAO
    {
        private static ConnexionSql connect = ConnexionSql.getInstance("localhost", "conservatoire", "root", "");

        public static Eleve getById(int id)
        {
            connect.openConnection();

            MySqlCommand request = connect.reqExec("select * from personne inner join eleve on personne.ID = eleve.IDELEVE where IDELEVE = " + id + ";");

            MySqlDataReader reader = connect.queryExec(request);

            Eleve eleve = null;

            while (reader.Read())
            {
                int idEleve = (int)reader[0];
                string nom = (string)reader[1];
                string prenom = (string)reader[2];
                string tel = (string)reader[3];
                string mail = (string)reader[4];
                string adresse = (string)reader[5];
                int bourse = (int)reader[7];

                eleve = new Eleve(idEleve, nom, prenom, tel, mail, adresse, bourse);

            }

            reader.Close();
            connect.closeConnection();

            return eleve;
        }
    }
}
