using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace beadando
{
    class AdatbazisKapcsolat
    {
        public OracleConnection kapcsolatNyit()
        {
            OracleConnection kapcsolat = new OracleConnection();
            string kapcsolatiString = @"...";

            kapcsolat.ConnectionString = kapcsolatiString;
            kapcsolat.Open();

            return kapcsolat;
        }
    }
}
