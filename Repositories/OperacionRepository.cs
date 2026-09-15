using CalculadoraOracle_19C.Data;
using CalculadoraOracle_19C.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraOracle_19C.Repositories
{
    public class OperacionRepository
    {
        // insertar .
        public void Insertar(Operacion operacion)
        {
            using OracleConnection connection = ConexionOracle.ObtenerConexion();

            connection.Open();

            string sql = @"
                INSERT INTO CALCULADORA_OPERACIONES 
                (
                    NUMERO1, 
                    OPERADOR, 
                    NUMERO2, 
                    RESULTADO
                )
                VALUES 
                (
                    :numero1, 
                    :operador, 
                    :numero2, 
                    :resultado
                )";

            using OracleCommand command = new OracleCommand(sql, connection);

            command.Parameters.Add("numero1", OracleDbType.Decimal).Value = operacion.Numero1;
            command.Parameters.Add("operador", OracleDbType.Varchar2).Value = operacion.Operador;
            command.Parameters.Add("numero2", OracleDbType.Decimal).Value = operacion.Numero2;
            command.Parameters.Add("resultado", OracleDbType.Decimal).Value = operacion.Resultado;

            command.ExecuteNonQuery();
        }   
    }
}
