using System;

namespace ExemploSemStrategy
{
    public class ProcessadorExame
    {
        public void ProcessarExame(Exame exame)
        {
            if (exame.Tipo == "Sangue")
            {
                Console.WriteLine("Exame de sangue aprovado!");
            }
            else if (exame.Tipo == "RaioX")
            {
                Console.WriteLine("Raio-X aprovado!");
            }
            else
            {
                Console.WriteLine("Tipo de exame desconhecido.");
            }
            //Cada tipo de exame é tratado dentro do mesmo método, com if/else.
            //Para adicionar um novo exame, você precisa alterar essa classe, a ProcessadorExame.
            //O código fica difícil de manter e crescer conforme surgem mais tipos de exame.
        }
    }
}