// See https://aka.ms/new-console-template for more information
using TransporteStrategy;
Console.WriteLine("Hello, World!");

namespace TransporteStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando calculadora com carro
            CalculadoraViagem calculadora = new CalculadoraViagem(new Carro());
            calculadora.Processar(); // Saída: Tempo de viagem de carro: 1 hora

            // Trocando para bicicleta
            calculadora.SetTransporte(new Bicicleta());
            calculadora.Processar(); // Saída: Tempo de viagem de bicicleta: 3 horas

            Console.ReadLine();
        }
    }
}