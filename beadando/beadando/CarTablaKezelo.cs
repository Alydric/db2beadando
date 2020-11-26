using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace beadando
{
    class CarTablaKezelo : AdatbazisKapcsolat
    {
        public List<Car> Select()
        {
            List<Car> cars = new List<Car>();
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = kapcsolatNyit();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = @"SELECT marka, tipus, evjarat, ccm, hp, tulajdonos, rendszam FROM cars ORDER BY name";

            OracleDataReader reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Car newCar = new Car();
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
        

    }
}
