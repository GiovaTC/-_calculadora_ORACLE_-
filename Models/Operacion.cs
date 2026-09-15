using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraOracle_19C.Models
{
    public class Operacion
    {
        public int Id { get; set; }
        public decimal Numero1 { get; set; }
        public string Operador { get; set; } = string.Empty;
        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }
        public DateTime FechaOperacion { get; set; }
    }   
}
