using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteStrategy
{
    public class CalculadoraViagem
    {
        private ITransporte transporte;

        public CalculadoraViagem(ITransporte transporte)
        {
            this.transporte = transporte;
        }

        public void Processar()
        {
            transporte.CalcularTempo();
        }

        public void SetTransporte(ITransporte novoTransporte)
        {
            transporte = novoTransporte;
        }
    }
}

