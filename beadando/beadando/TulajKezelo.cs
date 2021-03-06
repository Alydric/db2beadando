﻿using System;
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
            parancs.CommandText = @"SELECT id, nev, dateOfBirth FROM tulajok ORDER BY name";

            OracleDataReader reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Tulaj newTulaj = new Tulaj();
                newTulaj.Id = int.Parse(reader["id"].ToString());
                newTulaj.Nev = (string)reader["nev"];
                newTulaj.DateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString());

                tulajok.Add(newTulaj);
            }

            reader.Close();
            return tulajok;
        }

        public int Delete(Tulaj torlendo)
        {
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = kapcsolatNyit();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = "DELETE FROM tulajok WHERE id = :id";

            OracleParameter pId = new OracleParameter();
            pId.ParameterName = ":id";
            pId.OracleDbType = OracleDbType.Int32;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = torlendo.Id;
            parancs.Parameters.Add(pId);

            return parancs.ExecuteNonQuery();
        }

        public int Insert(Tulaj uj)
        {
            OracleCommand p = new OracleCommand();
            p.Connection = kapcsolatNyit();
            p.CommandType = System.Data.CommandType.Text;
            p.CommandText = "INSERT INTO tulajok(id, nev, dateOfBirth) VALUES(:id, :nev, :dateOfBirth)";

            OracleParameter pId = new OracleParameter();
            pId.ParameterName = ":id";
            pId.OracleDbType = OracleDbType.Int32;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = uj.Id;

            OracleParameter pNev = new OracleParameter();
            pNev.ParameterName = ":nev";
            pNev.OracleDbType = OracleDbType.Varchar2;
            pNev.Direction = System.Data.ParameterDirection.Input;
            pNev.Value = uj.Nev;

            OracleParameter pDateOfBirth = new OracleParameter();
            pDateOfBirth.ParameterName = ":dateOfBirth";
            pDateOfBirth.OracleDbType = OracleDbType.Date;
            pDateOfBirth.Direction = System.Data.ParameterDirection.Input;
            pDateOfBirth.Value = uj.DateOfBirth;

            p.Parameters.Add(pId);
            p.Parameters.Add(pNev);
            p.Parameters.Add(pDateOfBirth);

            return p.ExecuteNonQuery();
        }
    }
}
