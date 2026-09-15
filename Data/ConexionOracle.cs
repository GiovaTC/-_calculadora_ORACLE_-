using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraOracle_19C.Data
{
    public static class ConexionOracle
    {
        private const string ConnectionString =
             "User Id=system;" +
            "Password=Tapiero123;" +
            "Data Source=localhost:1521/orcl;";

        public static OracleConnection ObtenerConexion()
        {
            return new OracleConnection(ConnectionString);
        }   
    }
}
