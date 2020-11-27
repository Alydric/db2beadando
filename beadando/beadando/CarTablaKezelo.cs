using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace beadando
{
    class CarTablakezelo : AdatbazisKapcsolat
    {
        public List<Car> Select()
        {
            List<Car> cars = new List<Car>();
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = kapcsolatNyit();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = @"SELECT id, marka, tipus, evjarat, ccm, hp, tulajdonos, rendszam FROM cars ORDER BY name";

            OracleDataReader reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Car newCar = new Car();
                newCar.Id = int.Parse(reader["id"].ToString());
                newCar.Marka = (string)reader["marka"];
                newCar.Tipus = (string)reader["tipus"];
                newCar.Evjarat = int.Parse(reader["evjarat"].ToString());
                newCar.Ccm = int.Parse(reader["ccm"].ToString());
                newCar.Hp = int.Parse(reader["hp"].ToString());
                newCar.Tulajdonos = (string)reader["tulajdonos"];
                newCar.Rendszam = (string)reader["rendszam"];

                cars.Add(newCar);
            }

            reader.Close();
            return cars;
        }

        public int Delete(Car torlendo)
        {
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = kapcsolatNyit();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = "DELETE FROM cars WHERE id = :id";

            OracleParameter pId = new OracleParameter();
            pId.ParameterName = ":id";
            pId.OracleDbType = OracleDbType.Int32;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = torlendo.Id;
            parancs.Parameters.Add(pId);

            return parancs.ExecuteNonQuery();
        }

        public int Insert(Car uj)
        {
            OracleCommand p = new OracleCommand();
            p.Connection = kapcsolatNyit();
            p.CommandType = System.Data.CommandType.Text;
            p.CommandText = "INSERT INTO cars(id, marka, tipus, evjarat, ccm, hp, tulajdonos, rendszam) VALUES(:id, :marka, :tipus, :evjarat, :ccm, :hp, :tulajdonos, :rendszam)";

            OracleParameter pId = new OracleParameter();
            pId.ParameterName = ":id";
            pId.OracleDbType = OracleDbType.Int32;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = uj.Id;

            OracleParameter pMarka = new OracleParameter();
            pMarka.ParameterName = ":marka";
            pMarka.OracleDbType = OracleDbType.Varchar2;
            pMarka.Direction = System.Data.ParameterDirection.Input;
            pMarka.Value = uj.Marka;

            OracleParameter pTipus = new OracleParameter();
            pTipus.ParameterName = ":tipus";
            pTipus.OracleDbType = OracleDbType.Varchar2;
            pTipus.Direction = System.Data.ParameterDirection.Input;
            pTipus.Value = uj.Tipus;

            OracleParameter pEvjarat = new OracleParameter();
            pEvjarat.ParameterName = ":evjarat";
            pEvjarat.OracleDbType = OracleDbType.Int32;
            pEvjarat.Direction = System.Data.ParameterDirection.Input;
            pEvjarat.Value = uj.Evjarat;

            OracleParameter pCcm = new OracleParameter();
            pCcm.ParameterName = ":ccm";
            pCcm.OracleDbType = OracleDbType.Int32;
            pCcm.Direction = System.Data.ParameterDirection.Input;
            pCcm.Value = uj.Ccm;

            OracleParameter pHp = new OracleParameter();
            pHp.ParameterName = ":hp";
            pHp.OracleDbType = OracleDbType.Int32;
            pHp.Direction = System.Data.ParameterDirection.Input;
            pHp.Value = uj.Hp;

            OracleParameter pTulajdonos = new OracleParameter();
            pTulajdonos.ParameterName = ":tulajdonos";
            pTulajdonos.OracleDbType = OracleDbType.Varchar2;
            pTulajdonos.Direction = System.Data.ParameterDirection.Input;
            pTulajdonos.Value = uj.Tulajdonos;

            OracleParameter pRendszam = new OracleParameter();
            pRendszam.ParameterName = ":rendszam";
            pRendszam.OracleDbType = OracleDbType.Varchar2;
            pRendszam.Direction = System.Data.ParameterDirection.Input;
            pRendszam.Value = uj.Rendszam;

            p.Parameters.Add(pId);
            p.Parameters.Add(pMarka);
            p.Parameters.Add(pTipus);
            p.Parameters.Add(pEvjarat);
            p.Parameters.Add(pCcm);
            p.Parameters.Add(pHp);
            p.Parameters.Add(pTulajdonos);
            p.Parameters.Add(pRendszam);


            return p.ExecuteNonQuery();
        }
    }
}
