using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteStrategy
{
    public class Bicicleta : ITransporte
    {
        public void CalcularTempo()
        {
            Console.WriteLine("Tempo de viagem de bicicleta: 3 horas");
        }
    }
}
