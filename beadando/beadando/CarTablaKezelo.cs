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
    }
}
