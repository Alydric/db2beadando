using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace beadando
{
    class TulajKezelo : AdatbazisKapcsolat
    {
        public List<Tulaj> Select()
        {
            List<Tulaj> tulajok = new List<Tulaj>();
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = kapcsolatNyit();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = @"SELECT id, name, dateOfBirth FROM tulajok ORDER BY name";

            OracleDataReader reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Tulaj newTulaj = new Tulaj();
                newTulaj.Id = int.Parse(reader["id"].ToString());
                newTulaj.Name = (string)reader["name"];
                newTulaj.DateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString());

                tulajok.Add(newTulaj);
            }

            reader.Close();
            return tulajok;
        }
    }
}
