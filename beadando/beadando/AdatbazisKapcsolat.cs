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
            kapcsolat.ConnectionString = "User Id=user1;Password=password1;Data Source=oracle";
            kapcsolat.Open();

            return kapcsolat;
        }
    }
}
