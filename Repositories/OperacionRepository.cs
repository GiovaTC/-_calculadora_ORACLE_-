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
        
        public List<Operacion> ObtenerTodas()
        {
            List<Operacion> operaciones = new();

            using OracleConnection connection = ConexionOracle.ObtenerConexion();

            connection.Open();

            string sql = @"
                SELECT 
                    ID, 
                    NUMERO1, 
                    OPERADOR, 
                    NUMERO2, 
                    RESULTADO, 
                    FECHA_OPERACION
                FROM CALCULADORA_OPERACIONES
                ORDER BY ID DESC";

            using OracleCommand command = new OracleCommand(sql, connection);

            using OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Operacion operacion = new Operacion
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Numero1 = Convert.ToInt32(reader["NUMERO1"]),
                    Operador = reader["OPERADOR"].ToString(),
                    Numero2 = Convert.ToDecimal(reader["NUMERO2"]),
                    Resultado = Convert.ToDecimal(reader["RESULTADO"]),
                    FechaOperacion = Convert.ToDateTime(reader["FECHA_OPERACION"])
                };

                operaciones.Add(operacion);
            }

            return operaciones;
        }
        
        public void EliminarTodas()
        {
            using OracleConnection connection = ConexionOracle.ObtenerConexion();
            
            connection.Open();
            
            string sql = @"
                 DELETE FROM CALCULADORA_OPERACIONES";

            using OracleCommand command = new OracleCommand(
                sql, connection
                );

            command.ExecuteNonQuery();
        }   
    }
}
